using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class DirectorTecnico : Persona
    {

        public Tipo tipo { get; set; }

        public DirectorTecnico(Tipo Tipo,string nombre,string apellido):base(nombre,apellido)
        {
            tipo = Tipo.tecnico;
        }


        public override string FichaTecnica()
        {
            return $"EP GUARDIOLA,{tipo=Tipo.tecnico}";
        }
    }
}
