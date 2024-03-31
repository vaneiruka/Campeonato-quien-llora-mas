using System;
using System.Collections.Generic;
using System.Linq;

namespace Torneo_de_Futbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaLista listica = new LaLista(); //mientras tanto porque no tengo menu
            listica.PreguntarNombres();
            listica.Consultarequipos();
            //aqui solo deberia ir invocado el menu

        }
    }
}
