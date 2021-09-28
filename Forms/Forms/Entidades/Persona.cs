using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Entidades
{
    class Persona
    {
        private string nombre;
        private string password;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }


        public Persona()
        {
        }

        public Persona(string nombre, string password)
        {
            this.Nombre = nombre;
            this.Password = password;
        }

       
    }
}
