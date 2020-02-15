using System;
using System.Linq;
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
            arr = new bool[51];

            foreach(int i in arr_int)
            {
                if(i > -1 && i < 51)
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
                        System.Console.WriteLine("Number not 0-50");
                }
            }while(keyEnter == false);
        }
        
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
        
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        
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
