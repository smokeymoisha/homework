using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes_Library;

namespace Shapes_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> trianglesList = new List<Triangle>();
            string input;

            do
            {
                Console.WriteLine("====================== MENU ======================");
                Console.WriteLine("Enter 'add' to add a new triangle to the list.");
                Console.WriteLine("Enter 'view' to view the current list of triangles.");
                Console.WriteLine("Enter 'select' to select and view one triangle from the list.");
                Console.WriteLine("Enter 'end' to finish working with the app.");

                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "add":
                        Console.Write("Enter side A length: ");
                        int sideA = int.Parse(Console.ReadLine());

                        Console.Write("Enter side B length: ");
                        int sideB = int.Parse(Console.ReadLine());

                        Console.Write("Enter side C length: ");
                        int sideC = int.Parse(Console.ReadLine());

                        Triangle triangle = new Triangle(sideA, sideB, sideC);

                        trianglesList.Add(triangle);

                        Console.WriteLine("The triangle was added to the list.");
                        Console.WriteLine();

                        break;
                    case "view":
                        foreach (Triangle shape in trianglesList)
                        {
                            int i = trianglesList.IndexOf(shape);
                            Console.WriteLine($"{i + 1}. {shape.GetInfo()}");
                        }

                        Console.WriteLine();

                        break;
                    case "select":
                        Console.Write("Enter the index of the triangle: ");
                        int index = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{index}. {trianglesList[index - 1].GetInfo()}");
                        Console.WriteLine();

                        break;
                    case "end":
                        return;
                    default:
                        Console.WriteLine("Invaild input!");
                        Console.WriteLine();

                        break;
                }
            } while (input.Equals("end") == false);        
        }
    }
}
