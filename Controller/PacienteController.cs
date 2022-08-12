using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class PacienteController
    {
        public void listar()
        {
            PacienteDAO pacientesDAO = new PacienteDAO();
            DataTable lista = pacientesDAO.all();
            Pacientes pacientes = new Pacientes(lista);
            pacientes.Show();
        }
        public void criar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            PacienteDAO pacienteDAO = new PacienteDAO();
            paciente = (Paciente)pacienteDAO.create(paciente);
            this.alterar(paciente);

        }


        public void alterar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            PacientesEditar edicao = new PacientesEditar(paciente);
            edicao.Show();
        }
        public void salvar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            PacienteDAO pacienteDAO = new PacienteDAO();
            pacienteDAO.update(paciente);

             listar();

        }
        internal void deletar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;

            PacienteDAO pacienteDAO = new PacienteDAO();
            pacienteDAO.delete(paciente);
            listar();
        }

        }
    }
