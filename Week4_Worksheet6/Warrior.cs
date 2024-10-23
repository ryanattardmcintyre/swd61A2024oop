using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Worksheet6
{

    //The Warrior has initial health of 300, initial mana of 0 and damage of 120.
    
    public class Warrior: Character
    {
        public Warrior():base(0, 300, 120) { }

        //When the Warrior attacks, he deals damage to the opponent.
        public override void Attack(Character target)
        {
            target.Health = target.Health-Damage;
        }


    }
}
