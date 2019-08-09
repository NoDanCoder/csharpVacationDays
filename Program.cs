using System;
using System.Text;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Creo la variable de titulo, no lo escribo directamente en el "print", ya que nesectio saber su "Lenght"
            string msgTitle = "Bienvenido al sistema vacacional de Coca Cola (No pepsi gas weyyyyy >:u)";

            // Uso la funcion "stringMultiply" que cree abajo, le intuducto el caracter a repetir, y lo repito segun el largo el titulo
            string borderTitle = stringMultiply("*", msgTitle.Length);

            // imprimo el borde superior de arsteriscos, luego el titulo, y posteriormente el borde inferior
            Console.WriteLine("\n {0}", borderTitle);
            Console.WriteLine(msgTitle);
            Console.WriteLine("{0} \n", borderTitle);

            // Pido el nombre del empleado y la clave de departamento
            Console.Write("Nombre del empleado: ");
            string name = Console.ReadLine();

            Console.Write("Clave de departamento: ");
            int dept = Convert.ToInt32(Console.ReadLine());

            // solo existen tres departementos, si ingresa uno inexistente, el programa no va mas
            if (dept >= 1 && dept <= 3) {

                // Pido los años de antiguedad
                Console.Write("Años en la comañia: ");
                int antiquity = Convert.ToInt32(Console.ReadLine());

                // variable para almacenar los dias de vacaciones
                int vacDays = 0;

                // Selecciono segun el departemento
                switch (dept) {

                    // Segun el departemento, y segun la antiguedad del empleado, seteo los dias de vacaciones
                    case 1:
                        if (antiquity <= 1) vacDays = 6;
                        else if (antiquity <= 6) vacDays = 14;
                        else vacDays = 20;
                        break;

                    case 2:
                        if (antiquity <= 1) vacDays = 7;
                        else if (antiquity <= 6) vacDays = 15;
                        else vacDays = 22;
                        break;

                    case 3:
                        if (antiquity <= 1) vacDays = 10;
                        else if (antiquity <= 6) vacDays = 20;
                        else vacDays = 30;
                        break;

                }

                // imprimo la informacion solicitada
                Console.Write("El trabajador \"" + name + "\" tiene derecho a " + vacDays + " dias de vacaciones al año \n");

            }

            // mensaje de departemento inexistente
            else Console.Write("Error: Departamento inexistente \n");

            // Espero un enter para cerrar el programa
            Console.ReadLine();

        }

        // Multiplicador de palabras, entradas, la palabra y el numero de veces a repetir
        public static string stringMultiply(string input, int times) {

            // Creo un objeto "dummie" para contruir la palabra
            StringBuilder sb = new StringBuilder();

            // agrego al objeto constructor la palabra n veces, el numero dado
            for (int i = 0; i < times; i++) {
                sb.Append(input);
            }

            // Retorno la palabra ya repetida/construida
            return sb.ToString();

        }

    }

}
