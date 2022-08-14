namespace Clinica
{
    partial class Medicos
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
            this.listagem = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.criarmedBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editarBTn = new System.Windows.Forms.Button();
            this.codm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codm,
            this.nrao,
            this.Nome,
            this.idade,
            this.especialidade,
            this.CPF,
            this.cidade});
            this.listagem.Location = new System.Drawing.Point(12, 56);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(545, 251);
            this.listagem.TabIndex = 4;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.listBox1.Location = new System.Drawing.Point(33, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // criarmedBtn
            // 
            this.criarmedBtn.Location = new System.Drawing.Point(398, 364);
            this.criarmedBtn.Name = "criarmedBtn";
            this.criarmedBtn.Size = new System.Drawing.Size(75, 23);
            this.criarmedBtn.TabIndex = 14;
            this.criarmedBtn.Text = "Novo";
            this.criarmedBtn.UseVisualStyleBackColor = true;
            this.criarmedBtn.Click += new System.EventHandler(this.criarmedBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(200, 364);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Deletar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editarBTn
            // 
            this.editarBTn.Location = new System.Drawing.Point(33, 364);
            this.editarBTn.Name = "editarBTn";
            this.editarBTn.Size = new System.Drawing.Size(75, 23);
            this.editarBTn.TabIndex = 12;
            this.editarBTn.Text = "Editar";
            this.editarBTn.UseVisualStyleBackColor = true;
            this.editarBTn.Click += new System.EventHandler(this.editarBTn_Click);
            // 
            // codm
            // 
            this.codm.DataPropertyName = "codm";
            this.codm.HeaderText = "Codigo";
            this.codm.Name = "codm";
            // 
            // nrao
            // 
            this.nrao.DataPropertyName = "nrao";
            this.nrao.HeaderText = "Ambulatório";
            this.nrao.Name = "nrao";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "nome";
            this.Nome.Name = "Nome";
            // 
            // idade
            // 
            this.idade.DataPropertyName = "idade";
            this.idade.HeaderText = "Idade";
            this.idade.Name = "idade";
            // 
            // especialidade
            // 
            this.especialidade.DataPropertyName = "especialidade";
            this.especialidade.HeaderText = "Especialidade";
            this.especialidade.Name = "especialidade";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf";
            this.CPF.HeaderText = "cpf";
            this.CPF.Name = "CPF";
            this.CPF.Visible = false;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 399);
            this.Controls.Add(this.criarmedBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editarBTn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listagem);
            this.Name = "Medicos";
            this.Text = "Medicos";
            this.Load += new System.EventHandler(this.Medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button criarmedBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editarBTn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
    }
}