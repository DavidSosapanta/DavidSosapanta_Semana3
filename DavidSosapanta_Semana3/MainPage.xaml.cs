using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DavidSosapanta_Semana3
{
    public partial class MainPage : ContentPage
    {
        public MainPage(String usuario )
        {
            InitializeComponent();
            txtusuario.Text = usuario;
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtNota1.Text);
                double dato2 = Convert.ToDouble(txtNota2.Text);
                double dato3 = Convert.ToDouble(txtNota3.Text);
                double dato4 = Convert.ToDouble(txtNota4.Text);
                double nota1 = dato1 * 0.3;
                double nota2 = dato2 * 0.2;
                double nota3 = dato3 * 0.3;
                double nota4 = dato4 * 0.2;
                double parcial1 = nota1 + nota2;
                double parcial2 = nota3 + nota4;
                double total = parcial1 + parcial2;
                if (total >= 7)
                {
                    txtEstado.Text = "APROBADO";
                }
                else
                {
                    txtEstado.Text = "REPROBADO";
                }

                txtNotaParcial1.Text = parcial1.ToString();
                txtNotaParcial2.Text = parcial2.ToString();
                txtNotaFinal.Text = total.ToString();


            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }

        }
    }
}
