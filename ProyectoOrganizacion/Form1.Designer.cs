namespace ProyectoOrganizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbxMultiplicando = new System.Windows.Forms.TextBox();
            this.txtbxMultiplicador = new System.Windows.Forms.TextBox();
            this.txtMultiplicando = new System.Windows.Forms.Label();
            this.txtMultiplicador = new System.Windows.Forms.Label();
            this.txtAsterisco = new System.Windows.Forms.Label();
            this.txtInstrucciones = new System.Windows.Forms.Label();
            this.lstBoxResult = new System.Windows.Forms.ListBox();
            this.bttn_Calcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxMultiplicando
            // 
            this.txtbxMultiplicando.Location = new System.Drawing.Point(277, 109);
            this.txtbxMultiplicando.Name = "txtbxMultiplicando";
            this.txtbxMultiplicando.Size = new System.Drawing.Size(100, 22);
            this.txtbxMultiplicando.TabIndex = 0;
            // 
            // txtbxMultiplicador
            // 
            this.txtbxMultiplicador.Location = new System.Drawing.Point(454, 108);
            this.txtbxMultiplicador.Name = "txtbxMultiplicador";
            this.txtbxMultiplicador.Size = new System.Drawing.Size(100, 22);
            this.txtbxMultiplicador.TabIndex = 1;
            // 
            // txtMultiplicando
            // 
            this.txtMultiplicando.AutoSize = true;
            this.txtMultiplicando.Location = new System.Drawing.Point(451, 88);
            this.txtMultiplicando.Name = "txtMultiplicando";
            this.txtMultiplicando.Size = new System.Drawing.Size(90, 17);
            this.txtMultiplicando.TabIndex = 2;
            this.txtMultiplicando.Text = "Multiplicando";
            // 
            // txtMultiplicador
            // 
            this.txtMultiplicador.AutoSize = true;
            this.txtMultiplicador.Location = new System.Drawing.Point(274, 89);
            this.txtMultiplicador.Name = "txtMultiplicador";
            this.txtMultiplicador.Size = new System.Drawing.Size(87, 17);
            this.txtMultiplicador.TabIndex = 3;
            this.txtMultiplicador.Text = "Multiplicador";
            // 
            // txtAsterisco
            // 
            this.txtAsterisco.AutoSize = true;
            this.txtAsterisco.Location = new System.Drawing.Point(410, 110);
            this.txtAsterisco.Name = "txtAsterisco";
            this.txtAsterisco.Size = new System.Drawing.Size(13, 17);
            this.txtAsterisco.TabIndex = 4;
            this.txtAsterisco.Text = "*";
            // 
            // txtInstrucciones
            // 
            this.txtInstrucciones.AutoSize = true;
            this.txtInstrucciones.Location = new System.Drawing.Point(252, 53);
            this.txtInstrucciones.Name = "txtInstrucciones";
            this.txtInstrucciones.Size = new System.Drawing.Size(457, 17);
            this.txtInstrucciones.TabIndex = 5;
            this.txtInstrucciones.Text = "Por favor ingresa dos números en binario para realizar la multiplicación";
            // 
            // lstBoxResult
            // 
            this.lstBoxResult.FormattingEnabled = true;
            this.lstBoxResult.ItemHeight = 16;
            this.lstBoxResult.Location = new System.Drawing.Point(215, 210);
            this.lstBoxResult.Name = "lstBoxResult";
            this.lstBoxResult.Size = new System.Drawing.Size(532, 356);
            this.lstBoxResult.TabIndex = 6;
            // 
            // bttn_Calcular
            // 
            this.bttn_Calcular.Location = new System.Drawing.Point(618, 109);
            this.bttn_Calcular.Name = "bttn_Calcular";
            this.bttn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.bttn_Calcular.TabIndex = 7;
            this.bttn_Calcular.Text = "Calcular";
            this.bttn_Calcular.UseVisualStyleBackColor = true;
            this.bttn_Calcular.Click += new System.EventHandler(this.Bttn_Calcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(753, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 601);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 598);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_Calcular);
            this.Controls.Add(this.lstBoxResult);
            this.Controls.Add(this.txtInstrucciones);
            this.Controls.Add(this.txtAsterisco);
            this.Controls.Add(this.txtMultiplicador);
            this.Controls.Add(this.txtMultiplicando);
            this.Controls.Add(this.txtbxMultiplicador);
            this.Controls.Add(this.txtbxMultiplicando);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxMultiplicando;
        private System.Windows.Forms.TextBox txtbxMultiplicador;
        private System.Windows.Forms.Label txtMultiplicando;
        private System.Windows.Forms.Label txtMultiplicador;
        private System.Windows.Forms.Label txtAsterisco;
        private System.Windows.Forms.Label txtInstrucciones;
        private System.Windows.Forms.ListBox lstBoxResult;
        private System.Windows.Forms.Button bttn_Calcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

