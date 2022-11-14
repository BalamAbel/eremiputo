using System;


namespace TAREA1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            
           
        }
        
        public int algoRecursivo (int N)
        {
            Console.WriteLine("dame un numero ");
            int dato = int.Parse(Console.ReadLine());

            if (N >0)
            {
                return algoRecursivo(N-1);
            }
            else 
            {
                return 0;
                Console.w
            }

        }
    }
}