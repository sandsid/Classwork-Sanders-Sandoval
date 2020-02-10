namespace Set
{
   public class IntegerSet
    {
        bool[] arr;

        IntegerSet()
        {
            arr = new bool[51];
        }
        IntegerSet(int[] arr_int)
        {
            
            foreach(int i in arr_int)
            {
                if(i >= 0 && i < 51)
                {
                    arr[i] = true;
                }
                else 
                    Syste.Console.WriteLine("Number not 0-50");
            }
        }
        void EmptySet()
        {
            Arrays.filed(arr, false);
        }
        void InsertElements(int[] arr_int)
        {
            foreach(int i in arr_int)
            {
                if(i >= 0 && i < 51)
                {
                    arr[i] = true;
                }
                else 
                    Syste.Console.WriteLine("Number not 0-50");
            }
        }
        void InsertElement(int n)
        {
                if(n >= 0 && n < 51)
                {
                    arr[n] = true;
                }
                else 
                    Syste.Console.WriteLine("Number not 0-50");
        }
        void DeleteElement(int n)
        {
                if(n >= 0 && n < 51)
                {
                    arr[n] = false;
                }
                else 
                    Syste.Console.WriteLine("Number not 0-50");
        }
        void InputSet()
        {
            int i = 0;
            while(System.Console.ReadLine() != \n)
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
        bool Equals()
        {

        }
        GetHashCode()
        {

        }
        string ToString()
        {

        }
        
    } 
}
