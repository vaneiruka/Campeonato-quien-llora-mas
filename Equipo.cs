using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Torneo_de_Futbol
{
    internal class Equipo
    {
        //Atributos
        private string Nombre; //unico con get y set por ahora
        private string Grupo;
        private int PartidosJugados;
        private int PartidosGanados;
        private int PartidosEmpatados;
        private int PartidosPerdidos;
        private int GolesFavor;
        private int GolesContra;
        private int PuntosTotales;
        private int PosicionTabla;


        //Constructores


        public Equipo() //sin parametros inicializa vacio
        {
            Nombre = string.Empty;
            Grupo = string.Empty;
            PartidosJugados = 0;
            PartidosGanados = 0;
            PartidosEmpatados = 0;
            PosicionTabla = 0;
            PartidosPerdidos = 0;
            GolesFavor = 0;
            GolesContra = 0;
            PuntosTotales = 0;
        }

        public Equipo(string NuevoNombre) //aqui mando el nombre nomas
        {
            this.Nombre = NuevoNombre;
            this.Grupo = "";
        }


        //Metodos

        public void setNombre(string NuevoNombre)
        {
            this.Nombre = NuevoNombre;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setGrupo(string Nuevogrupo)
        {
            this.Grupo = Nuevogrupo;
        }

        public string getGrupo()
        {
            return Grupo;
        }


        public void setPosicionTabla(int NewPosicionTabla)
        {
            this.PosicionTabla = NewPosicionTabla;
        }

        public int getPosicionTabla()
        {
            return PosicionTabla;
        }

        public void setPartidosJugados(int Pj)
        {
            this.PartidosJugados = Pj;
        }

        public int getPartidosJugados()
        { return PartidosJugados; }

        public void setPartidosGanados(int Pg)
        {
            this.PartidosGanados = Pg;
        }

        public int getPartidosGanados()
        { return PartidosGanados; }

        public void setPartidosPerdidos(int Pp)
        {
            this.PartidosPerdidos = Pp;
        }

        public int getPartidosPerdidos()
        { return PartidosPerdidos; }

        public void setPartidosEmpatados(int Pe)
        {
            this.PartidosEmpatados = Pe;
        }

        public int getPartidosEmpatados()
        { return PartidosEmpatados; }

        public void setGolesFavor(int Gf)
        {
            this.GolesFavor = Gf;
        }

        public int getGolesFavor()
        { return GolesFavor; }

        public void setGolesContra(int Gc)
        {
            this.GolesContra = Gc;
        }

        public int getGolesContra()
        { return GolesContra; }

        public void setPuntosTotales(int Pt)
        {
            this.PuntosTotales = Pt;
        }

        public int getPuntosTotales()
        { return PuntosTotales; }






    }
}