using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Models
{
    public class Titular
    {
        [Key]
        public int cpf { get; set; }

        public string nome { get; set; }
        
        public int rg { get; set; }

        public string endereco { get; set; }
    }
}