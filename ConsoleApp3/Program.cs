using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Störst (7,12);

        }
        static void Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                Console.WriteLine($"talet {tal1} är större än {tal2}");
            }


            else if (tal1 < tal2) 
            {
                Console.WriteLine($"talet {tal2} är större än {tal1}");
            }

            else 
            {
                Console.WriteLine($"Talen {tal1} och {tal2} är lika stora");

            }       
        }
    }
}
