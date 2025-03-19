using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RPG
{
    class Conta
    {
        public string email { get; set; }
        public DateTime dataCriacao { get; set; }
        public decimal saldoActual { get; set; }
        //  public List<string> 
        public List<Credito> Creditos = [];
        public List<Personagem> Personagens = [];

        public Personagem CriarPersonagem(string nome, string tipo)
        {
            Personagem personagem = new Personagem();

            Personagens.Add(new Personagem
            {
                nome = nome,
                tipo = tipo,
                nivel = 1
            });
            return personagem;
        }


        public void ListarPersonagens()
        {
            foreach (var personagem in Personagens)
                Console.WriteLine($"nome do persongem: {personagem.nome}\n" +
                    $"tipo de personagem: {personagem.tipo}\n" +
                    $"nivel do persongem: {personagem.nivel}\n" +
                    $"experiencia do personagem: {personagem.experiencia}\n" +
                    $"--------------------------------------------------------");
        }

        public void AdicionarCredito(decimal valor)
        {
            Creditos.Add(new Credito
            {
                saldoCredito = valor,
                dataRealizacao = DateTime.Now
            });
            saldoActual += valor;
        }
  
        public void VisualizarCreditos()
        {
            foreach (var credito in Creditos)
                Console.WriteLine($"saldo do Credito: {credito.saldoCredito}\n" +
                    $"data da realizacao do credito: {credito.saldoCredito}\n" +
                    $"--------------------------------------------------------");
        }
    }
}
