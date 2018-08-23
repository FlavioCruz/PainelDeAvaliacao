using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.DataAccess.Interfaces
{
    interface IDataAccess<T>
    {
        List<T> GetAll();
        T GetById(params object[] parameters);
        List<T> GetByFilter(params object[] parameters);
        void Insert(params object[] parameters);
        void Update(params object[] parameters);
        int Delete(params object[] parameters);
    }
}
