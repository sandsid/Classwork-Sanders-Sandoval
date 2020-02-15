//Integer set file 


using System;
using System.Linq;
namespace Set
{
   public class IntegerSet
    {
        bool[] arr;

        //Create an empty set
        public IntegerSet()
        {
            arr = new bool[51];
        }

        //elements to be put into the set are those that are found in the array values
        public IntegerSet(int[] arr_int)
        {

            arr = new bool[51];

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

        //accepts no arguments and removes all elements from the set
        public void EmptySet()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = false;
            }
        }

        //accepts an integer array as an argument and adds each 
        //  integer element to the set
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

        //adds one integer element to the set
        public void InsertElement(int n)
        {
                if(n >= 0 && n < 51)
                {
                    arr[n] = true;
                }
                else 
                    System.Console.WriteLine("Number not 0-50");
        }

        //removes one integer element from the set
        public void DeleteElement(int n)
        {
                if(n >= 0 && n < 51)
                {
                    arr[n] = false;
                }
                else 
                    System.Console.WriteLine("Number not 0-50");
        }
        
        //Read integers from the console, one at a time and add them 
        //  to the set. Stop the input when the enter key is pressed
        public void InputSet()
        {
            int i = 0;
            string line = "";
            bool keyEnter = false;
         
            do
            {
                System.Console.Write("Enter an Element (Enter to End): ");
                line = System.Console.ReadLine();
                
                if (string.IsNullOrEmpty(line))
                {
                    keyEnter=true;
                }
                else
                {
                    i = int.Parse(line);
                    if(i >= 0 && i < 51)
                    {
                        arr[i] = true;
                    }
                    else 
                    {
                        System.Console.WriteLine("Number not 0-50"); 
                    }
                }
            }while(keyEnter == false);
        }
        
        // Calculate the union of the set with another set
        public IntegerSet Union(IntegerSet b)
        {
            int[] indexes = new int[51];
            int j = 0;
            for(int i = 0; i < 51; i++)
            {
                if((this.arr[i] == true) ||(b.arr[i] == true))
                {
                    indexes[j] = i;
                    j++;
                }

            }
            IntegerSet c = new IntegerSet(indexes);
            return c;
        }

        //Calculate the intersection of the set with another set.
        public IntegerSet Intersection(IntegerSet b)
        {
            int[] indexes = new int[51];
            int j = 0;

            for(int i = 0; i < 51; i++)
            {
                if((this.arr[i] == true) && (b.arr[i] == true))
                {
                    indexes[j] = i;
                    j++;

                } 
            }

            IntegerSet c = new IntegerSet(indexes);
            return c;
        }
        
        //determines if the set is equal to another set
        public override bool Equals(Object obj)
        {
            if((obj == null) || (!(obj is IntegerSet)))
            {
                return false;
            }
            IntegerSet other = (IntegerSet)obj;
            bool same = true;
            int i = 0;

            do
            {
                if(this.arr[i] != other.arr[i])
                {
                    same = false;
                }
                i++;
            } while (i < 51 && same == true);

            return same;

        }
        
        //must be overridden whenever Equals is overridden
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        
        //return a string representing the set
        public override string ToString()
        {
            int[] indexes = new int[51];
            int j = 0;
            for(int i = 0; i < 51; i++)
            {
                if(this.arr[i] == true)
                {
                    indexes[j] = i;
                    j++;
                }
            }

            int[] new_index = new int[j];

            for(int l = 0; l < j; l++)
            {
                new_index[l] = indexes[l];
            }

            string ids = String.Join(", ", new_index.Select(q=>q.ToString()).ToArray());

            if(j == 0)
            {
                return "{ <empty> }";
            }
            else
                return $"{{ {ids} }}";
        }  
    } 
}
