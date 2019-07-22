using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    /// <summary>
    /// Interface para a classe base de repositório
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        bool Add(T obj);
        List<T> GetList();
    }
}
