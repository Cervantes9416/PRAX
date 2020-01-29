using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRAXYS.Data
{
    public interface IDataLogic<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Post(T item);
        Task<T> Put(int id, T item);
        Task<T> Delete();
    }
}
