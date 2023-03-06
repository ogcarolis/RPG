using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Monstro
    {
        public int hp;
        public bool vivo;
        public string nome;
        public string tipo;

        public Monstro(int hp, bool vivo, string nome, string tipo)
        {
            this.hp = hp;
            this.vivo = vivo;
            this.nome = nome;
            this.tipo = tipo;
        }

        public void VivoOuMorto(int hp, Monstro monstro)
        {
            if (hp <= 0)
            {
                Console.WriteLine("O " + monstro.nome + " morreu");
                monstro.vivo = false;
            }
        }
    }
}
