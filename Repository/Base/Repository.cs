using Domain;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Base
{
    /// <summary>
    /// Repositório base, responsável pelas operações de
    /// adição, listagem de qualquer entidade
    /// Há uma verificação no construtor para seguir o padrão singleton
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Repository<T> : IRepository<T>
    {
        public static List<T> _list { get; set; }
        public static object _syncObj = new object();
        public Repository()
        {
            if(_list == null)
            {
                lock (_syncObj)
                {
                    if (_list == null)
                    {
                        _list = new List<T>();
                    }
                }
            }
        }

        public bool Add(T obj)
        {
            _list.Add(obj);
            return true;
        }

        public List<T> GetList()
        {
            return _list;
        }
    }
}
