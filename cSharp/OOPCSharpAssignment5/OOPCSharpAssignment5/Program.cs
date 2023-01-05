using System;

namespace OOPCSharpAssignment5
{
    class Program
    {
        public static void PrintFirstArray(int[] Integer)
        {
           
           foreach (int e in Integer)     //foreach loop for printing first integer array
            {

                Console.Write(e + " ");
            }
            Console.WriteLine();
           
        }
        public static void Stringarr1(string[] names1)
        {
            foreach (string e in names1)        //foreach loop for printing string array
            {

                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
        public static void PrintSecArray(int[] Integer)
        {

            foreach (int e in Integer)          //foreach loop for ptinting second integer array
            {

                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
        public static void Stringarr2(string[] names2)
        {
            foreach (string e in names2)        //foreach loop for printing string array
            {

                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    
        public static void Main(string[] args)
        {
           
                int[] Integer = new int[5];
             Console.WriteLine("Enter The Elements of First Array");
             for (int i = 0; i < 5; i++)
             {

                    int element = Convert.ToInt32(Console.ReadLine());
                    Integer[i] = element;
             }

            int[] Integer1 = new int[5];
            Console.WriteLine("Enter The of Second Array");
            for (int i = 0; i < 5; i++)
            {

                int element = Convert.ToInt32(Console.ReadLine());
                Integer1[i] = element;
            }

            string[] names1 = new string[3];
            Console.WriteLine("Enter The Elements of First string Array");
            for (int i = 0; i < 3; i++)
            {

                string element = Convert.ToString(Console.ReadLine());
                names1[i] = element;
            }

            string[] names2 = new string[3];
            Console.WriteLine("Enter The Elements of Second string Array");
            for (int i = 0; i < 3; i++)
            {

                string element = Convert.ToString(Console.ReadLine());
                names2[i] = element;
            }

            Console.WriteLine("The First Array is");            //To Print First Array
            PrintFirstArray(Integer);
            Console.WriteLine("The Second Array is");
            PrintSecArray(Integer1);                            //To print 2nd array
            Console.WriteLine();
            Console.WriteLine("The First Array is");
            Stringarr1(names1);
            Console.WriteLine("The First Array is");
            Stringarr2(names2);

            
            //Copying one array to another
            System.Array.Copy(Integer, Integer1, 5);
            Console.WriteLine("Arrays After Copying : ");
            Console.WriteLine("First Array: ");
            PrintFirstArray(Integer);
            Console.WriteLine("second Array: ");
            PrintSecArray(Integer1);
            Console.WriteLine();

            System.Array.Copy(names1, names2, 2);
            Console.WriteLine("Arrays After Copying : ");
            Console.WriteLine("First Array: ");
            Stringarr1(names1);
            Console.WriteLine("second Array: ");
            Stringarr2(names2);
            Console.WriteLine();

             //Reversing an array
             System.Array.Reverse(Integer);
             Console.WriteLine("Reversed Array is: ");
             PrintFirstArray(Integer);
             Console.WriteLine();
            System.Array.Reverse(names1);
            Console.WriteLine("Reversed String Array is: ");
            Stringarr1(names1);
            Console.WriteLine();

            //Sorting an array
            System.Array.Sort(Integer);
             Console.WriteLine("sorted Array is: ");
             PrintFirstArray(Integer);
             Console.WriteLine();
            System.Array.Sort(names1);
            Console.WriteLine("sorted string Array is: ");
            Stringarr1(names1);
            Console.WriteLine();

            //Clearing an array
            System.Array.Clear(Integer, 3, 2);
             Console.WriteLine("cleared Array is: ");
             Console.WriteLine();
            System.Array.Clear(names1, 1, 1);
            Console.WriteLine("cleared Array is: ");
            Console.WriteLine();


        }
    }
}


