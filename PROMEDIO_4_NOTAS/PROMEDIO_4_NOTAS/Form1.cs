using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROMEDIO_4_NOTAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            cargarForm();
        }

        private void cargarForm()
        {
            double N1, N2, N3, N4, NF;
            string condicion;

            N1 = double.Parse(txtnota1.Text);
            N2 = double.Parse(txtnota2.Text);
            N3 = double.Parse(txtnota3.Text);
            N4 = double.Parse(txtnota4.Text);

            NF = (N1 + N2 + N3 + N4) / 4;
            if (NF >= 14)
            {
                condicion = "ALUMNO APROBADO";
            }
            else
            {
                condicion = "ALUMNO DESAPROBADO";
            }

            txtnotaFinal.Text = NF.ToString("N2");
            txtcondicion.Text = condicion.ToString();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();txtnota1.Focus();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();
            txtnotaFinal.Clear();
            txtcondicion.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
