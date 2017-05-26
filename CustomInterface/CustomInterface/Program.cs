using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");

            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            // catch a possible InvalidCaseException
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            // can we treat hex2 as IPointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (itfPt2 != null)
            {
                Console.WriteLine("Points: {0}", itfPt2.Points);
            }
            else
            {
                Console.Write("Oops, no pointy");
            }

            // make an array of shapes
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();
                if (myShapes[i] is IPointy)
                {
                    Console.WriteLine("-> Points:{0}", ((IPointy)myShapes[i]).Points);
                }
                else
                {
                    Console.WriteLine("-> {0}'s not pointy!", myShapes[i].PetName);
                }
                if (myShapes[i] is IDraw3D)
                {
                    DrawIn3D((IDraw3D)myShapes[i]);
                }
            }

            // get first pointy item
            // to be safe you'd want to check firstPointyItem for null before processing
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);

            Console.ReadLine();
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                {
                    return s as IPointy;
                }
            }
            return null;
        }
    }
}
