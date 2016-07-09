using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            usuario.apellido = ApellidoTextBox.Text;
            usuario.Contraseña = PassTextBox.Text;
            usuario.nombre = NombreTextBox.Text;
            usuario.nombreusuario = UserTextBox.Text;


           
        }
    }
}
