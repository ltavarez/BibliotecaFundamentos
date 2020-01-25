using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] libros = new string[10];
            string[] reindexar = new string[10];



            while (true)
            {
                int menu = 0;
                bool isClose = false;
                Console.Clear();
                Console.WriteLine("Itla Biblioteca Virtual\n");
                Console.WriteLine("pulse el numero de la opcion deseada: ");
                Console.WriteLine("1-agregar libros\n 2-editar libros\n 3-borrar libros\n  4- lista libros disponibles\n  5-salir del sistema");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        if (string.IsNullOrEmpty(libros[9]))
                        {

                            Console.WriteLine("Digite el nombre del libro");
                            string libro = Console.ReadLine();

                            for (int i = 0; i < libros.Length; i++)
                            {
                                string elemento = libros[i];

                                if (string.IsNullOrEmpty(elemento))
                                {
                                    libros[i] = libro;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Se puede cuidar");
                            Console.ReadKey();
                        }
                        break;

                    case 2:

                        if (string.IsNullOrEmpty(libros[0]))
                        {

                            Console.WriteLine("Aqui no hay de eso");
                        }
                        else { 

                            Console.WriteLine("Seleccione el libro que desea editar");
                            

                        for (int i = 0; i < libros.Length; i++)
                        {
                            string elemento = libros[i];

                            if (!string.IsNullOrEmpty(elemento))
                            {
                                Console.WriteLine((i + 1) + " - " + elemento);
                            }
                        }

                            int libroAEditar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite el nuevo nombre del libro");
                            string newLibro = Console.ReadLine();

                            libros[libroAEditar - 1] = newLibro;

                        }

                        Console.ReadKey();


                        break;

                    case 3:

                        if (string.IsNullOrEmpty(libros[0]))
                        {

                            Console.WriteLine("Aqui no hay de eso");
                        }
                        else
                        {

                            Console.WriteLine("Seleccione el libro que desea borrar");


                            for (int i = 0; i < libros.Length; i++)
                            {
                                string elemento = libros[i];

                                if (!string.IsNullOrEmpty(elemento))
                                {
                                    Console.WriteLine((i + 1) + " - " + elemento);
                                }
                            }
                            int libroABorrar = Convert.ToInt32(Console.ReadLine());

                           

                            libros[libroABorrar - 1] = null;

                            //Tomo los valores para reindexar los indices
                            int posicionReIndex = 0;
                            for (int i = 0; i < libros.Length; i++)

                            {
                                string elemento = libros[i];

                                if (!string.IsNullOrEmpty(elemento))
                                {
                                    reindexar[posicionReIndex] = elemento;
                                    posicionReIndex++;
                                }
                            }


                            // Limpio el array de libros
                            for (int i = 0; i < libros.Length; i++)
                            {
                              libros[i] = null;
                            }

                            //agrego los valores en el orden correcto
                            for (int i = 0; i < reindexar.Length; i++)
                            {

                                string elemento = reindexar[i];

                                if (!string.IsNullOrEmpty(elemento))
                                {
                                    libros[i] = elemento;
                                }

                              
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 4:

                        if (string.IsNullOrEmpty(libros[0]))
                        {

                            Console.WriteLine("Aqui no hay de eso");
                        }
                        else
                        {
                            Console.WriteLine("Este es el listado de libros disponibles");

                            for (int i = 0; i < libros.Length; i++)
                            {
                                string elemento = libros[i];

                                if (!string.IsNullOrEmpty(elemento))
                                {
                                    Console.WriteLine((i + 1) + " - " + elemento);
                                }
                            }
                        }

                        Console.ReadKey();
                        break;


                    case 5:
                        isClose = true;
                        break;
                }

                if (isClose)
                {
                    break;
                }

            }

            Console.WriteLine("Gracias por utilizar nuestro sistema");
            Console.ReadKey();
        }
    }
}
