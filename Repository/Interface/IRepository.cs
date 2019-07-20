using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IRepository<T>
    {
        void Add(T obj);
        List<T> GetList();
    }
}
