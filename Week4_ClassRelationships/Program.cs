using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships
{
    /*
     * Class Relationships:
     * 
     * 1. Composition
     *    note: if Class A is linked to Class B (by means of composition) that means that Class A instance cannot exist without first
     *          creating an instance of Class B
     *    note: This is the most restrictive type of relationship      
     *    ex:   Auto Dealer System, you cannot have a Vehicle instance without having a instance of the Engine
     *    ex:   Interior Design System, a House instance must have at least 1 Room instance
     *    
     *    
     *    
     * 2. Aggregation
     *    note: Class A is linked to Class B (by means of Aggregation) which means that an instance of Class B is used by Class A
     *    ex: in an e-commerce website, ShoppingCart can be added a number of Items
     * 
     * 
     * 3. Association
     *    note: Class A is associated with Class B, when one of Class A methods uses an instance of Class B.
     *    note: this is the least restrictive type of relationship
     *    ex: FileHandler class which services Files, e.g. opening, saving, some other processing....
     * 
     * 
     * 
     * 4. Inheritance 
     *    note: a class inherits from another class, it means it inherits the public members. 
     *    ex: a Warrior is a Character (in a game) because Warrior inherits from Character
     *
     *
     *
     *
     *  Summary:
     *  Association - we don't store the instance of Class B in Class A; we only use it (weak)
     *  Aggregation - we store the instance of Class B in Class A (strong)
     *  Composition - we store the instance of Class B in Class A by passing it through the constructor (stronger)
     *
     *
     *
     */ 



    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
