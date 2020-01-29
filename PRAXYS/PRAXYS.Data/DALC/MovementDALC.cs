using Microsoft.EntityFrameworkCore;
using PRAXYS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data.DALC
{
    public static class MovementDALC
    {

        public static async Task<List<Movement>> MovementGetAll(this AppDbContext _context)
        {
            try
            {
                return await _context.Movement
                    .ToListAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<Movement> MovementGet(this AppDbContext _context,int id)
        {
            try
            {
                return await _context.Movement
                    .Where(x => x.ID == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static async Task<bool> MovementUpdate(this AppDbContext _context, Movement item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task<bool> MovementPost(this AppDbContext _context, Movement item)
        {
            try
            {
                _context.Movement.Add(item);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task<bool> MovementDelete(this AppDbContext _context, Movement item)
        {
            try
            {
                _context.Movement.Remove(item);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
