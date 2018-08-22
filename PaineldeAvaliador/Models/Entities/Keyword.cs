using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.Models.Entities
{
    public class Keyword : Model
    {
        public int Id { get; set; }
        public string Palavra { get; set; }
    }
}
