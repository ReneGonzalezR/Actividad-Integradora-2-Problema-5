using System;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>
namespace Actividad_Integradora_2_Problema_5
{
    public partial class Form1 : Form
    {
        double[] semana = new double[7]{ 5500,2000,1780,0,7450,1020,1200};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenor5_Click(object sender, EventArgs e)
        {
            Estadistica est = new Estadistica();
            rtbDatos.Text = est.VentasMenores(semana);
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            Estadistica est = new Estadistica();
            rtbDatos.Text = est.TodasLasVentas(semana);
        }

        private void btnMenorVenta_Click(object sender, EventArgs e)
        {
            Estadistica est = new Estadistica();
            rtbDatos.Text = est.VentaMasBaja(semana);
        }
    }
}
