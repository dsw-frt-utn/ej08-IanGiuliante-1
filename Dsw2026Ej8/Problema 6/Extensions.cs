using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_6
{
    public static class Extensions
    {
        public static string ToProductCode(this string value) {
            string message;

            if (value == null)
            {
                message = "SIN-CODIGO";
            }
            else {
                message = value.ToUpper().Replace(" ", "-").Trim();
            }
            return message;
        }
    }
}
