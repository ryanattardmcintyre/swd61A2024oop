using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Worksheet6
{
    //an abstract class unlike an interface allows you to have unimplemented methods and even
    //implemented methods side-by-side

    //unlike the interface to allow for not implemented methods, you have to mark them as
    //abstract
    public abstract class Character : IAttack
    {
        //declaring a protected constructor is callable only from the inherited classes
        //meaning also that i can never instaniate an object of type Character
        protected Character(int mana, int health, int damage) {
            Mana = mana;
            Health = health;
            Damage = damage;
        }

        public int Mana { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public abstract void Attack(Character target);
        
    }
}
