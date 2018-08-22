using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.Models.Entities
{
    public class Candidato : Model
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
