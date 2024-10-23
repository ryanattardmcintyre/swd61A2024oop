using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Worksheet6
{
    //An interface doesn't allow implementation of methods; only the declaration

    //An interface its like a template which dictates/ forces any inheriting classes to follow
    //the rules; the rules being a set of methods that have to be eventually implemented
    public interface IHeal
    {
        void Heal(Character target);
    }
}
