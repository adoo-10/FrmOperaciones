using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Entidades
{
    class Operaciones
    {
        private double ope1;
        private double ope2;
        private double resultado;


        public double Ope1 { get => ope1; set => ope1 = value; }
        public double Ope2 { get => ope2; set => ope2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        public Operaciones(double ope1, double ope2, double resultado)
        {
            this.Ope1 = ope1;
            this.Ope2 = ope2;
            this.Resultado = resultado;
        }

        public Operaciones() { }

    }
}
