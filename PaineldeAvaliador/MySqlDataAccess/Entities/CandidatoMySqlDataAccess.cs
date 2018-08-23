using PaineldeAvaliador.DataAccess.Entities;
using PaineldeAvaliador.DataAccess.Interfaces;
using PaineldeAvaliador.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.MySqlDataAccess.Entities
{
    public class CandidatoMySqlDataAccess : DataAccess<Candidato>, ICandidatoDataAccess
    {

        private List<Candidato> list = null;

        private void InitializeList()
        {
            if (list == null)
            {
                list = new List<Candidato>();
                list.Add(new Candidato { Id = 1, Nome = "AA" });
                list.Add(new Candidato { Id = 2, Nome = "AB" });
                list.Add(new Candidato { Id = 3, Nome = "AC" });
                list.Add(new Candidato { Id = 4, Nome = "AD" });
                list.Add(new Candidato { Id = 5, Nome = "AE" });
                list.Add(new Candidato { Id = 6, Nome = "AF" });
            }
        }


        public override int Delete(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public override List<Candidato> GetAll()
        {
            InitializeList();
            return list;
        }

        public override List<Candidato> GetByFilter(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public override Candidato GetById(params object[] parameters)
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
