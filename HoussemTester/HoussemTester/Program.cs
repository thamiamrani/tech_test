using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HoussemTester
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("input.txt");

            int position = 50;

            int NbDeZero = 0;

            foreach (string line in lines)
            {
                char lettre = line[0];
                string MesNumeroEnText = line.Substring(1);
                int MesNumero = Convert.ToInt32(MesNumeroEnText);

                if 
                    (lettre == 'L') position = (position - MesNumero) % 100;

                else 
                    position = (position + MesNumero) % 100;

                if (position == 0)
                    NbDeZero++;
                

            }

            Console.WriteLine(NbDeZero);
        }




    }
}
