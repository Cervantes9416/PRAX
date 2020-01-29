using Microsoft.EntityFrameworkCore;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class EndorsementTypeDALC
    {
        public static Task<List<EndorsementType>> EndorsementTypeGetAll(this AppDbContext context)
        {
            return context.EndorsementType
                .ToListAsync();
        }
    }
}
