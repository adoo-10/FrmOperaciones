using Forms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Negocio
{
    class ClsPersona
    {
        public string MostrarNombre(Persona per)
        {
            return per.Nombre;
        }
        public int Acceso(Persona per)
        {
            if (per.Nombre == "Adiel" && per.Password == "123")
            {
                return 1;
            }
            else { 

            return 0;
            }
        }
    }
}
