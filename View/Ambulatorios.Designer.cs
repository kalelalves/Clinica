namespace Clinica
{
    partial class Ambulatorios
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.nroa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.andar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Andar"});
            this.listBox1.Location = new System.Drawing.Point(29, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // filtroValor
            // 
            this.filtroValor.Location = new System.Drawing.Point(155, 27);
            this.filtroValor.Name = "filtroValor";
            this.filtroValor.Size = new System.Drawing.Size(100, 20);
            this.filtroValor.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroa,
            this.andar,
            this.capacidade});
            this.listagem.Location = new System.Drawing.Point(12, 54);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(459, 163);
            this.listagem.TabIndex = 9;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listagem_CellContentClick);
            // 
            // nroa
            // 
            this.nroa.HeaderText = "Codigo";
            this.nroa.Name = "nroa";
            this.nroa.Visible = false;
            // 
            // andar
            // 
            this.andar.HeaderText = "Andar";
            this.andar.Name = "andar";
            // 
            // capacidade
            // 
            this.capacidade.HeaderText = "Capacidade";
            this.capacidade.Name = "capacidade";
            // 
            // Ambulatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 271);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtroValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listagem);
            this.Name = "Ambulatorios";
            this.Text = "Ambulatorios";
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroa;
        private System.Windows.Forms.DataGridViewTextBoxColumn andar;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidade;
    }
}