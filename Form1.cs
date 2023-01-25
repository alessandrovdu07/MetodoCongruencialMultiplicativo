using MetodoCongruencialMultiplicativo.AlgoritmoMCM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoCongruencialMultiplicativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Paso 1: Condicíon de vacío
                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals(""))
                {
                    MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                    return;
                }

                int Semilla = Convert.ToInt16(textBox1.Text);
                double Multiplicador = Convert.ToDouble(textBox2.Text);
                double Modulo = Convert.ToDouble(textBox3.Text);
                int numeroDatos = Convert.ToInt16(textBox4.Text);

                if (Semilla > 0 && Multiplicador > 0 && Modulo > 0)
                {
                    MCM algoritmo = new MCM();
                    List<double> lista = algoritmo.GenerarListaAleatoria(Semilla, Multiplicador, Modulo, numeroDatos);
                    llenarGrid(algoritmo.ListaNumerosAleatorios.Count(), algoritmo);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Vuelve a intentar");
            }

        }


        public void llenarGrid(double NumeroDatosAleatorios, MCM algoritmo)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Algoritmo MCM");
            dataGridView1.Columns.Add(numeroColumna2, "ID");
            for (int i = 0; i < NumeroDatosAleatorios; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = algoritmo.ListaNumerosAleatorios[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = i.ToString();
            }

        }
    }
}

  
