using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();  /*Creo una nueva instancia del formulario de inicio*/

            form.Show();    /*Mostramos el formulario de inicio*/
            this.Hide();   /* Cerramos el formulario actual (Login)*/

            form.FormClosing += frm_closing;    /*Encadeno eventos*/

        }

        //Evento que sirve para mostrar el formulario de logueo
        //cuando se cierra el formulario de inicio
        private void frm_closing(Object sender, FormClosingEventArgs e)
        {
            this.Show();    /* Mostramos el formulario actual (Login)*/

        }
    }
}
