using System;

namespace proconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 64, 25, 12, 22, 11 };

            //sort.selection(A);
            //sort.insertion(A);
            sort.bucket(A);
            printArray(A);
            
            Console.ReadLine();
        }

        public static void printArray(int[] A)
        {
            foreach (var a in A)
            {
                Console.Write("{0} ",a);
            }
            Console.WriteLine();
        }


             
    }

}
