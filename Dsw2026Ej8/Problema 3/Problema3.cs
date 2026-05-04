using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    public class Problema3
    {
        public string CompararCopiar(int originalValue, Product product) { 
            int originalValueLocal=originalValue;
            Product productLocal = product;
            
            originalValueLocal += 1;

            productLocal.SetDescription("Nueva descripcion del producto!");

            return $"{originalValue}-{originalValueLocal}-{productLocal._description}";
        }
    }
}
