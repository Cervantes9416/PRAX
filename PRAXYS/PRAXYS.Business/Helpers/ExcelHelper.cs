using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace PRAXYS.Business.Helpers
{
    public static class ExcelHelper
    {
        public static void GenerateReport()
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Reporte");

                worksheet.Cells["A1:B1"].Merge = true;
                worksheet.Cells["C1:D1"].Merge = true;

                worksheet.Cells["A1"].Value = "Documento";
                worksheet.Cells["B1"].Value = "Desde";
                worksheet.Cells["C1"].Value = "Hasta";
                worksheet.Cells["D1"].Value = "Cliente";
                worksheet.Cells["E1"].Value = "Agente";
                worksheet.Cells["F1"].Value = "Sub Ramo";
                worksheet.Cells["G1"].Value = "Prima Neta";
                worksheet.Cells["H1"].Value = "Prima Total";
                
                worksheet.Cells["A1:H1"].Style.Font.Size = 9;
                worksheet.Cells["A1:H1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["A2:H2"].Merge = true;
                worksheet.Cells["A2"].Value = "DIANA BERENICE SERRANO ROMERO";
                worksheet.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["A2"].Style.Font.Size = 15;
                worksheet.Cells["A2"].Style.Font.Bold = true;

                var CompanyCell = worksheet.Cells["A3:H3"];
                CompanyCell.Merge = true;
                CompanyCell.Value = "Empresa Patito";
                CompanyCell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                var lengthArray = 6;
                for (int i = 4; i <= lengthArray; i++)
                {
                    worksheet.Cells[$"A{i}"].Value = "A9-121212";
                    worksheet.Cells[$"B{i}"].Value = "12/09/2019";
                    worksheet.Cells[$"C{i}"].Value = "12/06/2020";
                    worksheet.Cells[$"D{i}"].Value = "Cliente Test";
                    worksheet.Cells[$"E{i}"].Value = "Agente Test";
                    worksheet.Cells[$"F{i}"].Value = "Vehiculo";
                    worksheet.Cells[$"G{i}"].Value = "10,000";
                    worksheet.Cells[$"H{i}"].Value = "20,000";

                    if (i == lengthArray)
                    {
                        var Totals = worksheet.Cells[$"A{i + 1}:F{i + 1}"];
                        Totals.Merge = true;
                        Totals.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                        Totals.Value = "Totales Diana Berenice Serrano Romero";

                        worksheet.Cells[$"G{i + 1}"].Value = "12112";
                        worksheet.Cells[$"H{i + 1}"].Value = "12211";
                    }
                }

                worksheet.Cells.AutoFitColumns();

                FileInfo fi = new FileInfo(@"c://pdf/reporte.xlsx");
                package.SaveAs(fi);
            }
        }
    }
}
