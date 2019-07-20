using Domain;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Base
{
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

        public List<T> GetInstance()
        {
            return _list;
        }

        public void Add(T obj)
        {
            _list.Add(obj);
        }

        public List<T> GetList()
        {
            return _list;
        }
    }
}
