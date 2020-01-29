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
using PRAXYS.Commons.Entities.Client;
using AutoMapper;

namespace PRAXYS.Business
{
    public class ClientBLC : IClientBLC
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ClientBLC(AppDbContext context,
            IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<ClientModel> Delete(int id)
        {
            var client = await _context.ClientsDelete(id);
            return _mapper.Map<ClientModel>(client);
        }

        public async Task<ClientModel> Get(int id)
        {
            var client = await _context.ClientsGet(id);
            return _mapper.Map<ClientModel>(client);
        }

        public async Task<List<ClientModel>> GetAll()
        {
            var clients = await _context.ClientsGetAll();
            return _mapper.Map<List<ClientModel>>(clients);
        }

        public async Task<ClientModel> GetByDetails(int id)
        {
            var client = await _context.ClientsGetByDetails(id);
            return _mapper.Map<ClientModel>(client);

        }

        public async Task<ClientModel> Post(ClientModel item)
        {
            var client = _mapper.Map<Clients>(item);
            var result = await _context.ClientPost(client);

            return _mapper.Map<ClientModel>(result);
        }

        public async Task<bool> Put(int id, ClientModel item)
        {
            var client = _mapper.Map<Clients>(item);
            return await _context.ClientPut(id,client);
        }
    }
}
