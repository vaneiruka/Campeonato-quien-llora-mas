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
            auxiliar = 0;
            NumeroEquipos = 0;
            Milista = new Equipo[10]; //tiene maximo 10, no importa si quedan posiciones sobrando :c
        }

        //Metodos

        public Array getMilista()
        {
            return Milista;
        }


        //Validacion
        public void establecernumeroequipos()
        {
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el numero de equipos que participaran en el Campeonato Los Sufridos:");
                    NumeroEquipos = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }

            } while (NumeroEquipos != 6 && NumeroEquipos != 8 && NumeroEquipos != 10);
        }

        //aqui voy a agregar el nombre y grupo de cada equipo
        public void PreguntarNombres()
        {
            establecernumeroequipos();
            string aux;
            int aux2 = 1;
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
            } while (aux2 < NumeroEquipos + 1);
            Console.Clear();
        }

        //Para guardar mis objetos de tipo Equipo aqui
        private void Agregarequipos(Equipo Gatitos)
        {
            this.Milista[auxiliar] = Gatitos;
            auxiliar++;
        }

        //para ver el arreglo en pantalla
        public void Consultarequipos()
        {
            int aux3 = 1;

            for (int i = 0; i < NumeroEquipos; i++)
            {
                Console.WriteLine("\n*************************************************************");
                Console.WriteLine("\n*El nombre del equipo " + aux3 + " es: " + Milista[i].getNombre());
                Console.WriteLine("\n*El grupo al que pertenece es: " + Milista[i].getGrupo());
                Console.WriteLine("\n*************************************************************");
                aux3++;
            }

        }

        //Buscando equipos por nombre

        public Equipo BuscarEquipoPorNombreYMostrarGrupo(string nombreEquipo)
        {
            Equipo equipoEncontrado = null;

            // Buscar el equipo por nombre
            foreach (Equipo equipo in Milista)
            {
                if (equipo != null)
                {
                    if (equipo.getNombre().Equals(nombreEquipo, StringComparison.OrdinalIgnoreCase))
                    {
                        equipoEncontrado = equipo;
                        break;
                    }
                }
            }

            // Si se encontró el equipo, mostrar su información
            if (equipoEncontrado != null)
            {
                Console.WriteLine($"El equipo {equipoEncontrado.getNombre()} pertenece al grupo {equipoEncontrado.getGrupo()} y su posición en la tabla es: {equipoEncontrado.getPosicionTabla()}");
            }
            else
            {
                Console.WriteLine($"No se encontró un equipo con el nombre {nombreEquipo}");
            }
            return equipoEncontrado;
        }


        public void SepararGrupos()
        {
            // Crear dos arreglos para los grupos A y B
            Equipo[] GrupoA = new Equipo[NumeroEquipos / 2];
            Equipo[] GrupoB = new Equipo[NumeroEquipos / 2];

            // Recorrer la lista de equipos y separarlos por grupo
            int indiceA = 0, indiceB = 0;
            for (int i = 0; i < NumeroEquipos; i++)
            {
                if (Milista[i] != null)
                {
                    if (Milista[i].getGrupo() == "A")
                    {
                        GrupoA[indiceA++] = Milista[i];
                    }
                    else
                    {
                        GrupoB[indiceB++] = Milista[i];
                    }
                }
            }

            // Llamar al método para generar los partidos de cada grupo
            GenerarMatrizPartidos(GrupoA);
            GenerarMatrizPartidos(GrupoB);
        }


        public void GenerarMatrizPartidos(Equipo[] grupo)
        {
            int grupoSize = grupo.Length;

            for (int i = 0; i < grupoSize ; i++)
            {
                for (int j = i + 1; j < grupoSize; j++)
                {
                    // Agregar los partidos a la matriz
                    int[,] partidos = new int[NumeroEquipos, NumeroEquipos];
                    partidos[i, j] = 1;
                    partidos[j, i] = 1;
                }
            }
        }

        public void GenerarMatrizPartidos(Equipo[] GrupoA, Equipo[] GrupoB)
        {
            int grupoASize = GrupoA.Length;
            int grupoBSize = GrupoB.Length;

            for (int i = 0; i < grupoASize; i++)
            {
                for (int j = i + 1; j < grupoASize; j++)
                {
                    // Agregar los partidos a la matriz
                    int[,] partidos = new int[NumeroEquipos, NumeroEquipos];
                    partidos[i, j] = 1;
                    partidos[j, i] = 1;
                }
            }

            for (int i = 0; i < grupoBSize; i++)
            {
                for (int j = i + 1; j < grupoBSize; j++)
                {
                    // Agregar los partidos a la matriz
                    int[,] partidos = new int[NumeroEquipos, NumeroEquipos];
                    partidos[i + grupoASize, j + grupoASize] = 1;
                    partidos[j + grupoASize, i + grupoASize] = 1;
                }
            }
        }

        public void MostrarPartidos(int[,] partidos)
        {
            int grupoASize = NumeroEquipos / 2;

            Console.WriteLine("\nPARTIDOS DEL GRUPO A:");

            for (int i = 0; i < grupoASize; i++)
            {
                for (int j = 0; j < grupoASize; j++)
                {
                    if (partidos[i, j] == 1)
                    {
                        Console.WriteLine((i + 1) + " vs " + (j + 1));
                    }
                }
            }

            Console.WriteLine("\nPARTIDOS DEL GRUPO B:");

            for (int i = 0; i < grupoASize; i++)
            {
                for (int j = 0; j < grupoASize; j++)
                {
                    if (partidos[i + grupoASize, j + grupoASize] == 1)
                    {
                        Console.WriteLine((i + 1 + grupoASize) + " vs " + (j + 1 + grupoASize));
                    }
                }
            }
        }

        public void GuardarMarcador(int[,] partidos, int marcadorLocal, int marcadorVisitante)
        {
            int local = 0;
            int visitante = 0;

            for (int i = 0; i < NumeroEquipos; i++)
            {
                for (int j = 0; j < NumeroEquipos; j++)
                {
                    if (partidos[i, j] == 1)
                    {
                        if (i + 1 == marcadorLocal)
                        {
                            local = i;
                        }

                        if (j + 1 == marcadorVisitante)
                        {
                            visitante = j;
                        }
                    }
                }
            }

            Milista[local].setPartidosJugados(Milista[local].getPartidosJugados() + 1);
            Milista[local].setGolesFavor(Milista[local].getGolesFavor() + marcadorLocal);
            Milista[local].setGolesContra(Milista[local].getGolesContra() + marcadorVisitante);

            if (marcadorLocal > marcadorVisitante)
            {
                Milista[local].setPartidosGanados(Milista[local].getPartidosGanados() + 1);
            }
            else if (marcadorLocal < marcadorVisitante)
            {
                Milista[visitante].setPartidosGanados(Milista[visitante].getPartidosGanados() + 1);
            }
            else
            {
                Milista[local].setPartidosEmpatados(Milista[local].getPartidosEmpatados() + 1);
                Milista[visitante].setPartidosEmpatados(Milista[visitante].getPartidosEmpatados() + 1);
            }

            Milista[visitante].setPartidosJugados(Milista[visitante].getPartidosJugados() + 1);
            Milista[visitante].setGolesFavor(Milista[visitante].getGolesFavor() + marcadorVisitante);
            Milista[visitante].setGolesContra(Milista[visitante].getGolesContra() + marcadorLocal);

            if (marcadorVisitante > marcadorLocal)
            {
                Milista[visitante].setPartidosGanados(Milista[visitante].getPartidosGanados() + 1);
            }
            else if (marcadorVisitante < marcadorLocal)
            {
                Milista[local].setPartidosGanados(Milista[local].getPartidosGanados() + 1);
            }
            else
            {
                Milista[local].setPartidosEmpatados(Milista[local].getPartidosEmpatados() + 1);
                Milista[visitante].setPartidosEmpatados(Milista[visitante].getPartidosEmpatados() + 1);
            }
        }
    }
}

    

