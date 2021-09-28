﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Entidades
{
    class Profesor : Persona
    {
        private string titulo;
        private string designacion;
        private string dedicacion;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Designacion { get => designacion; set => designacion = value; }
        public string Dedicacion { get => dedicacion; set => dedicacion = value; }
    }
}
