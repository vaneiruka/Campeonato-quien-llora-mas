using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo_de_Futbol
{
    internal class Encuentro
    {
        //Atributos
        private Equipo equipoLocal;
        private Equipo equipoVisitante;

        //Constructor
        public Encuentro(Equipo equipoLocal, Equipo equipoVisitante)
        {
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
        }

        //Metodos Get
        public Equipo getEquipoLocal()
        {
            return equipoLocal;
        }

        public Equipo getEquipoVisitante()
        {
            return equipoVisitante;
        }


        public void MostrarEncuentros(Equipo[] Milista) //Metodo para mostrar y generar los encuentros
        {
            // matriz para almacenar los encuentros.
            Encuentro[,] matrizEncuentros = new Encuentro[Milista.Length / 2, Milista.Length / 2];

            // Encuentros para el grupo A.
            for (int i = 0; i < Milista.Length / 2; i++)
            {
                for (int j = i + 1; j < Milista.Length / 2; j++)
                {
                    matrizEncuentros[i, j] = new Encuentro(Milista[i], Milista[j]);
                }
            }

            // Encuentros para el grupo B.
            for (int i = Milista.Length / 2; i < Milista.Length; i++)
            {
                for (int j = i + 1; j < Milista.Length; j++)
                {
                    matrizEncuentros[i - Milista.Length / 2, j - Milista.Length / 2] = new Encuentro(Milista[i], Milista[j]);
                }
            }

            // Mostramos los encuentros.
            for (int i = 0; i < Milista.Length / 2; i++)
            {
                for (int j = 0; j < Milista.Length / 2; j++)
                {
                    Console.WriteLine("Encuentro Grupo A:");
                    Console.WriteLine("Equipo 1: " + matrizEncuentros[i, j].equipoLocal.getNombre());
                    Console.WriteLine("Equipo 2: " + matrizEncuentros[i, j].equipoVisitante.getNombre());
                    Console.WriteLine();

                    Console.WriteLine("Encuentro Grupo B:");
                    Console.WriteLine("Equipo 1: " + matrizEncuentros[i + Milista.Length / 2, j + Milista.Length / 2].equipoLocal.getNombre());
                    Console.WriteLine("Equipo 2: " + matrizEncuentros[i + Milista.Length / 2, j + Milista.Length / 2].equipoVisitante.getNombre());
                    Console.WriteLine();
                }
            }
        }


    }
}
