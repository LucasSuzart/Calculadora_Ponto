using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CalculadoraWebForms
{


    public partial class index : System.Web.UI.Page

    {

        decimal numero1,  numero2 ;


        private void txtResultado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Fazer algo
            }
        }

       

        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void btnSomar_Click(object sender, EventArgs e)
        {
            numero1 = decimal.Parse(txtResultado.Text);


            historico.Text += txtResultado.Text ;
            numeroAnterior.Value = txtResultado.Text;
            txtResultado.Text = "";
            lblOperacao.Value = "+";     
        }


        protected void btnSubtrair_Click(object sender, EventArgs e)
        {
            numero1 = decimal.Parse(txtResultado.Text);


            historico.Text += txtResultado.Text;
            numeroAnterior.Value = txtResultado.Text;
            txtResultado.Text = "";
            lblOperacao.Value = "-";
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            numero1 = decimal.Parse(txtResultado.Text);


            historico.Text += txtResultado.Text;
            numeroAnterior.Value = txtResultado.Text;
            txtResultado.Text = "";
            lblOperacao.Value = "/";
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            numero1 = decimal.Parse(txtResultado.Text);


            historico.Text += txtResultado.Text;
            numeroAnterior.Value = txtResultado.Text;
            txtResultado.Text = "";
            lblOperacao.Value = "*";
        }

        protected void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        protected void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        protected void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        protected void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        protected void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        protected void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        protected void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        protected void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        protected void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        protected void numero2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            decimal valorFinal = 0;
         
            if (lblOperacao.Value == "+")
               
                               

            {

                valorFinal = Convert.ToDecimal(Convert.ToDecimal(numeroAnterior.Value) + numero2);
              

            }
            else if (lblOperacao.Value == "-") 
            {
                valorFinal = Convert.ToDecimal(Convert.ToDecimal(numeroAnterior.Value) - numero2);
            }
            else if (lblOperacao.Value == "/")
            {
                valorFinal = Convert.ToDecimal(Convert.ToDecimal(numeroAnterior.Value) / numero2);
            }
            else if (lblOperacao.Value == "*")
            {
                valorFinal = Convert.ToDecimal(Convert.ToDecimal(numeroAnterior.Value) * numero2);
            }

            historico.Text += lblOperacao.Value +   txtResultado.Text +  " = " + valorFinal  + "<br />";
            txtResultado.Text = "";



        }

        protected void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }
    }
}

       

       
        
