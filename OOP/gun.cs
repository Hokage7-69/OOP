using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class gun
    {
        private double damage;
        public string name;

        public double GetDamage()
        {
            return damage;

        }

        public void SetDamage(double NewDamage)
        {
            damage = NewDamage;
        }

        public void shot(string part)
        {
            Console.WriteLine($"Из оружия {name} было нанесено {BodyPart(damage, part)} урона");
        }

        private double BodyPart(double damage, string part)
        {
           if (part == "голова")
            {
                return damage * 2;
            }       
           else if(part == "тело")
           {
                return damage;
           }
           else if (part == "нога")
           {
                return damage / 2;
           }
           else if (part == "рука")
           {
                return damage / 1.5;
           }
           else
           {
                return damage = 0;
           }
        }

    }
}
