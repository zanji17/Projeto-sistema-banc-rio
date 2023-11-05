using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Models
{
    public class Contas
    {
        [Key]
        public int numeroConta { get; set; }

        public int agencia { get; set; }

        public double saldo { get; set; }
        
        public string nomeConta { get; set; }

        public Titular titular { get; set; }

        public string senha { get; set; }

        public string? email { get; set; }
    }
}