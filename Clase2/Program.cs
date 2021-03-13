using System;
using System.Collections.Generic;

namespace Clase2
{
    class Program
    {
        static Validaciones validar = new Validaciones();
        static List<string> Listanombres = new List<string>();
        static void Main(string[] args)
        {
            int opcmen;

            string aux;
            do
            {
                bool flag = false;
                Console.Clear();
                Console.WriteLine("---Menu Princial---");
                Console.WriteLine("1. Insertar Nombre ");
                Console.WriteLine("2. Listar Nombres ");
                Console.WriteLine("3. Buscar Nombres");
                Console.WriteLine("0. Salir");
                do
                {

                    Console.WriteLine("Digite una opcion");
                    aux = Console.ReadLine();
                    if (!validar.Vacio(aux))
                        if (validar.TipoNombre(aux))

                            flag = true;
                } while (!flag);
                opcmen = Convert.ToInt32(aux);


                switch (opcmen)
                {
                    case 1:
                        InsertarNombre();
                        break;
                    case 2:
                        ListarNombre();
                        break;
                    case 3:
                        BuscarNombre();
                        break;
                    case 0:
                        Console.WriteLine("Gracias por usar el programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.WriteLine("Presione una tela para continuar");
                Console.ReadKey();

            } while (opcmen > 0);
            static void InsertarNombre()
            {
                string nom;
                bool texoval = false;
                Console.WriteLine("Insertar nombre");
                do
                {
                    Console.WriteLine("Digite nombre");
                    nom = Console.ReadLine();
                    if (validar.Vacio(nom))
                        if (validar.TipoTexto(nom))
                            texoval = true;
                } while (texoval);
                if (existe(nom.ToLower()))
                {
                    Console.WriteLine("El usuario " + nom + " ya existe en el sistema");
                }
                else
                {
                    
                Listanombres.Add(nom.ToLower());
                
                }
                

            }
            static void ListarNombre()
            {

                Console.WriteLine("Listar nombres");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Cantidad de Nombres " + Listanombres.Count);
                Console.WriteLine("----------------------------");

                foreach (string nom in Listanombres)
                {
                    Console.WriteLine(nom);
                }
                Console.WriteLine("----------------------------");
            }
            static void BuscarNombre()
            {

                bool texoval = false;
                string nom;
                
                do
                {
                    Console.WriteLine("Digite nombre a buscar");
                    nom = Console.ReadLine();

                    if (validar.Vacio(nom))
                        if (validar.TipoTexto(nom))
                            texoval = true;
                } while (texoval);
                if (existe(nom.ToLower()))
                    Console.WriteLine(nom + " Existe en el sistema ");
                else
                    Console.WriteLine("No existe en el sistema ");
            }
            static bool existe(string texto)
            {
                bool aux = false;
                foreach (string item in Listanombres)
                {
                    if (item == texto)
                        aux = true;
                }
                return aux;
            }

            
        }
    }
}
