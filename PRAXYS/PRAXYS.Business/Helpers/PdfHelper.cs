using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Hosting;
using PRAXYS.Data.Report;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace PRAXYS.Business.Helpers
{
    public static class PdfHelper
    {
        
        static Font bigCalibri = FontFactory.GetFont(FontFactory.COURIER_BOLD, 12f);
        static Font calibri = FontFactory.GetFont("Calibri", 9f);
        static Font mediumHeader = FontFactory.GetFont("Calibri", 9.5f);
        static Font smallHeader = FontFactory.GetFont("Calibri", 8.5f);
        static Font xsmallHeader = FontFactory.GetFont("Calibri", 8f);
        static Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9f);
        static Font xxsmallHeader = FontFactory.GetFont("Calibri", 6f);
        static Font italicFont = FontFactory.GetFont(FontFactory.TIMES_ITALIC, 8f);

        private static string GetFullName(Agent agent )
        {
            if (agent.PersonType == "Fisica")
            {
                return $"{agent.Name} {agent.LastName} {agent.SecondLastName}";
            }
            else
            {
                return $"{agent.CompanyName}";
            }
        }

        public static void GenerateReportValidDocument(this IHostingEnvironment _env, List<ReportModel> reports)
        {
            var path = Path.Combine(_env.ContentRootPath,"Content","logo.png");
            Image logoImage = Image.GetInstance(path);
            logoImage.ScaleAbsolute(150f, 40f);
            PdfPCell logo = new PdfPCell(logoImage);
            logo.Colspan = 1;
            logo.PaddingLeft = 10;
            logo.PaddingTop = 10;
            logo.PaddingBottom = 10;
            logo.Border = 0;

            FileStream fs = new FileStream("c://pdf/reporte.pdf", FileMode.Create);
            
            //CREAR DOCUMENTO
            Document document = new Document(PageSize.LETTER.Rotate(), 10,10,10,10);
            PdfWriter pw = PdfWriter.GetInstance(document, fs);

            //DEFINIR VARIABLES
            decimal TotalNetPremiurmPerCompany = 0;
            decimal TotalPremiumPerCompany = 0;
            decimal TotalNetPremiumPerAgent = 0;
            decimal TotalPremiumPerAgent = 0;

            document.Open();

            //HEADER
            PdfPTable Header = new PdfPTable(3);
            Header.WidthPercentage = 100;
            Header.DefaultCell.Border = 0;

            Header.AddCell(logo);
            Header.AddCell(new PdfPCell(new Phrase("Reporte Polizas Vigentes", new Font(Font.FontFamily.HELVETICA, 14, 1))) 
            { 
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0,
                PaddingTop = 10,
                PaddingBottom = 10
            });
            Header.AddCell(new PdfPCell(new Phrase("")) 
            { 
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = 0,
            });

            document.Add(Header);


            //BODY CONTENT
            PdfPTable table = new PdfPTable(8);
            float[] widths = new float[] { 2f, 1f, 1f, 2f, 2f, 1f, 1f,1f };
            table.SetWidths(widths);
            table.WidthPercentage = 100;
            table.PaddingTop = 15;

            table.AddCell(new PdfPCell(new Phrase("Documento",smallHeader)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
            table.AddCell(new PdfPCell(new Phrase("Desde",smallHeader)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
            table.AddCell(new PdfPCell(new Phrase("Hasta",smallHeader)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
            table.AddCell(new PdfPCell(new Phrase("Cliente",smallHeader)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
            table.AddCell(new PdfPCell(new Phrase("Agente",smallHeader)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
            table.AddCell(new PdfPCell(new Phrase("Sub Ramo",smallHeader)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
            table.AddCell(new PdfPCell(new Phrase("Prima Neta",smallHeader)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
            table.AddCell(new PdfPCell(new Phrase("Prima Total", smallHeader)) { HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });

            //CONTENIIDO DEL REPORTE
            foreach (var item in reports)
            {
                table.AddCell(new PdfPCell(new Phrase("")) { Colspan = 8 });
                table.AddCell(new PdfPCell(new Phrase($"{GetFullName(item.Agents)}", boldFont))
                {
                    Colspan = 8,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    BackgroundColor = BaseColor.LIGHT_GRAY,
                    BorderColorTop = BaseColor.BLACK,
                    PaddingTop = 3,
                    PaddingBottom = 5,
                });

                foreach (var company in item.Companies)
                {
                    //CONTENIDO Compañia
                    table.AddCell(new PdfPCell(new Phrase($"{company.CompanyName}", boldFont))
                    {
                        Colspan = 2,
                        PaddingBottom = 3,
                        Border = Rectangle.BOTTOM_BORDER
                    });
                    table.AddCell(new PdfPCell(new Phrase(""))
                    {
                        Colspan = 6,
                        Border = Rectangle.BOTTOM_BORDER
                    });

                    foreach (var insurance in item.Insurances.Where(x => x.CompanyID == company.ID))
                    {
                        //CONTENIDO DE LA TABLA
                       
                            table.AddCell(new PdfPCell(new Phrase($"{insurance.InsuranceNumber}", calibri)) { Border = 0 });
                            table.AddCell(new PdfPCell(new Phrase(insurance.ValidFrom.Value.ToString("dd-MM-yyyy"), calibri)) { Border = 0 });
                            table.AddCell(new PdfPCell(new Phrase(insurance.ValidThrought.Value.ToString("dd-MM-yyyy"), calibri)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            table.AddCell(new PdfPCell(new Phrase($"{insurance.ClientID}", smallHeader)) { HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            table.AddCell(new PdfPCell(new Phrase(GetFullName(insurance.Agent), smallHeader)) { Border = 0 });
                            table.AddCell(new PdfPCell(new Phrase($"{insurance.SubBranchID.ToString()}", smallHeader)) { Border = 0 });
                            table.AddCell(new PdfPCell(new Phrase($"{insurance.NetPremium}", smallHeader)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });
                            table.AddCell(new PdfPCell(new Phrase($"{insurance.TotalPremium}", smallHeader)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });

                        //TotalNetPremiurmPerCompany += insurance.NetPremium.Value;
                        TotalPremiumPerCompany += insurance.TotalPremium;
                    }//FOR INSURANCES

                    table.AddCell(new PdfPCell(new Phrase($"Totales {company.CompanyName}", boldFont))
                    {
                        Border = Rectangle.NO_BORDER,
                        Colspan = 6,
                        HorizontalAlignment = Element.ALIGN_RIGHT,
                    });

                    table.AddCell(new PdfPCell(new Phrase($"{TotalNetPremiurmPerCompany}", boldFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = Rectangle.TOP_BORDER });
                    table.AddCell(new PdfPCell(new Phrase($"{TotalPremiumPerCompany}", boldFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, Border = Rectangle.TOP_BORDER });

                    
                }//FOR COMPANIES

                table.AddCell(new PdfPCell(new Phrase($"Totales {GetFullName(item.Agents)}", boldFont))
                {
                    Border = Rectangle.TOP_BORDER,
                    Colspan = 6,
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                });

                TotalNetPremiumPerAgent += TotalNetPremiurmPerCompany;
                TotalPremiumPerAgent += TotalPremiumPerCompany;

                table.AddCell(new PdfPCell(new Phrase($"{TotalNetPremiumPerAgent}", boldFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                table.AddCell(new PdfPCell(new Phrase($"{TotalPremiumPerAgent}", boldFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });

                TotalNetPremiurmPerCompany = 0;
                TotalPremiumPerCompany = 0;
                TotalPremiumPerAgent = 0;
                TotalNetPremiumPerAgent = 0;
            }//FOR AGENTS

            //------->

            document.Add(table);

            document.Close();
        }
    }

    class HeaderFooter : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfPTable Header = new PdfPTable(3);
            Header.WidthPercentage = 100;
            Header.DefaultCell.Border = 0;

            Header.AddCell(new Paragraph("Imagen Polza"));
            Header.AddCell(new PdfPCell(new Phrase("Reporte Polizas Vigentes"))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,

            });
            Header.AddCell(new Paragraph("Numero de pagina"));

            Header.WriteSelectedRows(0, -1, document.LeftMargin, document.PageSize.GetTop(document.TopMargin) + 40, writer.DirectContent);
        }
    }
}
