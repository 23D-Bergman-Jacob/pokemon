﻿// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
float dinhp;
string frågor;
string dinpokemon;
string pokemonv2;
float basehp;
float baseatk;
float basedef;
float basespatk;
float basespeed;
float basespdef;
float basehp2;
float baseatk2;
float basedef2;
float basespatk2;
float basespeed2;
float basespdef2;
float atkgrowth;
float defgrowth;
float speedgrowth;
float hpgrowth;
float spatkgrowth;
float spdefgrowth;
float atk;
float atkval;
float def;
float speed;
float hp;
float spatk;
float spdef;
float atk2;
float def2;
float speed2;
float hp2;
float spatk2;
int pokemonlvl = 1;
int pokemonlvlv2;
int exp = 1;
int levelexp;
int pokebollar = 10;
int potion = 5;
int superpotion = 1;
int hyperpotion = 0;
int fullpotion = 0;
int revive = 0;
int fullrevive=0;
int dinexp = 0;
int fire = 0;
int bug = 0;
int water = 0;
int fairy = 0;
int flying = 0;
int rock = 0;
int ghonst = 0;
int fighter = 0;
int grass = 0;
int poison = 0;
int psychic = 0;
int normal = 0;
int firea = 0;
int buga = 0;
int watera = 0;
int fairya = 0;
int flyinga = 0;
int rocka = 0;
int ghonsta = 0;
int fightera = 0;
int grassa = 0;
int poisona = 0;
int psychica = 0;
int normala = 0;
int firea2 = 0;
int buga2 = 0;
int watera2 = 0;
int fairya2 = 0;
int flyinga2 = 0;
int rocka2 = 0;
int ghonsta2 = 0;
int fightera2 = 0;
int grassa2 = 0;
int poisona2 = 0;
int psychica2 = 0;
int normala2 = 0;
int fire2 = 0;
int bug2 = 0;
int water2 = 0;
int fairy2 = 0;
int flying2 = 0;
int rock2 = 0;
int ghonst2 = 0;
int fighter2 = 0;
int grass2 = 0;
int poison2 = 0;
int psychic2 = 0;
int normal2 = 0;
while (1 == 1)
{
    System.Console.WriteLine("vilken pokemon vill du ha?");
    System.Console.WriteLine("Charmander type 1");
    System.Console.WriteLine("Bulbasaur type 2");
    System.Console.WriteLine("Squirtle type 3");
    frågor = Console.ReadLine();
    if (frågor == "1")
    {
        dinpokemon = "Charmander";
        fire=1;
        break;
    }
    if (frågor == "2")
    {
        dinpokemon = "Bulbasaur";
        grass = 1;
        break;
    }
    if (frågor == "3")
    {
        dinpokemon = "Squirtle";
        water=1;
        break;
    }
    Console.Clear();
}

