using System;

namespace Set
{
   public class IntegerSet
    {
        bool[] arr;

        public IntegerSet()
        {
            arr = new bool[51];
        }
        public IntegerSet(int[] arr_int)
        {
            
            foreach(int i in arr_int)
            {
                if(i >= 0 && i < 51)
                {
                    arr[i] = true;
                }
                else 
                    System.Console.WriteLine("Number not 0-50");
            }
        }
        public void EmptySet()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = false;
            }
        }
        public void InsertElements(int[] arr_int)
        {
            foreach(int i in arr_int)
            {
                if(i >= 0 && i < 51)
                {
                    arr[i] = true;
                }
                else 
                    System.Console.WriteLine("Number not 0-50");
            }
        }
        public void InsertElement(int n)
        {
                if(n >= 0 && n < 51)
                {
                    arr[n] = true;
                }
                else 
                    System.Console.WriteLine("Number not 0-50");
        }
        public void DeleteElement(int n)
        {
                if(n >= 0 && n < 51)
                {
                    arr[n] = false;
                }
                else 
                    System.Console.WriteLine("Number not 0-50");
        }
        /*
        public void InputSet()
        {
            int i = 0;
            while(System.Console.ReadLine() != '\n')
            {
                System.Console.WriteLine("Enter an Element (Enter to End): ");
                arr[i] = int.Parse(System.Console.ReadLine());
                i = i + 1;
            }  

    
        }
        
        IntegerSet Union(IntegerSet b)
        {

        }
        void Intersection(IntegerSet b)
        {

        }
        public bool Equals()
        {

        }
        GetHashCode()
        {

        }
        string ToString()
        {

        }
        */
        
    } 
}
