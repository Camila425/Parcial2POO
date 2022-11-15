using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Jugador : Persona
    {
        public bool escapitan { get; set; }
        public int numero { get; set; }
        public Tipo tipo { get; set; }

        public Jugador(string Nombre, string Apellido,int numero) : base(Nombre, Apellido)
        {

        }

        public Jugador(bool Escapitan,int Numero,string Nombre,string Apellido) :base(Nombre,Apellido)
        {
            escapitan = false; ;
            numero = 0;

        }


        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Jugador))
            {
                return false;
            }
            return  this.nombre == ((Jugador)obj).nombre &&
                this.apellido==((Jugador)obj).apellido &&
            this.numero == ((Jugador)obj).numero;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }
        public override string FichaTecnica()
        {
            if (escapitan)
            {
              return $" NAVAS Fernando,capitán del equipo,camiseta numero:{numero=11}";
            }
            else if(!escapitan)
            {
              return $" NAVAS Fernando,camiseta numero:{numero = 6}"; 
            }
            return "";
        }

        public static bool operator ==(Jugador j1,Jugador j2)
        {
            return (j1.nombre.Equals(j2.nombre) && j1.apellido.Equals(j2.apellido) && j1.numero.Equals(j2.numero));
        }
        public static bool operator !=(Jugador j1,Jugador j2)
        {
            return !(j1==j2);
        }

        public static  explicit operator int (Jugador jugador)
        {
            return jugador.numero;
        }










    }
}
