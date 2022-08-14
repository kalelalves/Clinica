using Clinica.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class MedicosCriar : Form
    {
        public MedicosCriar()
        {
            InitializeComponent();
        }

        private void titulo_label_Click(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            //medico.Ambulatorio.nroa = int.Parse( this.codigoAValor.Text);
            //medico.codm = int.Parse(this.codmValor.Text);
            medico.nome = this.nomeValor.Text;
            medico.idade = int.Parse(this.idadeValor.Text);
            medico.cidade = this.cidadeValor.Text;
            medico.cpf = this.cpfValor.Text;
            medico.especialidade = this.especialidadeValor.Text;

            MedicosController controller = new MedicosController();
            controller.criar(medico);
       
            this.Close();
        }

        private void doencaValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void doenca_label_Click(object sender, EventArgs e)
        {

        }

        private void cpfValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpf_label_Click(object sender, EventArgs e)
        {

        }

        private void cidadeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidade_label_Click(object sender, EventArgs e)
        {

        }

        private void idadeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void idade_label_Click(object sender, EventArgs e)
        {

        }

        private void nomeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_label_Click(object sender, EventArgs e)
        {

        }

        private void codigoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigo_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void codmValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
