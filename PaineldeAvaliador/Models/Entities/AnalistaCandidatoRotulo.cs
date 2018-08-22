using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.Models.Entities
{
    public class AnalistaCandidatoRotulo : Model
    {

        public int IdAnalista { get; set; }
        public int IdRotulo { get; set; }
        public int IdCandidato { get; set; }

        public UsuarioAnalista Analista { get; set; }
        public Rotulo Rotulo { get; set; }
        public Candidato Candidato { get; set; }
    }
}
