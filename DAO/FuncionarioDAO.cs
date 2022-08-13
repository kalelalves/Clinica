using Clinica.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DAO
{
    internal class FuncionarioDAO : IDAO
    {
        public DataTable all()
        {
            DataTable lista;
            try
            {
                string str = "select * from funcionarios;";
                MySQLPersist banco = new MySQLPersist();
                lista = banco.ExecultaSlect(str);
            }
            catch
            {
                throw;
            }
            return lista;
        }

        public object create(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
            MySQLPersist banco = new MySQLPersist();

            try
            {

                string sql = "INSERT INTO funcionarios" +
                     "(nome,idade,cidade,cpf,cargo,salario) " +
                     "VALUES(@nome,@idade,@cidade,@cpf,@cargo,@salario)";

                List<MySqlParameter> parametros = new List<MySqlParameter>();
                parametros.Add(new MySqlParameter("@nome", funcionario.nome));
                parametros.Add(new MySqlParameter("@idade", funcionario.idade));
                parametros.Add(new MySqlParameter("@cidade", funcionario.cidade));
                parametros.Add(new MySqlParameter("@cpf", funcionario.cpf));
                parametros.Add(new MySqlParameter("@cargo", funcionario.cargo));
                parametros.Add(new MySqlParameter("@salario", funcionario.salario));

                int id = Convert.ToInt32(banco.ExecuteNonQueryLastKey(sql, parametros));
                funcionario.codf = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionario;
        }

        public void delete(object chave)
        {

            Funcionario funcionario = (Funcionario)chave;
            MySQLPersist banco = new MySQLPersist();
            try
            {
                string sql = "delete from funcionarios " +
                     "where codf=@codf";
                List<MySqlParameter> parametros = new List<MySqlParameter>();
                parametros.Add(new MySqlParameter("@codf", funcionario.codf));
                banco.ExecutaNonQuery(sql, parametros);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public void update(object objeto)
        {

        }

        }
    }

