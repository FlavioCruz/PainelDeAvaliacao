using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PaineldeAvaliador.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaineldeAvaliador.Models.Entities
{
    public class Rotulo : Model
    {
        public int Id { get; set; }
        public ApoioEnum Apoio { get; set; }
    }
}
