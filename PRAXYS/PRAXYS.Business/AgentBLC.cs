using AutoMapper;
using PRAXYS.Business.Interfaces;
using PRAXYS.Commons.Entities.Agent;
using PRAXYS.Commons.Entities.BondPayment;
using PRAXYS.Data;
using PRAXYS.Data.Intefaces;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PRAXYS.Data.DALC;

namespace PRAXYS.Business
{
    public class AgentBLC : IAgentBLC
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AgentBLC(
            IMapper mapper,
            AppDbContext context)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<bool> Delete(int id)
        {
            return _context.AgentDelete(id);
        }

        public async Task<AgentModel> Get(int id)
        {
            var agent = await _context.AgentGet(id);
            return _mapper.Map<AgentModel>(agent);
        }

        public async Task<List<AgentModel>> GetAll()
        {
            var datos = await _context.AgentGetAll();
            return _mapper.Map<List<AgentModel>>(datos);
        }

        public async Task<List<AgentModel>> GetAllByDetails()
        {
            var datos = await _context.AgentGetAllByDetails();
            return _mapper.Map<List<AgentModel>>(datos);
        }

        public async Task<bool> Post(AgentModel item)
        {
            var agent = _mapper.Map<Agent>(item);
            return await _context.AgentPost(agent);
        }

        public async Task<bool> Put(int id ,AgentModel item)
        {
            var agent = _mapper.Map<Agent>(item);
            return await _context.AgentPut(id,agent);
        }
    }
}
