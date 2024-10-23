using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Worksheet6
{
    //The Priest has initial health of 125, initial mana of 200 and damage of 100.

    //a class can inherit only ONE class/abstract class but then it can inherit as many interfaces
    //as you want
    public class Priest: Character, IHeal 
    {

        private int initialHealth;
        public Priest():base(200, 125, 100)
        {
            initialHealth = Health;
        }

        //When the healer Heals, he reduces his mana by 100 and heals the target character by increasing his health with 150 health points.
        public void Heal(Character target)
        {
            Mana -= 100;
            target.Health += 150;
        }

        //When the Priest attacks, he deals damage to the opponent,
        //but also heals himself (life steal) –
        //e.g. if he dealt 100 damage to the opponent, he restores 10% of that, or 10 health points.

        public override void Attack(Character target)
        {
            target.Health -= Damage;
            if ((Health + Convert.ToInt32(Damage * .1)) > initialHealth)
            {
                Health = initialHealth;
            }
            else
            {
                Health += Convert.ToInt32(Damage * .1); //if the Priest has full health, we r going to go over the initial value
            }
        }

    }
}
