﻿using Forms.Entidades;
using Forms.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Vistas
{
    public partial class FrmResta : Form
    {
        public FrmResta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            Operaciones operaciones = new Operaciones();

            operaciones.Ope1 = Convert.ToDouble(TxtDato1.Text);
            operaciones.Ope2 = Convert.ToDouble(TxtDato2.Text);

            ClsOperaciones clsOperaciones = new ClsOperaciones();
            MessageBox.Show(Convert.ToString(clsOperaciones.Resta(operaciones)));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Datos invalidos");
            }
        }
    }
}
