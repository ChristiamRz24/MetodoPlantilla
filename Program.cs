using System;

namespace PatrónDeDiseñoTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionTipoCarro = 0;
            IPrimitiva tipoCarro = null;

            // Pedir el tipo de carro a probar/utilizar
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                // Presentación del programa
                Console.WriteLine("************************************");
                Console.WriteLine("*         Método plantilla         *");
                Console.WriteLine("************************************");

                // Eleccion del carro por parte del usuario
                Console.WriteLine("Elija el tipo de carro a utilizar: \n1. Carro Manual \n2. Carro automático");
                opcionTipoCarro = Convert.ToInt32(Console.ReadLine());

                if (opcionTipoCarro != 1 && opcionTipoCarro != 2)
                    Console.WriteLine("Solo puede elegir entre los tipos de carros 1 y 2");

            } while (opcionTipoCarro != 1 && opcionTipoCarro != 2);

            // Crear los objetos de acuerdo al tipo de carro elegido
            if (opcionTipoCarro == 1)
                tipoCarro = new CarroManual();
            if (opcionTipoCarro == 2)
                tipoCarro = new CarroAutomatico();

            Algoritmo carroPreparado = new Algoritmo();
            carroPreparado.metodoTemplate(tipoCarro);

        }
    }
}
