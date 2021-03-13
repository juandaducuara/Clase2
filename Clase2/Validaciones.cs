using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Clase2
{
    class Validaciones
    {
        public bool Vacio(string item)
        {
            if (item.Equals(""))
            {
                Console.WriteLine("La casilla no puede estar vacia");
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool TipoNombre(string item)
        {

            Regex regla = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");

            if (regla.IsMatch(item))
            {
                return true;
            }
            else
            {
                Console.WriteLine("El valor no es numerico");
                return false;
            }


        }
        public bool TipoTexto(string texto)
        {
            Regex regla = new Regex("^[a-zA-Z ]*$");
            if (regla.IsMatch(texto))
            {
                
                return true;
            }
            else
            {
                Console.WriteLine("Debe ser texto");
                return false;
            }
        }
    }
}
