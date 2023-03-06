using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Heroi
    {
        public int hp;
        public string nome;
        public int dano;
        public string classe;

        public Heroi(int hp, string nome, int dano, string classe)
        {
            this.hp = hp;
            this.nome = nome;
            this.dano = dano;
            this.classe = classe;
        }
        public int Bater(Monstro monstro)
        {
            return monstro.hp - dano;
        }
    }
}
