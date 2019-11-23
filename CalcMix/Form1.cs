using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author: Vargas Juan José
namespace CalcMix
{
    public partial class Form1 : Form
    {

        bool punto, resta = true,val;
        int abrir, cerrar;
        public Form1()
        {
            InitializeComponent();
        }
      public void Form1_Load(object sender, EventArgs e)
        {//carga por defecto
          
            btnSuma.Enabled = false;
            btnCierre.Enabled = false;
            btnPunto.Enabled = false;
            btnDiv.Enabled = false;
            btnMul.Enabled = false;
            btnPot.Enabled = false;
            btnResta.Enabled = true;
            btnApertura.Enabled = true;
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            abrir = 0;
            cerrar = 0;
            resta = true;
            punto = false;
            val = false;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            //El try-catch lo coloco en el caso de q se igualara solo parentesis
            try
            {
                if (txtEntrada.Text == "(") txtEntrada.Text += "0";

                if (txtEntrada.Text == "") txtEntrada.Text = "0";
                String cerrando = "";
                for (int i = cerrar; i < abrir; i++)
                {
                    cerrando += ")";
                }

                txtEntrada.Text += cerrando;
                btnCierre.Enabled = false;
                double b = Convert.ToDouble(Evaluador.evaluar(txtEntrada.Text));
                string result = Convert.ToString(b);
                txtEntrada.Text += " = " + result;
            }
            catch (Exception ee)
            {
                txtEntrada.Text = "0";
            }
                Form1_Load(sender, e);
                btnSuma.Enabled = true;
                btnMul.Enabled = true;
                btnDiv.Enabled = true;
                btnPot.Enabled = true;
                btnApertura.Enabled = false;
            
  

    
           
           
            
        }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btn0_Click(object sender, EventArgs e)
        {

            val = true;
           txtEntrada.Text+="0";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;


            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            val = true;

            txtEntrada.Text += "1";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;

            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            val = true;
            txtEntrada.Text += "2";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;


            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            val = true;
            txtEntrada.Text += "3";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;

            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
                   btnResolver.Enabled = true;
        }

      
        private void btn4_Click(object sender, EventArgs e)
        {
            val = true;
            txtEntrada.Text += "4";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;


            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            val = true;
            txtEntrada.Text += "5";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;


            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            val = true;
            txtEntrada.Text += "6";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;

            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            val = true;
            txtEntrada.Text += "7";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;


            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            val = true;
           
            txtEntrada.Text += "8";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;

            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            val = true;
            txtEntrada.Text += "9";

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnApertura.Enabled = false;


            if (!punto) btnPunto.Enabled = true;
            else btnPunto.Enabled = false;

            if (cerrar < abrir) btnCierre.Enabled = true;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }

       

        private void btnPunto_Click(object sender, EventArgs e)
        {
           
             if ( !punto)
            {
                txtEntrada.Text += ".";
               
                punto = true;
            }
            
            btnApertura.Enabled = false;
            btnCierre.Enabled = false;
            btnResta.Enabled = false;

            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btnPunto.Enabled = false;
            btnSuma.Enabled = false;
            btnDiv.Enabled = false;
            btnMul.Enabled = false;
            btnPot.Enabled = false;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);

            txtEntrada.Text = "";
            btnPunto.Enabled = false;
            punto = false;
          
          
        } 

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0')
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '#')
            {
                e.Handled = true;

            }else
            {
                e.Handled = false;
            }
        }
        
        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void btnApertura_Click(object sender, EventArgs e)
        {

       
                txtEntrada.Text += "(";
                abrir++;
            
            btnSuma.Enabled = false;
            btnResta.Enabled = true;
            btnApertura.Enabled = true;

            btnDiv.Enabled = false;
            btnMul.Enabled = false;
            btnPot.Enabled = false;
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
         
            if (cerrar < abrir)
            {
                txtEntrada.Text += ")";
                cerrar++;
            }
            else btnCierre.Enabled = false;

            btnApertura.Enabled = false;
            btnPunto.Enabled = false;
                btn0.Enabled = false; //se desabilitan valores //aca ponerlos en false
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

            btnSuma.Enabled = true;
            btnDiv.Enabled = true;
            btnMul.Enabled = true;
            btnPot.Enabled = true;
            btnResolver.Enabled = true;
        }

       
    

       

        private void btnResta_Click(object sender, EventArgs e)
        {

            txtEntrada.Text += "-";
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnResta.Enabled = false;

            btnApertura.Enabled = true;
            btnPunto.Enabled = false;
            resta = true;
            if (cerrar < abrir && !resta)
            {
                btnCierre.Enabled = true;
                resta = false;
            }
            else btnCierre.Enabled = false;
            punto = false;
            btnSuma.Enabled = false;
            btnDiv.Enabled = false;
            btnMul.Enabled = false;
            btnPot.Enabled = false;


            resta = false;
            btnResolver.Enabled = false;

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "+";
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnApertura.Enabled = true;
            btnSuma.Enabled = false;
            btnPunto.Enabled = false;
            btnResta.Enabled = false;
            btnCierre.Enabled = false;
            punto = false;
            btnDiv.Enabled = false;
            btnMul.Enabled = false;
            btnPot.Enabled = false;
            btnResolver.Enabled = false;
        }
      
        private void btnMul_Click(object sender, EventArgs e)
        {

         txtEntrada.Text += "*";



            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnResta.Enabled = true;
         

            btnApertura.Enabled = true;


            btnCierre.Enabled = false;
            btnSuma.Enabled = false;
            btnDiv.Enabled = false;
            btnPunto.Enabled = false;
            btnPot.Enabled = false;




            btnMul.Enabled = false;

            punto = false;
            btnResolver.Enabled = false;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {



            txtEntrada.Text += "/";

            //ya lo habilitaron unos
            // y lo deshabilitaron otros

            //a quien habilita?
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnResta.Enabled = true;
        
            btnApertura.Enabled = true;

            //a quien deshabilita?
            btnCierre.Enabled = false;
            btnSuma.Enabled = false;
            btnMul.Enabled = false;
            btnPunto.Enabled = false;
            btnPot.Enabled = false;
            // Y se deshabilita el mismo, hasta que lo habilite otro
            btnDiv.Enabled = false;

            punto = false;
            btnResolver.Enabled = false;
        }

        private void btnPot_Click(object sender, EventArgs e)
        {

            //Si no se ha ingresado por teclado se agrega.
            txtEntrada.Text += "^";
            //ya lo habilitaron unos
            // y lo deshabilitaron otros

            //a quien habilita?
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnApertura.Enabled = true;

            //a quien deshabilita?
            btnCierre.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnMul.Enabled = false;
            btnDiv.Enabled = false;
            btnPunto.Enabled = false;

            // Y se deshabilita el mismo, hasta que lo habilite otro
            btnPot.Enabled = false;

            punto = false;
            btnResolver.Enabled = false;

        }
    }
}
