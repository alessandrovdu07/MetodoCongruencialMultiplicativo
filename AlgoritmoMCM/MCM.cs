using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCongruencialMultiplicativo.AlgoritmoMCM
{
    public class MCM
    {
        public List<double> ListaNumerosAleatorios = new List<double>();
        public double NumeroDatosAleatorios;

        //Constructor
        public MCM()
        {

        }

        public List<double> GenerarListaAleatoria(int Semilla, double Multiplicador, double Modulo, int numeroDatos)
        {
            double NumeroDatosAleatorios;

            ListaNumerosAleatorios.Add(Semilla);
            //int n = Semilla;
            for (int n = 0; n < numeroDatos; n++)
            //while (n != ListaNumerosAleatorios[n])
            {
                double SigNumeroAleatorio = (Multiplicador * ListaNumerosAleatorios[n]) % Modulo;
                ListaNumerosAleatorios.Add(SigNumeroAleatorio);
                if (SigNumeroAleatorio == Semilla)
                {
                    break;
                }
            }

            NumeroDatosAleatorios = ListaNumerosAleatorios.Count();
            return ListaNumerosAleatorios;

        }

        
    }
}
    