using AutoMapper;
using PRAXYS.Commons.Entities;
using PRAXYS.Commons.Entities.Address;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Entities.Bond;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Commons.Entities.Branch;
using PRAXYS.Commons.Entities.Client;
using PRAXYS.Commons.Entities.ComissionPayment;
using PRAXYS.Commons.Entities.Company;
using PRAXYS.Commons.Entities.CoveragePlan;
using PRAXYS.Commons.Entities.DocumentType;
using PRAXYS.Commons.Entities.Endorsement;
using PRAXYS.Commons.Entities.Insurance;
using PRAXYS.Commons.Entities.PaymentInformation;
using PRAXYS.Commons.Entities.PaymentType;
using PRAXYS.Commons.Entities.Ramo;
using PRAXYS.Commons.Entities.RegisterPayment;
using PRAXYS.Commons.Entities.SubAgent;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRAXYS.Business.Profiles
{
    public class EntityProfile : Profile
    {
        public EntityProfile()
        {
            #region SECTION COVERAGE
            this.CreateMap<Coverage, CoverageModel>()
                .ReverseMap();

            this.CreateMap<Ramo_Coverage, RamoCoverageModel>()
                .ForMember(member => member.Ramo, config => config.MapFrom(u => u.Branch.Name))
                .ReverseMap()
                .ForMember(x => x.Branch, u => u.Ignore());

            //-------COVERAGE PLAN
            this.CreateMap<CoveragePlan, CoveragePlanModel>()
                .ReverseMap();

            this.CreateMap<CoveragePlan_Coverage, CoveragePlanCoveragesModel>()
                .ForMember(member => member.Coverage, config => config.MapFrom(u => u.Coverage.Descripcion))
                .ReverseMap()
                .ForMember(x => x.Coverage, u => u.Ignore());

            #endregion

            #region SECTION BRANCH
            this.CreateMap<Branch, BranchModel>()
                .ReverseMap();

            this.CreateMap<SubBranch, SubBranchModel>()
                .ReverseMap();

            #endregion

            #region SECTION COMPANY
            //-------COMPANY
            this.CreateMap<Company, CompanyModel>()
                .ReverseMap();

            this.CreateMap<Company_Address, CompanyAddressModel>()
                .ReverseMap();

            this.CreateMap<Company, CompanyMinModel>()
                .ReverseMap();

            #endregion

            #region SECTION ADDRESS
            //-------ADDRESS
            this.CreateMap<Address, AddressModel>()
                .ReverseMap();

            #endregion

            #region SECTION CLIENTS
            //-------CLIENTS
            this.CreateMap<Clients, ClientModel>()
                .ReverseMap();

            this.CreateMap<Client_Address, ClientAddressModel>()
                .ReverseMap();

            this.CreateMap<Clients, ClientMinModel>()
                .ReverseMap();

            this.CreateMap<ClientDocumentation, ClientDocumentationModel>()
                .ReverseMap();

            #endregion

            #region SECTION AGENTS
            //--------AGENTS
            this.CreateMap<Agent, AgentModel>()
                .ReverseMap();

            this.CreateMap<Agent_Address, AgentAddressModel>()
                .ReverseMap();

            #endregion

            #region SECTION INSURANCE
            //-----INSURANCE
            this.CreateMap<Insurance, InsuranceModel>()
                .ForMember(x => x.Status, p => p.MapFrom(u => u.Status))
                .ReverseMap();

            this.CreateMap<Insurance, InsuranceListModel>()
                .ForMember(x => x.InsuranceType, p => p.MapFrom(u => u.SubBranch.Name))
                .ForMember(x => x.PersonType, p => p.MapFrom(u => u.Client.PersonType))
                .ReverseMap()
                .ForMember(x => x.SubBranch, p => p.Ignore());

            this.CreateMap<InsuranceDocumentation, InsuranceDocumentationModel>()
                .ReverseMap();

            this.CreateMap<EndorsementModel,Insurance>()
                .ForMember(x => x.InsuranceNumber, p=> p.MapFrom( u => u.Insurance.InsuranceNumber))
                .ForMember(x => x.ClientID, p => p.MapFrom(u => u.Insurance.ClientID))
                .ForMember(x => x.AgentID, p => p.MapFrom(u => u.Insurance.AgentID) )
                .ForMember(x => x.CompanyID, p => p.MapFrom(u => u.Insurance.CompanyID))
                .ReverseMap();

            this.CreateMap<Insurance, InsuranceEndorsementModel>()
                .ForMember(x => x.EndorsementType, p => p.MapFrom(u => (u.Endorsements.Count > 0) ? u.Endorsements.First().EndorsementType.Descripcion : ""))
                .ForMember(x => x.EndorsementNumber, p => p.MapFrom(u => u.EndorsementNumber))
                .ForMember(x => x.Description, p => p.MapFrom(u => (u.Endorsements.Count > 0) ? u.Endorsements.First().Description : ""));
            #endregion

            #region SECTION PAYMENT INFORMATION
            
            this.CreateMap<PaymentInformation, PaymentInformationModel>()
                .ReverseMap();

            #endregion

            #region SECTION SUB AGENT
            //------SUBAGENT
            this.CreateMap<SubAgent, SubAgentModel>()
                .ReverseMap();
            #endregion

            #region SECTION PAYMENTS

            this.CreateMap<PaymentType, PaymentTypeModel>()
                .ReverseMap();

            this.CreateMap<PaymentInformation, PaymentInformationModel>()
                .ForMember(x => x.InsuranceNumber, config => config.MapFrom(u => u.Insurance.InsuranceNumber))
                .ReverseMap();
            //.ForMember(x => x.Insurance, u => u.Ignore());

            this.CreateMap<RegisterPayment, RegisterPaymentModel>()
                .ReverseMap();

            this.CreateMap<RegisterPayment, InsurancePaymentModel>()
               .ReverseMap();
            #endregion

            #region SECTION BOND

            this.CreateMap<Bond, BondModel>()
                .ReverseMap();

            this.CreateMap<Bond, BondListModel>()
                .ForMember(x => x.Agent, p => p.MapFrom(u => u.Agent.CompanyName))
                .ForMember(x => x.Company, p => p.MapFrom(u => u.Company.CompanyName))
                .ForMember(x => x.Client, p => p.MapFrom(u => u.Client.Name))
                .ReverseMap();

            this.CreateMap<BondPayment, BondPaymentModel>()
                .ReverseMap();

            this.CreateMap<CommissionPayment, ComissionPaymentModel>()
                .ReverseMap();
            #endregion

            #region SECTION DOCUMENT TYPE

            this.CreateMap<DocumentType, DocumentTypeModel>()
                .ReverseMap();

            #endregion

            #region SECTION ENDORSEMENT 
            this.CreateMap<Endorsement, EndorsementModel>()
                .ReverseMap();

            this.CreateMap<EndorsementType, EndorsementTypeModel>()
                .ReverseMap();
            #endregion
        }
    }
}
