namespace Game_RPG
{
    public class Personagem
    {
        public string nome { get; set; }
        public string tipo { get; set; }
        public int nivel { get; set; }
        public int experiencia { get; set; }

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