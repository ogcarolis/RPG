// See https://aka.ms/new-console-template for more information
using RPG;

Console.WriteLine("Sistema de RPG");

Heroi heroi1 = new Heroi(100, "Lartie", 40, "Mago");
Monstro monstro1 = new Monstro(200, true, "Lobisomem", "Força");

for(int i = 0; i < monstro1.hp; i++)
{
    Console.WriteLine("Vida do monstro: " + monstro1.hp);
    monstro1.hp = heroi1.Bater(monstro1);
}

Console.WriteLine("Vida do monstro: " + monstro1.hp);

monstro1.VivoOuMorto(monstro1.hp, monstro1);