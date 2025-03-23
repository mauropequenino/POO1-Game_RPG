using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RPG.Models
{
    class Conta : Credito
    {
        public string email { get; set; }
        public DateTime dataCriacao { get; set; }
        public decimal saldoActual { get; set; }
        public Personagem Personagem { get; set; }


        public Conta(string email, decimal? saldoActual = 0)
        {
            this.email = email;
            this.saldoActual = (decimal)saldoActual;
            this.Personagem = new Personagem();
            this.dataCriacao = DateTime.UtcNow;
        }
    }
}
