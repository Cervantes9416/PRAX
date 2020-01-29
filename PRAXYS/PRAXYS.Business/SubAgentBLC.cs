using AutoMapper;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Data;
using PRAXYS.Data.Intefaces;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;
using PRAXYS.Commons.Entities.SubAgent;

namespace PRAXYS.Business
{
    public class SubAgentBLC : ISubAgentBLC
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;

        public SubAgentBLC(
            AppDbContext context,
            IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public Task<bool> Delete(int id)
        {
            return _context.SubAgentDelete(id);
        }

        public async Task<SubAgentModel> Get(int id)
        {
            var subAgent = await _context.SubAgentGet(id);
            return _mapper.Map<SubAgentModel>(subAgent);
        }

        public async Task<List<SubAgentModel>> GetAll()
        {
            var subAgents = await _context.SubAgentGetAll();
            return _mapper.Map<List<SubAgentModel>>(subAgents);
        }

        public async Task<bool> Post(SubAgentModel item)
        {
            var subAgent = _mapper.Map<SubAgent>(item);
            return await _context.SubAgentPost(subAgent);
        }

        public async Task<bool> Put(int id, SubAgentModel item)
        {
            var subAgent = _mapper.Map<SubAgent>(item);
            return await _context.SubAgentPut(id, subAgent);
        }
    }
}
