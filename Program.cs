using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Torneo_de_Futbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaLista listica = new LaLista(); //mientras tanto porque no tengo menu
            listica.PreguntarNombres(); //Primera pregunta leer nombres y grupos

            Encuentro encuentritos = new Encuentro();//mandarle parametros y llamar a mostrar encuentros

            //aqui solo deberia ir invocado el menu

        }
    }
}
