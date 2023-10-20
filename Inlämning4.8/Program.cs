using System;
using System.ComponentModel;

namespace Inlämning_4.__8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv något");
            string sträng = Console.ReadLine();
            Console.WriteLine("Skriv in två tecken");
            string tecken = Console.ReadLine();
            char tecken1 = tecken[0];
            char tecken2 = tecken[1];
            bool santTecken1 = false;
            bool santTecken2 = false;
            for (int i = 0;i<sträng.Length;i++)
            {
                if (sträng[i] == tecken1)
                {
                    santTecken1 = true;
                }
                else if (sträng[i] == tecken2)
                {
                    santTecken2 = true;
                }
                else
                {
                  
                }
            }
            if (santTecken1 == true)
            {
                Console.WriteLine(sträng +" Innehåller "+tecken1);
            }
            if (santTecken2 == true)
            {
                Console.WriteLine(sträng +" Innehåller "+tecken2);
            }
            else
            {
                Console.WriteLine(sträng+" Innehåller inte "+tecken1+" eller "+tecken2);
            }

        }
    }
}
