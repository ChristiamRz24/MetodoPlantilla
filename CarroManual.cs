using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónDeDiseñoTemplateMethod
{
    public class CarroManual : IPrimitiva
    {

        public int cambiarMarcha(int pVelocidad, int pMarcha)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("Desea cambiar la marcha del carro (?): \n1. Aumentar marcha \n2. Disminuir marcha");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion != 1 && opcion != 2) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Solo puede elegir entre las opciones 1 y 2");
                }

            } while (opcion != 1 && opcion != 2);


            if (opcion == 1) 
            {
                pMarcha = pMarcha + 1;
                if (pMarcha > 5) 
                {
                    pMarcha = 5;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se puede aumentar más la marcha!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                    
            }
                
            if (opcion == 2)
            {
                pMarcha = pMarcha - 1;
                if (pMarcha <= 0)
                {
                    pMarcha = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se puede disminuir más la marcha!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            }

            return pMarcha;
        }

    }
}