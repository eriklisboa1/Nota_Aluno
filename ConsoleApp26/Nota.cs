using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp26
{
     class Nota
    {
       public string Nome;
       public double Nota1;
       public double Nota2;
       public double Nota3;

        public double SomaNotas()
        {
            return  Nota1 + Nota2 + Nota3;
            
        }
        public double AppOrRep()
        {
            double media = Nota1 + Nota2 + Nota3;
            if (media > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00 - media) + "PONTOS" );
            }
            return media;
        }

        public override string ToString()
        {
            return "NOTA FINAL = " + SomaNotas().ToString("F1", CultureInfo.InvariantCulture)
             + "\n" + AppOrRep().ToString("F2",CultureInfo.InvariantCulture); 
                
                
        }



    }
}
