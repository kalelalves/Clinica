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
    internal class FuncionarioController
    {

        public void listar()
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            DataTable lista = funcionarioDAO.all();
            Funcionarios funcionarios = new Funcionarios(lista);
            funcionarios.Show();
        }

        public void criar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionario = (Funcionario)funcionarioDAO.create(funcionario);
            this.alterar(funcionario);


        }
        public void alterar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
             FuncionariosEditar edicao = new FuncionariosEditar(funcionario);
            edicao.Show();
        }


        public void salvar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionarioDAO.update(funcionario);
            listar();

        }

        public void deletar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;

            FuncionarioDAO funcionarioDAO= new FuncionarioDAO();
            funcionarioDAO.delete(funcionario);
            listar();

        }

    }
}
