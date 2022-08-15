using Clinica.DAO;
using Clinica.Models;
using Clinica.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Controller
{
    internal class ConsultaController
    {
        public void listar()
        {
            ConsultaDAO consultaDAO = new ConsultaDAO();
            DataTable lista = consultaDAO.all();
            Consultas consulta = new Consultas(lista);
            consulta.Show();
        }

        public void criar(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            ConsultaDAO consultaDAO = new ConsultaDAO();
            consulta = (Consulta)consultaDAO.create(consulta);
            this.alterar(consulta);
        }

        public void alterar(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            ConsultasEditar editar = new ConsultasEditar(consulta);
            editar.Show();


        }
        public void salvar(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            ConsultaDAO consultaDAO = new ConsultaDAO();
            consultaDAO.update(consulta);
            listar();
        }

        public void deletar(object objeto)
        { 
            Consulta consulta= (Consulta)objeto;
            ConsultaDAO consultaDAO =new ConsultaDAO();
            consultaDAO.delete(consulta);
            listar();

             
        }

    }
}
