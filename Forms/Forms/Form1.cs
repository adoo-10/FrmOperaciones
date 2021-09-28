using Forms.Entidades;
using Forms.Negocio;
using Forms.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        private object valor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        Ventas ventas = new Ventas();
        private void button1_Click(object sender, EventArgs e)
        {
            //Persona per = new Persona();
            //per.Nombre = CapturarDatos.Text;
            //ClsPersona persona = new ClsPersona();
            //String nombre = persona.MostrarNombre(per);
            //MessageBox.Show(nombre);

            Estudiantes per = new Estudiantes();

            per.Nombre = TxtCapturarDatos.Text;
            per.Password = TxtPassword.Text;
            ClsPersona persona = new ClsPersona();
            int valor = persona.Acceso(per);
            //_ = valor; //detener consola (punto de quiebre)

            if (valor == 1)
            {
                //MessageBox.Show("Welcome");
                
                ventas.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
