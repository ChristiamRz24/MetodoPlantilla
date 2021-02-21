using System;
using System.Collections.Generic;
using System.Text;

namespace PatrónDeDiseñoTemplateMethod
{
    public interface IPrimitiva
    {
        int cambiarMarcha(int pVelocidad, int pMarcha);
    }
}