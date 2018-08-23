using PaineldeAvaliador.MySqlDataAccess.Entities;
using PaineldeAvaliador.DataAccess.Interfaces;
using PaineldeAvaliador.Models.Entities;
using PaineldeAvaliador.Models.Entities.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaineldeAvaliador.SqlServerDataAccess.Entities;

namespace PaineldeAvaliador.Services.Entities
{
    public class CandidatosServices
    {
        //private ICandidatoDataAccess servicosDeCandidatos = new CandidatoMySqlDataAccess();
        private ICandidatoDataAccess servicosDeCandidatos = new CandidatoSqlServerDataAccess();

        public List<Candidato> GetAll()
        {
            return servicosDeCandidatos.GetAll();
        }

        public List<Candidato> GetByFilter(CandidatoFilter filter)
        {
            return servicosDeCandidatos.GetByFilter(filter.Nome);
        }

        public Candidato GetById(int id)
        {
            return servicosDeCandidatos.GetById(id);
        }

        public void Insert(Candidato entidade)
        {
            throw new NotImplementedException(entidade.Nome);
        }

        public void Update(Candidato entidade)
        {
            servicosDeCandidatos.Update(entidade.Id, entidade.Nome);
        }

        public void Delete(Candidato entidade)
        {
            servicosDeCandidatos.Delete(entidade.Id);
        }
    }
}
