using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.Branch;
using PRAXYS.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;
using AutoMapper;
using PRAXYS.Shared.Entities;

namespace PRAXYS.Business
{
    public class BranchBLC : IBranchBLC
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public BranchBLC(AppDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        #region BRANCH METHODS
        public async Task<List<BranchModel>> GetAllBranch()
        {
            var branchs = await _context.BranchGetAll();
            return _mapper.Map<List<BranchModel>>(branchs);
        }

        public async Task<bool> PostBranch(BranchModel model)
        {
            var breanch = _mapper.Map<Branch>(model);
            return await _context.BranchCreate(breanch);
        }

        public async Task<bool> PutBranch(BranchModel model)
        {
            var breanch = _mapper.Map<Branch>(model);
            return await _context.BranchPut(breanch);
        }

        public async Task<bool> DeleteBranch(int id)
        {
            return await _context.BranchDelete(id);
        }

        #endregion

        #region SUB BRANCH METHODS
        public async Task<List<SubBranchModel>> GetAllSubBranch()
        {
            var subBranchs = await _context.SubBranchGetAll();
            return  _mapper.Map<List<SubBranchModel>>(subBranchs);
        }

        public async Task<List<SubBranchModel>> GetAllSubBranchWithBranchID(int BranchID)
        {
            var subBranchs = await _context.SubBranchGetAllWithBranchID(BranchID);
            return _mapper.Map<List<SubBranchModel>>(subBranchs);
        }

        public async Task<SubBranchModel> GetSubBranch(int id)
        {
            var subBranch = await _context.SubBranchGet(id);
            return _mapper.Map<SubBranchModel>(subBranch);
        }

        public async Task<bool> DeleteSubBranch(int id)
        {
            return await _context.SubBranchDelete(id);
        }

        //-------------------------------------
        public async Task<bool> PostSubBranch(SubBranchModel model)
        {
            var breanch = _mapper.Map<SubBranch>(model);
            return await _context.SubBranchPost(breanch);
        }

        public async Task<bool> PutSubBranch(SubBranchModel model)
        {
            var breanch = _mapper.Map<SubBranch>(model);
            return await _context.SubBranchPut(breanch);
        }
        #endregion
    }
}