Console.ReadLine();
void Bulbasaurp(){
pokemonv2 = "Bulbasaur";
fire2 = 0;
bug2 = 0;
water2 = 0;
fairy2 = 0;
flying2 = 0;
rock2 = 0;
ghonst2 = 0;
fighter2 = 0;
grass2 = 1;
poison2 = 1;
psychic2 = 0;
normal2 = 0;
atkgrowth = 1.8F;
hpgrowth = 6;
speedgrowth = 2.2F;
spatkgrowth = 2.4F;
spdefgrowth = 2.2F;
defgrowth = 1;
baseatk2 = 6;
basedef2 = 30;
basehp2 = 12;
basespdef2 = 4;
basespatk2 = 8;
basespeed2 = 10;
if (pokemonlvlv2 <=16){
pokemonv2 = "Ivysaur";
baseatk2 = 10  ;
basedef2 = 34;
basehp2 = 20;
basespdef2 = 14;
basespatk2 = 13;
basespeed2 = 18;
}
if (pokemonlvlv2 <=24){
pokemonv2 = "Ivysaur";
baseatk2 = 15  ;
basedef2 = 40;
basehp2 = 30;
basespdef2 = 20;
basespatk2 = 20;
basespeed2 = 25;
}
}
void Charmander(){
pokemonv2 = "Charmander";
fire2 = 1;
bug2 = 0;
water2 = 0;
fairy2 = 0;
flying2 = 0;
rock2 = 0;
ghonst2 = 0;
fighter2 = 0;
grass2 = 0;
poison2 = 0;
psychic2 = 0;
normal2 = 0;
atkgrowth = 1.8F;
hpgrowth = 6;
speedgrowth = 2.2F;
spatkgrowth = 2.4F;
spdefgrowth = 2.2F;
defgrowth = 1;
baseatk2 = 6;
basedef2 = 30;
basehp2 = 12;
basespdef2 = 4;
basespatk2 = 8;
basespeed2 = 10;
if (pokemonlvlv2 <=16){
pokemonv2 = "Charmeleon";
baseatk2 = 10  ;
basedef2 = 34;
basehp2 = 20;
basespdef2 = 14;
basespatk2 = 13;
basespeed2 = 18;
}
if (pokemonlvlv2 <=24){
pokemonv2 = "Charizard";
baseatk2 = 15  ;
basedef2 = 40;
basehp2 = 30;
basespdef2 = 20;
basespatk2 = 20;
basespeed2 = 25;
flying2 = 1;
}
}
void Squirtle(){
pokemonv2 = "Caterpie";
fire2 = 0;
bug2 = 1;
water2 = 0;
fairy2 = 0;
flying2 = 0;
rock2 = 0;
ghonst2 = 0;
fighter2 = 0;
grass2 = 0;
poison2 = 0;
psychic2 = 0;
normal2 = 0;
atkgrowth = 1.8F;
hpgrowth = 6;
speedgrowth = 2.2F;
spatkgrowth = 2.4F;
spdefgrowth = 2.2F;
defgrowth = 1;
baseatk2 = 6;
basedef2 = 30;
basehp2 = 10;
basespdef2 = 4;
basespatk2 = 8;
basespeed2 = 10;
if (pokemonlvlv2 <=16){
pokemonv2 = "metapod";
baseatk2 = 10  ;
basedef2 = 34;
basehp2 = 20;
basespdef2 = 14;
basespatk2 = 13;
basespeed2 = 18;
}
if (pokemonlvlv2 <=24){
pokemonv2 = "Blastois";
baseatk2 = 15  ;
basedef2 = 40;
basehp2 = 30;
basespdef2 = 20;
basespatk2 = 20;
basespeed2 = 25;
flying2 = 1;
}
}
void Squirtle(){
pokemonv2 = "Squirtle";
fire2 = 0;
bug2 = 0;
water2 = 1;
fairy2 = 0;
flying2 = 0;
rock2 = 0;
ghonst2 = 0;
fighter2 = 0;
grass2 = 0;
poison2 = 0;
psychic2 = 0;
normal2 = 0;
atkgrowth = 1.8F;
hpgrowth = 6;
speedgrowth = 2.2F;
spatkgrowth = 2.4F;
spdefgrowth = 2.2F;
defgrowth = 1;
baseatk2 = 6;
basedef2 = 30;
basehp2 = 12;
basespdef2 = 4;
basespatk2 = 8;
basespeed2 = 10;
if (pokemonlvlv2 <=16){
pokemonv2 = "Wartortle";
baseatk2 = 10  ;
basedef2 = 34;
basehp2 = 20;
basespdef2 = 14;
basespatk2 = 13;
basespeed2 = 18;
}
if (pokemonlvlv2 <=24){
pokemonv2 = "Blastois";
baseatk2 = 15  ;
basedef2 = 40;
basehp2 = 30;
basespdef2 = 20;
basespatk2 = 20;
basespeed2 = 25;

}
}
