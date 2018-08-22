using PaineldeAvaliador.DataAccess.Entities.ApiDataAccess;
using PaineldeAvaliador.Models.Entities;
using PaineldeAvaliador.Models.Entities.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.Services.Entities
{
    public class KeywordServices
    {
        private KeywordsApiAccess servicosDeKeywords = new KeywordsApiAccess();

        public List<Keyword> GetAll()
        {
            return servicosDeKeywords.GetAll();
        }

        public List<Keyword> GetByFilter(KeywordFilter filter)
        {
            return servicosDeKeywords.GetByFilter(filter.Descricao);
        }

        public Keyword GetById(int id)
        {
            return servicosDeKeywords.GetById(id);
        }

        public void Insert(Keyword entidade)
        {
            throw new NotImplementedException(entidade.Palavra);
        }

        public void Update(Keyword entidade)
        {
            servicosDeKeywords.Update(entidade.Id, entidade.Palavra);
        }

        public void Delete(Keyword entidade)
        {
            servicosDeKeywords.Delete(entidade.Id);
        }
    }
}
