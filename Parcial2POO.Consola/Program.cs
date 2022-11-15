using Parcial2POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Tipo tipo = new Tipo();
            DirectorTecnico directorTecnico = new DirectorTecnico(tipo = Tipo.tecnico, "n", "a");
            Jugador j1 = new Jugador("nombre","apellido",11);
            Jugador j2 = new Jugador("nombre2", "apellido",11);
            if (j1==j2)
            {
                Console.WriteLine("jugadores son iguales");
            }
            else
            {
                Console.WriteLine("jugadores son distintos");
            }


            Equipo futbol = new Equipo("equipo",directorTecnico);
            Jugador j3= new Jugador("nombre1","apellido",11);
            Jugador j4 = new Jugador("nombre2", "apellido", 11);
            Jugador j5 = new Jugador("nombre3", "apellido", 11);
            DirectorTecnico tecnico = new DirectorTecnico(tipo=Tipo.tecnico,"nombre","apellido");

            if (futbol + j3)
            {
                Console.WriteLine("jugador agregado");
                Console.WriteLine(j3.NombreCompleto());
            }
            else
            {
                Console.WriteLine("jugador no agregado");
            }

            if (futbol + j4)
            {
                Console.WriteLine("jugador agregado");
                Console.WriteLine(j3.NombreCompleto());
            }
            else
            {
                Console.WriteLine("jugador no agregado");
            }

            if (futbol + j5)
            {
                Console.WriteLine("jugador agrgado");
                Console.WriteLine(j3.NombreCompleto());
            }
            else
            {
                Console.WriteLine("jugador no agregado");
            }

            Console.ReadLine();
        }
    }
}
