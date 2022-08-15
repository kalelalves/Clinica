namespace Clinica.View
{
    partial class ConsultasCriar
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
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.codpValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataValor = new System.Windows.Forms.TextBox();
            this.horaValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titulo_label = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codigoValor
            // 
            this.codigoValor.Location = new System.Drawing.Point(207, 131);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(223, 20);
            this.codigoValor.TabIndex = 35;
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(138, 134);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 34;
            this.codigo_label.Text = "Codigo:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // codpValor
            // 
            this.codpValor.Location = new System.Drawing.Point(207, 191);
            this.codpValor.Name = "codpValor";
            this.codpValor.Size = new System.Drawing.Size(223, 20);
            this.codpValor.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Codigo Paciente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataValor
            // 
            this.dataValor.Location = new System.Drawing.Point(207, 252);
            this.dataValor.Name = "dataValor";
            this.dataValor.Size = new System.Drawing.Size(223, 20);
            this.dataValor.TabIndex = 39;
            // 
            // horaValor
            // 
            this.horaValor.Location = new System.Drawing.Point(207, 311);
            this.horaValor.Name = "horaValor";
            this.horaValor.Size = new System.Drawing.Size(223, 20);
            this.horaValor.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Hora";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(203, 67);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(192, 24);
            this.titulo_label.TabIndex = 42;
            this.titulo_label.Text = "Criar nova Consulta";
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(355, 385);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 43;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-3, -1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 44;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ConsultasCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 433);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.horaValor);
            this.Controls.Add(this.dataValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codpValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigo_label);
            this.Name = "ConsultasCriar";
            this.Text = "ConsultasCriar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.TextBox codpValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataValor;
        private System.Windows.Forms.TextBox horaValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button button5;
    }
}