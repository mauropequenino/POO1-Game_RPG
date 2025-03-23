using Game_RPG.Interfaces;

namespace Game_RPG.Models
{
    public class Credito : ICredito
    {
        public decimal saldoCredito { get; set; }
        public DateTime dataRealizacao { get; set; }


        public void AdicionarCredito(decimal valor)
        {
            saldoCredito += valor;
            dataRealizacao = DateTime.UtcNow;
        }

        public void VisualizarCreditos()
        {
            Console.WriteLine($"saldo do Credito: {saldoCredito}\n" +
                $"data da realizacao do credito: {dataRealizacao}\n" +
                $"--------------------------------------------------------");
        }
    }
}