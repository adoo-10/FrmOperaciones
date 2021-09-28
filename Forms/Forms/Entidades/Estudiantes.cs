using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Entidades
{
    class Estudiantes : Persona
    {
        private string carrera;
        private string nroMatricula;

        public string Carrera { get => carrera; set => carrera = value; }
        public string NroMatricula { get => nroMatricula; set => nroMatricula = value; }
    }
}
