using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_4
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1,int? nota2,int? nota3) {

            double suma=0;
            int aux = 0;
            double promedio=0;


            if (nota1.HasValue && nota1<=10 && nota1>=0) {
                suma += (int)nota1;
                aux += 1;
            }

            if (nota2.HasValue && nota2 <= 10 && nota2 >= 0)
            {
                suma += (int)nota2;
                aux += 1;
            }
            if (nota3.HasValue && nota3 <= 10 && nota3 >= 0)
            {
                suma += (int)nota3;
                aux += 1;
            }

            if (aux==0) {
                promedio = 0;
            }

            promedio = suma / aux;

            return promedio; 
        }
    }
}
