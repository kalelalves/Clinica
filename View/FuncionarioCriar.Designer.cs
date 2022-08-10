namespace Clinica.View
{
    partial class FuncionarioCriar
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
            this.salvar = new System.Windows.Forms.Button();
            this.titulo_label = new System.Windows.Forms.Label();
            this.salarioValor = new System.Windows.Forms.TextBox();
            this.salario_label = new System.Windows.Forms.Label();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.idade_label = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigo_label = new System.Windows.Forms.Label();
            this.cargoValor = new System.Windows.Forms.TextBox();
            this.cargo_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(321, 420);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 27;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // titulo_label
            // 
            this.titulo_label.AutoSize = true;
            this.titulo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_label.Location = new System.Drawing.Point(145, 19);
            this.titulo_label.Name = "titulo_label";
            this.titulo_label.Size = new System.Drawing.Size(224, 24);
            this.titulo_label.TabIndex = 26;
            this.titulo_label.Text = "Criar novo Funcionario";
            this.titulo_label.Click += new System.EventHandler(this.titulo_label_Click);
            // 
            // salarioValor
            // 
            this.salarioValor.Location = new System.Drawing.Point(173, 343);
            this.salarioValor.Name = "salarioValor";
            this.salarioValor.Size = new System.Drawing.Size(223, 20);
            this.salarioValor.TabIndex = 25;
            this.salarioValor.TextChanged += new System.EventHandler(this.doencaValor_TextChanged);
            // 
            // salario_label
            // 
            this.salario_label.AutoSize = true;
            this.salario_label.Location = new System.Drawing.Point(94, 350);
            this.salario_label.Name = "salario_label";
            this.salario_label.Size = new System.Drawing.Size(39, 13);
            this.salario_label.TabIndex = 24;
            this.salario_label.Text = "Salario";
            this.salario_label.Click += new System.EventHandler(this.doenca_label_Click);
            // 
            // cpfValor
            // 
            this.cpfValor.Location = new System.Drawing.Point(173, 170);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(223, 20);
            this.cpfValor.TabIndex = 23;
            this.cpfValor.TextChanged += new System.EventHandler(this.cpfValor_TextChanged);
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(94, 177);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(30, 13);
            this.cpf_label.TabIndex = 22;
            this.cpf_label.Text = "CPF:";
            this.cpf_label.Click += new System.EventHandler(this.cpf_label_Click);
            // 
            // cidadeValor
            // 
            this.cidadeValor.Location = new System.Drawing.Point(173, 258);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(223, 20);
            this.cidadeValor.TabIndex = 21;
            this.cidadeValor.TextChanged += new System.EventHandler(this.cidadeValor_TextChanged);
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Location = new System.Drawing.Point(94, 265);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(43, 13);
            this.cidade_label.TabIndex = 20;
            this.cidade_label.Text = "Cidade:";
            this.cidade_label.Click += new System.EventHandler(this.cidade_label_Click);
            // 
            // idadeValor
            // 
            this.idadeValor.Location = new System.Drawing.Point(173, 216);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(223, 20);
            this.idadeValor.TabIndex = 19;
            this.idadeValor.TextChanged += new System.EventHandler(this.idadeValor_TextChanged);
            // 
            // idade_label
            // 
            this.idade_label.AutoSize = true;
            this.idade_label.Location = new System.Drawing.Point(94, 223);
            this.idade_label.Name = "idade_label";
            this.idade_label.Size = new System.Drawing.Size(37, 13);
            this.idade_label.TabIndex = 18;
            this.idade_label.Text = "Idade:";
            this.idade_label.Click += new System.EventHandler(this.idade_label_Click);
            // 
            // nomeValor
            // 
            this.nomeValor.Location = new System.Drawing.Point(173, 129);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(223, 20);
            this.nomeValor.TabIndex = 17;
            this.nomeValor.TextChanged += new System.EventHandler(this.nomeValor_TextChanged);
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(94, 136);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(38, 13);
            this.nome_label.TabIndex = 16;
            this.nome_label.Text = "Nome:";
            this.nome_label.Click += new System.EventHandler(this.nome_label_Click);
            // 
            // codigoValor
            // 
            this.codigoValor.Location = new System.Drawing.Point(173, 84);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(223, 20);
            this.codigoValor.TabIndex = 15;
            this.codigoValor.TextChanged += new System.EventHandler(this.codigoValor_TextChanged);
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Location = new System.Drawing.Point(94, 91);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(43, 13);
            this.codigo_label.TabIndex = 14;
            this.codigo_label.Text = "Codigo:";
            this.codigo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.codigo_label.Click += new System.EventHandler(this.codigo_label_Click);
            // 
            // cargoValor
            // 
            this.cargoValor.Location = new System.Drawing.Point(173, 299);
            this.cargoValor.Name = "cargoValor";
            this.cargoValor.Size = new System.Drawing.Size(223, 20);
            this.cargoValor.TabIndex = 29;
            // 
            // cargo_label1
            // 
            this.cargo_label1.AutoSize = true;
            this.cargo_label1.Location = new System.Drawing.Point(94, 306);
            this.cargo_label1.Name = "cargo_label1";
            this.cargo_label1.Size = new System.Drawing.Size(35, 13);
            this.cargo_label1.TabIndex = 28;
            this.cargo_label1.Text = "Cargo";
            // 
            // FuncionarioCriar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 500);
            this.Controls.Add(this.cargoValor);
            this.Controls.Add(this.cargo_label1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.titulo_label);
            this.Controls.Add(this.salarioValor);
            this.Controls.Add(this.salario_label);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cidade_label);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.idade_label);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigo_label);
            this.Name = "FuncionarioCriar";
            this.Text = "FuncionarioCriar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label titulo_label;
        private System.Windows.Forms.TextBox salarioValor;
        private System.Windows.Forms.Label salario_label;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.Label cidade_label;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label idade_label;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.TextBox cargoValor;
        private System.Windows.Forms.Label cargo_label1;
    }
}