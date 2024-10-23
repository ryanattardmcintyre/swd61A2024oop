using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Worksheet6
{
    //The Mage has initial health of 100, initial mana of 300 and damage of 75.
  
    public class Mage: Character
    {
        public Mage(): base(300, 100, 75)
        { }

        //But when the Mage attacks, he uses 100 mana and deals twice his default damage.

        public override void Attack(Character target)
        {
            Mana -= 100;
            target.Health -= (Damage * 2);
        }
    }
}
