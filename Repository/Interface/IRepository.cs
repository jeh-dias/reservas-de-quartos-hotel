using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IRepository<T>
    {
        bool Add(T obj);
        List<T> GetList();
    }
}
