using PaineldeAvaliador.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.DataAccess.Entities.ApiDataAccess
{
    public class KeywordsApiAccess : DataAccess<Keyword>
    {

        private List<Keyword> list = null;

        private void InitializeList()
        {
            if(list == null)
            {
                list = new List<Keyword>();
                list.Add(new Keyword { Id = 1, Palavra = "A" });
                list.Add(new Keyword { Id = 2, Palavra = "B" });
                list.Add(new Keyword { Id = 3, Palavra = "C" });
                list.Add(new Keyword { Id = 4, Palavra = "D" });
                list.Add(new Keyword { Id = 5, Palavra = "E" });
                list.Add(new Keyword { Id = 6, Palavra = "F" });
            }
        }

        public override int Delete(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public override List<Keyword> GetAll()
        {
            InitializeList();
            return list;
        }

        public override List<Keyword> GetByFilter(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public override Keyword GetById(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public override void Insert(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public override void Update(params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
