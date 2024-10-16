using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Show the user the menu 1. Create Shape (and add to list), 2. Find Perimeters, 3. Find Areas, 4. Find Volumes
            //if the user chooses no. 1 another menu to choose to create either a circle, Sphere or a cylinder must be shown to the user
            //you add the shape to a list
            //get back to the main menu 
            //if then the user chooses Find Perimeters, all perimeters of all shapes in list must be shown on screen
            
            List<Circle> list = new List<Circle>();
            
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Add a shape");
                Console.WriteLine("2. Find Perimeters");
                Console.WriteLine("3. Find areas");
                Console.WriteLine("4. Find Volumes");
                Console.WriteLine("5. Quit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1. Circle");
                        Console.WriteLine("2. Sphere");
                        Console.WriteLine("3. Cylinder");
                        int choice2 = Convert.ToInt32(Console.ReadLine());

                        switch(choice2)
                        {
                            case 1: //input details for a circle
                                Circle myCircle = new Circle();
                                Console.WriteLine("input x");
                                myCircle.X = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input y");
                                myCircle.Y = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input radius");
                                myCircle.Radius = Convert.ToDouble(Console.ReadLine());

                                list.Add(myCircle); //you can add a circle into a List<Point> because Circle is a Point

                                //user is redirected to the main menu

                                break;

                            case 2: //input details for a sphere

                                Sphere mySphere = new Sphere();
                                Console.WriteLine("input x");
                                mySphere.X = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input y");
                                mySphere.Y = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input z");
                                mySphere.Z = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("input radius");
                                mySphere.Radius = Convert.ToDouble(Console.ReadLine());

                                list.Add(mySphere); //you can add a circle into a List<Point> because Circle is a Point

                                break;

                            case 3: //input details for a cylinder

                                break;
                        }



                        break;

                    case 2: //Find the perimeters

                        //for, while, do-while, foreach
                        foreach(var shape in list)
                        {
                            Console.WriteLine($"Perimeter for {shape.GetType().Name} with radius {shape.Radius} is {shape.FindPerimeter()}");
                            Console.WriteLine();
                        }
                        
                        Console.WriteLine("Hit a key to get back to the main menu");
                        Console.ReadKey();
                        break;

                    case 3:

                        foreach (var shape in list)
                        {
                            Console.WriteLine($"Area for {shape.GetType().Name} with radius {shape.Radius} is {shape.FindArea()}");
                            Console.WriteLine();
                        }

                        Console.WriteLine("Hit a key to get back to the main menu");
                        Console.ReadKey();


                        break;

                    case 4:

                        foreach (var shape in list)
                        {
                            if (shape.GetType() == typeof(Circle))
                            {
                                //only circles get in here
                                Console.WriteLine("Volume of circle çannot be calculated");
                            }else
                            {
                                //only Spheres & cylinders will get in here
                                
                                //data type of shape will always be Circle
                                //...so we need a conversion to be able to call the FindVolume
                                //convert either to Sphere or Cylinder 
                                //why did i choose sphere?

                                Sphere s = (Sphere)shape; //typecasting //implicit conversion

                                Console.WriteLine($"Volume for {s.GetType().Name} with radius {s.Radius} is {s.FindVolume()}");
                            }
                            
                            Console.WriteLine(); //this inserts a blank line on screen
                        }

                        Console.WriteLine("Hit a key to get back to the main menu");
                        Console.ReadKey();

                        break;
                }


            }while (choice != 5);

            Console.WriteLine("Hit a key to continue");
            Console.ReadKey();

        }
    }
}
