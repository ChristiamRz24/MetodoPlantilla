using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónDeDiseñoTemplateMethod
{
    public class Algoritmo
    {
        // Variables
        int velocidad = 0;
        int marcha = 0;
        int tipoAccionARealizar = 0;

        // Método plantilla
        public void metodoTemplate(IPrimitiva tipo)
        {

            do 
            {
                Console.Clear();
                presentacion(velocidad, marcha);

                do
                {
                    Console.WriteLine("Elija el tipo de acción a realizar:" +
                        " \n1. Acelerar \n2. Desacelerar \n3. Cambiar Marcha \n4. Frenar ");
                    tipoAccionARealizar = Convert.ToInt32(Console.ReadLine());

                    if (tipoAccionARealizar != 1 && tipoAccionARealizar != 2 && tipoAccionARealizar != 3 && tipoAccionARealizar != 4) 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Solo puede elegir entre las acciones 1, 2, 3 y 4!");
                    }
                        

                } while (tipoAccionARealizar != 1 && tipoAccionARealizar != 2 && tipoAccionARealizar != 3 && tipoAccionARealizar != 4);

                if (tipoAccionARealizar == 1)
                    // Aumenta la velocidad del carro
                    velocidad = acelerar(velocidad);

                if (tipoAccionARealizar == 2)
                    // Dismuinuye la velovidad del carro
                    velocidad = desacelerar(velocidad);

                if (tipoAccionARealizar == 3)
                    // Cambia la velocidad del carro
                    marcha = tipo.cambiarMarcha(velocidad, marcha);

                if (tipoAccionARealizar == 4)
                {
                    // Detiene el carro, (velocidad = 0)
                    velocidad = frenar(velocidad);
                }

            } while (velocidad <= 140); // Bucle infinito
        }

        // Métodos que no varían
        private int acelerar(int pVelocidad) 
        {
            if (pVelocidad <= 120) // 120 km/h
            {
                pVelocidad = pVelocidad + 10; // Acelera 10 km/h
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Velocidad máxima permitida, desacelere!!");
                info();
            }

            return pVelocidad;
        }

        private int desacelerar(int pVelocidad)
        {
            if (pVelocidad > 0) // 0 km/h
            {
                pVelocidad = pVelocidad - 10; // Desacelera 10 km/h
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("El carro esta en reposo!");
                info();
            }
            return pVelocidad;
        }

        private int frenar(int pVelocidad)
        {
            pVelocidad = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El carro fue frenado con exito!");
            info();
            return pVelocidad;
        }

        public void presentacion(int pVelocidad, int pMarcha)
        {
            Console.ForegroundColor = ConsoleColor.White;
            // Presentación del programa
            Console.WriteLine("************************************");
            Console.WriteLine("*         Método plantilla         *");
            Console.WriteLine("************************************");
            // Mostrar info
            Console.WriteLine("====================================");
            Console.Write("La velocidad actual es de: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0} km/h\n", pVelocidad);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("La marcha actual es de: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0}\n", pMarcha);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================");
            Console.WriteLine();
        }

        public void info()  // Método para dar "diseño" al programa
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        // End

    }
}