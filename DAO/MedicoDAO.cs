using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DAO
{
    internal class MedicoDAO:IDAO
    {
        public DataTable all()
        {
            DataTable lista;
            try
            {
                string str = "select * from medicos;";
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
            Medico medico = (Medico)objeto;
            MySQLPersist banco = new MySQLPersist();

            try
            {

                string sql = "INSERT INTO medicos" +
                     "(nome,idade,cidade,cpf,especialidade) " +
                     "VALUES(@nome,@idade,@cidade,@cpf,@especialidade)";

                List<MySqlParameter> parametros = new List<MySqlParameter>();
                parametros.Add(new MySqlParameter("@nome", medico.nome));
                parametros.Add(new MySqlParameter("@idade", medico.idade));
                parametros.Add(new MySqlParameter("@cidade", medico.cidade));
                parametros.Add(new MySqlParameter("@cpf", medico.cpf));
                parametros.Add(new MySqlParameter("@especialidade", medico.especialidade));

                int id = Convert.ToInt32(banco.ExecuteNonQueryLastKey(sql, parametros));
                medico.codm = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medico;
        }

        public void delete(object chave)
        {
            throw new NotImplementedException();
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public void update(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
