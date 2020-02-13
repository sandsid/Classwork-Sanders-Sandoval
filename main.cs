using C = System.Console;
using Set;
using System;

namespace MainApp
{
    public class MainC
    {
        static void Main()
        {
            int[] a_arr = new int[] { 5 ,9, 11, 21, 29};

            IntegerSet a_set = new IntegerSet(a_arr);

            C.WriteLine(a_set);

            int[] b_arr = new int[] {7, 2, 3, 4};

            IntegerSet b_set = new IntegerSet(b_arr);
            C.WriteLine(b_set);

            IntegerSet a_un_b = a_set.Union(b_set);
            C.WriteLine(a_un_b);

            IntegerSet a_in_b = a_set.Intersection(b_set);
            C.WriteLine(a_in_b);

            a_set.InsertElement(33);
            C.WriteLine(a_set);

            a_set.DeleteElement(33);
            C.WriteLine(a_set);

            IntegerSet entry_set = new IntegerSet();
            entry_set.InputSet();

            C.WriteLine(entry_set);

            a_set.EmptySet();
            C.WriteLine(a_set);



        }
    }
}
