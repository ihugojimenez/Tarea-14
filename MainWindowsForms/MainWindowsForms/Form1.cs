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
            Usuarios usuario = new Usuarios("FernandoDrizzy", "123", "Hugo", "Jimenez");

            using (var db = new AlmacenBancasDB())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                db.Dispose(); 
            }
        }
    }
}
