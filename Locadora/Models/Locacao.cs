using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Locacao:Base
    {

       public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Itens { get; set; }

        public int ClienteForeignKey { get; set; }

        [ForeignKey("ClienteForeignKey")]
        public Cliente Cliente { get; set; }

      
    }
}
