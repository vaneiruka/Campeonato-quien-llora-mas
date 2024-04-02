using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Torneo_de_Futbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaLista listica = new LaLista(); 
            //1
            listica.PreguntarNombres();        

            Console.WriteLine("Introduzca el nombre del equipo que desea buscar:");
            string nombreEquipo = Console.ReadLine();
            //2
            listica.BuscarEquipoPorNombreYMostrarGrupo(nombreEquipo);
            string grupo = listica.BuscarEquipoPorNombreYMostrarGrupo(nombreEquipo).getGrupo();
            //3
            listica.SepararGrupos();

            //4
            int[,] partidos = new int[listica.NumeroEquipos, listica.NumeroEquipos];
            listica.GenerarMatrizPartidos(partidos);
            listica.MostrarPartidos(partidos);

            Console.WriteLine("Ingrese el marcador del partido (Goles del equipo local, goles del equipo visitante):");
            int marcadorLocal = int.Parse(Console.ReadLine());
            int marcadorVisitante = int.Parse(Console.ReadLine());

            listica.GuardarMarcador(partidos, marcadorLocal, marcadorVisitante);
            listica.MostrarPartidos(partidos);
            //Menusin Menucito = new Menusin();   Solucionar problema del menu eventualmente        
            //Menucito.menusin();                     

        }
    }
}

         