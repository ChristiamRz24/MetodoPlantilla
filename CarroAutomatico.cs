using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónDeDiseñoTemplateMethod
{
    public class CarroAutomatico : IPrimitiva
    {

        public int cambiarMarcha(int pVelocidad, int pMarcha)
        {
            // Cambios de marcha automáticos
            if (pVelocidad == 0)
                pMarcha = 0;
            if (pVelocidad > 0 && pVelocidad <= 20) 
                pMarcha = 1;
            if (pVelocidad > 20 && pVelocidad <= 40)
                pMarcha = 2;
            if (pVelocidad > 40 && pVelocidad <= 60)
                pMarcha = 3;
            if (pVelocidad > 60 && pVelocidad <= 80)
                pMarcha = 4;
            if (pVelocidad > 100 && pVelocidad <= 130)
                pMarcha = 5;

            return pMarcha;
        }

    }
}