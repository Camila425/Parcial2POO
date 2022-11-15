using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Equipo
    {

        public List<Jugador> ListaJugadores;
        public DirectorTecnico directorTecnico { get; set; }
        public string Nombre { get; set; }
        public Deporte Deporte { get; set; }
        public Equipo(Deporte deporte)
        {
            Deporte = Deporte.futbol;
        }
        private Equipo()
        {
            ListaJugadores = new List<Jugador>();
        }
        public Equipo(string nombre,DirectorTecnico Directortec):this()
        {
            Nombre = nombre;
            directorTecnico = Directortec;
        }
        public Equipo(string nombre,DirectorTecnico director,Deporte deporte)
        {
            Nombre = nombre;
            directorTecnico = director;
            Deporte = deporte;
        }
        public static bool operator ==(Equipo equipo,Jugador jugador)
        {
            return equipo == jugador;
        }
        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }
        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            if (!equipo.ListaJugadores.Contains(jugador))
            {
                equipo.ListaJugadores.Add(jugador);
            }
            return true;
        }
        public static bool operator -(Equipo equipo, Jugador jugador)
        {
            if (equipo.ListaJugadores.Contains(jugador))
            {
                equipo.ListaJugadores.Remove(jugador);
            }
            return true;
        }
   
    }
}
