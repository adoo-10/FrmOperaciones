using Forms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Negocio
{
    class ClsOperaciones
    {
        public double Suma(Operaciones operaciones)
        {
            operaciones.Resultado = operaciones.Ope1 + operaciones.Ope2;
            return operaciones.Resultado;
        }

        public double Resta(Operaciones operaciones)
        {
            operaciones.Resultado = operaciones.Ope1 - operaciones.Ope2;
            return operaciones.Resultado;
        }

        public double Multiplicacion(Operaciones operaciones)
        {
            operaciones.Resultado = operaciones.Ope1 * operaciones.Ope2;
            return operaciones.Resultado;
        }

        public double Division(Operaciones operaciones)
        {
            operaciones.Resultado = operaciones.Ope1 / operaciones.Ope2;
            return operaciones.Resultado;
        }
    }
}
