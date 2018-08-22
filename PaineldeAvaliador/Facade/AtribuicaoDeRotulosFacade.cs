using PaineldeAvaliador.Models.Entities;
using PaineldeAvaliador.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.Facade
{
    public class AtribuicaoDeRotulosFacade
    {

        CandidatosServices servicosDeCandidatos = new CandidatosServices();
        KeywordServices servicosDeKeywords = new KeywordServices();

        public List<Candidato> GetAllCandidatos()
        {
            return servicosDeCandidatos.GetAll();
        }

        public List<Keyword> GetAllKeywords()
        {
            return servicosDeKeywords.GetAll();
        }
    }
}
