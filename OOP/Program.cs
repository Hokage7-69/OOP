
using OOP;

Cat murka = new Cat();
Cat moska = new Cat();

murka.age = 5;
murka.name = "Murka";
murka.color = "белая";
murka.poroda = "сиамская";
murka.height = 30;

moska.age = 9;
moska.name = "Moska";
moska.color = "чёрная";
moska.poroda = "бенгальская";
moska.height = 35;

gun snaiper_riffle = new gun();

snaiper_riffle.name = "АВП";

snaiper_riffle.SetDamage(50);


snaiper_riffle.shot("голова");
snaiper_riffle.shot("тело");
snaiper_riffle.shot("стена");


