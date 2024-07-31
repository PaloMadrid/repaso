namespace Primeros_Pasos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            string nombre;
            string apellido;
            int edad;
            double peso;
            bool esMayor = false;
            int numero;

            //imprimir un mensaje en pantalla

            Console.WriteLine("esto es una prueba");

            //Ingresar datos

            Console.WriteLine("ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("ingrese su apellido:");
            apellido = Console.ReadLine();

            //ingresar datos numericos
            Console.WriteLine("ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su peso");
            peso = double.Parse(Console.ReadLine());

            //interpolado: mostrar un mensaje con un literal y contenido de la variable 
            Console.WriteLine($"El nombre ingresado es: {nombre} {apellido}, edad: {edad}, peso:{peso}");



            //condicionales

            if (nombre == "juan")
            {
                Console.WriteLine("Hola Juan");
            }
            else
            {
                Console.WriteLine("No sos juan");
            }


            //negacion de una condicion
            if (nombre != "juan")
            {
                Console.WriteLine("No sos juan");
            }
            else
            {
                Console.WriteLine("Hola Juan");
            }

            if (edad >= 18)
            {
                Console.WriteLine("es mayor de edad");
                esMayor = true;
            }
            else
            {
                Console.WriteLine("es menor de edad");
            }

            if (esMayor)
            {
                Console.WriteLine("puede votar");

                switch (edad)
                {
                    case 18:
                        Console.WriteLine("tiene 18 años");
                        break;
                    case 19:
                        Console.WriteLine("tiene 19 años");
                        break;
                    default:
                        Console.WriteLine("tiene 20 años o mas");
                        break;
                }
            }
            else
            {
                Console.WriteLine("no puede votar");
            }

            //bucles repetitivos

            //Notacion incremento
            //i= i+1
            //i+=1
            //i++

            //FOR: se cuantas repeticiones tiene que hacer
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el {i + 1}° numero: ");
                Console.WriteLine($"Valor i: {i}");

                numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"El {i + 1}° numero ingresado es: {numero} ");
                Console.WriteLine($"----------------------------------------");
            }

            //DO WHILE: se ejecuta el bucle al menos una vez
            do
            {
                Console.WriteLine("ingrese su edad");
                edad = int.Parse(Console.ReadLine());

            } while (edad >= 18);

            //WHILE: primero analiza la condicion y si es verdadera entra al bucle, sino no
            while (edad >= 18)
            {
                Console.WriteLine("ingrese su edad");
                edad = int.Parse(Console.ReadLine());
            }


        }
    }
}
