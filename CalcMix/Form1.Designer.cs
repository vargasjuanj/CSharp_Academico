namespace CalcMix
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnApertura = new System.Windows.Forms.Button();
            this.btnCierre = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(19, 12);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ShortcutsEnabled = false;
            this.txtEntrada.Size = new System.Drawing.Size(485, 22);
            this.txtEntrada.TabIndex = 0;
            this.txtEntrada.TabStop = false;
            this.txtEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrada_KeyPress);
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(362, 374);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(119, 73);
            this.btnResolver.TabIndex = 2;
            this.btnResolver.Text = "=";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(65, 40);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(332, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "∞ Corresponde a dividir por cero o número enorme.";
            this.lblInfo.UseMnemonic = false;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(47, 149);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 57);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(146, 149);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 57);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(189, 366);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 51);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnApertura
            // 
            this.btnApertura.Location = new System.Drawing.Point(47, 80);
            this.btnApertura.Name = "btnApertura";
            this.btnApertura.Size = new System.Drawing.Size(75, 56);
            this.btnApertura.TabIndex = 13;
            this.btnApertura.Text = "(";
            this.btnApertura.UseVisualStyleBackColor = false;
            this.btnApertura.Click += new System.EventHandler(this.btnApertura_Click);
            // 
            // btnCierre
            // 
            this.btnCierre.Location = new System.Drawing.Point(146, 80);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(75, 56);
            this.btnCierre.TabIndex = 14;
            this.btnCierre.Text = ")";
            this.btnCierre.UseVisualStyleBackColor = true;
            this.btnCierre.Click += new System.EventHandler(this.btnCierre_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(379, 200);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 51);
            this.btnSuma.TabIndex = 15;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(379, 145);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 49);
            this.btnResta.TabIndex = 16;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(379, 257);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 52);
            this.btnDiv.TabIndex = 18;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(379, 315);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 53);
            this.btnMul.TabIndex = 19;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(252, 149);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 57);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(146, 212);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 63);
            this.btn5.TabIndex = 23;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(95, 366);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 51);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(47, 212);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 63);
            this.btn4.TabIndex = 21;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(146, 281);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 55);
            this.btn8.TabIndex = 26;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(47, 281);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 55);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(252, 212);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 63);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(252, 281);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 55);
            this.btn9.TabIndex = 27;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(252, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 56);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPot
            // 
            this.btnPot.Location = new System.Drawing.Point(379, 80);
            this.btnPot.Name = "btnPot";
            this.btnPot.Size = new System.Drawing.Size(75, 56);
            this.btnPot.TabIndex = 29;
            this.btnPot.Text = "^";
            this.btnPot.UseVisualStyleBackColor = true;
            this.btnPot.Click += new System.EventHandler(this.btnPot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 483);
            this.Controls.Add(this.btnPot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnApertura);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txtEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "    Cal(Mix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.btnResolver_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtEntrada;
        public System.Windows.Forms.Button btnResolver;
        public System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.Button btn1;
        public System.Windows.Forms.Button btn2;
        public System.Windows.Forms.Button btnPunto;
        public System.Windows.Forms.Button btnApertura;
        public System.Windows.Forms.Button btnCierre;
        public System.Windows.Forms.Button btnSuma;
        public System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        public System.Windows.Forms.Button btn3;
        public System.Windows.Forms.Button btn5;
        public System.Windows.Forms.Button btn0;
        public System.Windows.Forms.Button btn4;
        public System.Windows.Forms.Button btn8;
        public System.Windows.Forms.Button btn7;
        public System.Windows.Forms.Button btn6;
        public System.Windows.Forms.Button btn9;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPot;
    }
}