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

        public Array getMilista()
        {
            return Milista;
        }


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

        public void PreguntarNombres() //aqui voy a agregar el nombre y grupo de cada equipo
        {
            establecernumeroequipos();
            string aux;
            int aux2=1;
            int contA = 0;
            int contB = 0;

            do
            {
                Console.WriteLine("\nInserte el nombre del equipo " + aux2 + ":\n");
                aux = Console.ReadLine();
                Equipo Gatitos = new Equipo(aux);

                string grupo;
                do
                {
                    Console.WriteLine("\n¿A qué grupo desea asignar el equipo " + Gatitos.getNombre() + "? (A/B):");
                    grupo = Console.ReadLine().ToUpper(); //cosa que me funciona para transformar las letras de minuscula a mayuscula, nuevo descubrimiento waos
                } while (grupo != "A" && grupo != "B");

                if (grupo == "A" && contA < NumeroEquipos / 2) //Aqui comienzo a validar los grupos
                {
                    Gatitos.setGrupo("A");
                    contA++;
                }
                else if (grupo == "B" && contB < NumeroEquipos / 2)
                {
                    Gatitos.setGrupo("B");
                    contB++;
                }
                else
                {
                    Console.WriteLine("¡El grupo " + grupo + " está lleno! Lo agregaremos al grupo que se encuentra libre.");
                    if (grupo == "A")
                    {
                        Gatitos.setGrupo("B");
                        contB++;
                    }
                    else
                    {
                        Gatitos.setGrupo("A");
                        contA++;
                    }
                }

                Console.WriteLine("\nEl nombre del equipo " + aux2 + " es: " + Gatitos.getNombre() + " ; Y el grupo al que pertenece es el: " + Gatitos.getGrupo() + "\n");
                Agregarequipos(Gatitos);
                aux2++; //nomas por estetica pero aja
            }while (aux2 < NumeroEquipos+1);
        }

       private void Agregarequipos(Equipo Gatitos) //Para guardar mis objetos de tipo Equipo aqui
        {
            this.Milista[auxiliar] = Gatitos;
            auxiliar++;
        }

        public void Consultarequipos() //para ver el arreglo en pantalla
        {
           int aux3 = 1;

            for(int i=0;i<NumeroEquipos;i++)
            {
                Console.WriteLine("\n*************************************************************");
                Console.WriteLine("\n*El nombre del equipo " + aux3 + " es: " + Milista[i].getNombre()); 
                Console.WriteLine("\n*El grupo al que pertenece es: " + Milista[i].getGrupo());
                Console.WriteLine("\n*************************************************************");
                aux3++;
            }

        }




    }
}
