using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Telefone: Base
    {
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public int ClienteForeignKey { get; set; }

        [ForeignKey("ClienteForeignKey")]
        public Cliente Cliente { get; set; }
    }
}
