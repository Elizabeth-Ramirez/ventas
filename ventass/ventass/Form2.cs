using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "San Pedro";

          

            var cliente1 = new Cliente ();
            cliente1.Id = 1;
            cliente1.Nombre  = "Elizabeth Ramirez";
            cliente1.Telefono = "9874-5123";
            cliente1.Ciudad = ciudad1;


            Cliente  cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre  = "Ana Moreno";
            cliente2.Telefono = "9895-7477";
            cliente2.Ciudad = ciudad1;

            Cliente cliente3 = new Cliente();
            cliente3.Id = 2;
            cliente3.Nombre = "Karol Ramirez";
            cliente3.Telefono = "9696-4252";
            cliente3.Ciudad = ciudad1;


            var listaclientes = new List<Cliente>();
            listaclientes.Add(cliente1);
            listaclientes.Add(cliente2);
            listaclientes.Add(cliente3);

            foreach (var cliente in listaclientes )
            {
                MessageBox.Show(cliente.Id + " " + cliente.Nombre + " " + cliente.Telefono + " " + cliente.Ciudad.Descripcion);
            }

        }
    }
}
