using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaineldeAvaliador.DataAccess.Interfaces;

namespace PaineldeAvaliador.DataAccess.Entities
{
    public abstract class DataAccess<T> : IDataAccess<T>
    {
        public abstract int Delete(params object[] parameters);

        public abstract List<T> GetAll();

        public abstract List<T> GetByFilter(params object[] parameters);

        public abstract T GetById(params object[] parameters);

        public abstract void Insert(params object[] parameters);

        public abstract void Update(params object[] parameters);

        private string FormatQuery(string query, params object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                query.Replace("@arg" + i, parameters[i].ToString());
            }
            return query;
        }
    }
}
