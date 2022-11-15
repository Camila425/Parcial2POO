using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public abstract class Persona
    {
        public string nombre { get;}
        public string apellido { get;}

        public Persona(string Nombre,string Apellido)
        {
            nombre = Nombre;
            apellido = Apellido;
        }
        public abstract string FichaTecnica();
        public virtual string NombreCompleto()
        {
            return $"{nombre}:jose {apellido}:perez";
        }



    }
}
