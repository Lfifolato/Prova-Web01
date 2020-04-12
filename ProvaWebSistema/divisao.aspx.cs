using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaWebSistema
{
    public partial class divisao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {


            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                lblResultado.Text = "Preencha Os Campos Acima";
                lblResultado.ForeColor = Color.Red;
            }

            else 
            {

                double num01, num02, soma;

                num01 = Convert.ToDouble(txtNum1.Text);
                num02 = Convert.ToDouble(txtNum2.Text);


                soma = (num01 / num02);

                lblResultado.Text = soma.ToString();
                lblResultado.ForeColor = Color.Black;

            }

            
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResultado.Text = "";

        }
    }
}