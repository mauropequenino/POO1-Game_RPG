using Game_RPG.Interfaces;

namespace Game_RPG.Models
{
    public class Personagem : IPersonagem
    {
        public string nome { get; set; }
        public string tipo { get; set; }
        public int nivel { get; set; } = 1;
        public int experiencia { get; set; } = 0;


        public void BuscarPersonagem(List<Personagem> personagens, string nome)
        {
            foreach (var personagem in personagens)
            {
                if (personagem.nome == nome)
                {
                    Console.WriteLine($"nome do persongem: {personagem.nome}\n" +
                        $"tipo de personagem: {personagem.tipo}\n" +
                        $"nivel do persongem: {personagem.nivel}\n" +
                        $"experiencia do personagem: {personagem.experiencia}\n" +
                        $"--------------------------------------------------------");
                }
            }
        }

        public void ExibirDadosPersonagem()
        {

            Console.WriteLine($"nome do persongem: {nome}\n" +
                $"tipo de personagem: {tipo}\n" +
                $"nivel do persongem: {nivel}\n" +
                $"experiencia do personagem: {experiencia}\n" +
                $"--------------------------------------------------------");
        }


        public void AdicionarExperiencia(int valor)
        {
            experiencia += valor;

            if (experiencia >= 1000)
            {
                experiencia = 0;
                nivel += 1;
            }
        }
    }
}