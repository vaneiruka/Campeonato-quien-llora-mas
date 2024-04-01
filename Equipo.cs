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
        }

        public Equipo(string NuevoNombre) //aqui mando el nombre nomas
        {
            this.Nombre= NuevoNombre;
            this.Grupo = "";
        }

       
        //Metodos

        public void setNombre(string NuevoNombre)
        {
            this.Nombre= NuevoNombre;
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



        //Metodo para generar encuentros

    }
}
