using Clinica.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Controller
{
    internal class MedicosController
    {

        public void listar()
        {
            MedicoDAO medicoDAO = new MedicoDAO();
            DataTable lista = medicoDAO.all();
            Medicos medicos = new Medicos(lista);
            medicos.Show();
        }

        public void criar(object objeto)
        {
            Medico medico = (Medico)objeto;
            MedicoDAO medicoDAO = new MedicoDAO();
            medico = (Medico)medicoDAO.create(medico);
            this.alterar(medico);
        }

        public void alterar(object objeto)
        {
            Medico medico = (Medico)objeto;
            MedicosEditarcs edicao = new MedicosEditarcs(medico);
            edicao.Show();
        }
    }
}


