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
    internal class ConsultaDAO : IDAO
    {
        public DataTable all()
        {
            DataTable lista;
            try
            {
                string str = "select * from consultas;";
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
            {
                Consulta consulta = (Consulta)objeto;
                MySQLPersist banco = new MySQLPersist();

                try
                {

                    string sql = "INSERT INTO consultas" +
                         "(codm,codp,data,hora) " +
                         "VALUES(@codm,@codp,@data,@hora)";

                    List<MySqlParameter> parametros = new List<MySqlParameter>();
                    parametros.Add(new MySqlParameter("@codm", consulta.codm));
                    parametros.Add(new MySqlParameter("@codp", consulta.codp));
                    parametros.Add(new MySqlParameter("@data", consulta.data));
                    parametros.Add(new MySqlParameter("@hora", consulta.hora));


                    int id = Convert.ToInt32(banco.ExecuteNonQueryLastKey(sql, parametros));

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    throw ex;
                }
                return consulta;
            }

        }

        public void delete(object chave)
        {
            Consulta consulta = (Consulta)chave;
            MySQLPersist banco = new MySQLPersist();
            try
            {
                string sql = "delete from consultas " +
                     "where codm=@codm and codp =@codp";
                List<MySqlParameter> parametros = new List<MySqlParameter>();
                parametros.Add(new MySqlParameter("@codm", consulta.codm));
                parametros.Add(new MySqlParameter("@codp", consulta.codp));
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
            Consulta consulta = (Consulta)objeto;
            MySQLPersist banco = new MySQLPersist();

            try
            {
                string sql = "update consultas " +
                    "set codm=@codm," +
                    "codp=@codp," +
                    "hora=@hora," +
                    "data=@data," +
                    "where codm=@codm and codp=@codp";
                List<MySqlParameter> parametros = new List<MySqlParameter>();
                parametros.Add(new MySqlParameter("@codm", consulta.codm));
                parametros.Add(new MySqlParameter("@codp", consulta.codp));
                parametros.Add(new MySqlParameter("@data", consulta.data));
                parametros.Add(new MySqlParameter("@hora", consulta.hora));
          
                banco.ExecutaNonQuery(sql, parametros);

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            // return consulta;
        }
    }
}