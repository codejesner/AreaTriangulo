using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtBase.Text != "" && txtAltura.Text != "" && txtBase.Text != "0" && txtAltura.Text != "0")
            {
                double baseTriangulo = double.Parse(txtBase.Text);
                double alturaTriangulo = double.Parse(txtAltura.Text);
                double areaTriangulo = baseTriangulo * alturaTriangulo / 2;

                lblArea.Text = $"Area {areaTriangulo} cm²";
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }
    }
}
