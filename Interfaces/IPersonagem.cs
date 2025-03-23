using Game_RPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RPG.Interfaces
{
    public interface IPersonagem
    {
        public void BuscarPersonagem(List<Personagem> personagens, string nome);
        public void ExibirDadosPersonagem();
        public void AdicionarExperiencia(int valor);
    }
}
