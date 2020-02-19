//Main file using integerset class
//Authors: Sidney Sanders, Lian Sandoval
//2-14-2020


using C = System.Console;
using Set;
using System;

namespace MainApp
{
    public class MainC
    {
        static void Main()
        {
            int[] a_arr = new int[] { 0, 5, 10, 32, 45 };

            IntegerSet a_set = new IntegerSet(a_arr);

            C.WriteLine("A is: " + a_set + "\n");

            int[] b_arr = new int[] { 0, 3, 10, 15, 25 };

            IntegerSet b_set = new IntegerSet(b_arr);
            C.WriteLine("B is: " + b_set + "\n");

            IntegerSet a_un_b = a_set.Union(b_set);
            C.WriteLine("Union of A and B is: " + a_un_b + "\n");

            IntegerSet a_in_b = a_set.Intersection(b_set);
            C.WriteLine("Intersection of A and B is: " + a_in_b + "\n");

            if (a_set.Equals(b_set))
            {
                C.WriteLine("Sets A and B are equal." + "\n");
            }
            else
            {
                C.WriteLine("Sets A and B are not equal." + "\n");
            }

            C.WriteLine("Copying a to b...");
            b_set = new IntegerSet(a_arr);
            if (a_set.Equals(b_set))
            {
                C.WriteLine("Sets A and B are equal." + "\n");
            }
            else
            {
                C.WriteLine("Sets A and B are not equal." + "\n");
            }

            C.WriteLine("Inserting 33 into set A...");
            a_set.InsertElement(33);
            C.WriteLine("Set a is now: " + a_set + "\n");

            C.WriteLine("Deleting 33 from set A...");
            a_set.DeleteElement(33);
            C.WriteLine("Set A is now: " + a_set + "\n");

            IntegerSet entry_set = new IntegerSet();
            entry_set.InputSet();

            C.WriteLine("\n" + "Set E is: " + entry_set + "\n");

            C.WriteLine("Emptying set e...");
            entry_set.EmptySet();
            C.WriteLine("Set E is: " + entry_set);



        }
    }
}
