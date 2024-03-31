using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo_de_Futbol
{
    internal class LaLista
    {
        //Atributos
        private Equipo[] Milista; //aqui guardare los equipos
        private int auxiliar;
        private int NumeroEquipos;        


        //Constructores

        public LaLista()
        {
            auxiliar= 0;
            NumeroEquipos = 0;
            Milista = new Equipo[10]; //tiene maximo 10, no importa si quedan posiciones sobrando :c
        }

        //Metodos

        public void establecernumeroequipos()
        {
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el numero de equipos que participaran en el Campeonato Los Sufridos:");
                    NumeroEquipos = int.Parse(Console.ReadLine());

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }

            } while (NumeroEquipos != 6 && NumeroEquipos != 8 && NumeroEquipos != 10);
        }

        public void PreguntarNombres() 
        {
            establecernumeroequipos();
            string aux;
            int aux2=1;

            do
            {
                Console.WriteLine("\nInserte el nombre del equipo " + aux2 + ":\n");
                aux = Console.ReadLine();
                Equipo Gatitos = new Equipo(aux);
                Console.WriteLine("\nEl nombre del equipo " + aux2 + " es:\n");
                Console.WriteLine(Gatitos.getNombre());
                Agregarequipos(Gatitos);
                aux2++; //nomas por estetica pero aja
            }while (aux2 < NumeroEquipos+1);
        }

       private void Agregarequipos(Equipo Gatitos) //Para guardar mis objetos de tipo equipo aqui
        {
            this.Milista[auxiliar] = Gatitos;
            auxiliar++;
        }

        public void Consultarequipos() //para ver el arreglo en pantalla
        {
           int aux3 = 1;

            for(int i=0;i<NumeroEquipos;i++)
            {
                Console.WriteLine("\nEl nombre del equipo " + aux3 + " es: " + Milista[i].getNombre()); aux3++;
            }

        }


    }
}
