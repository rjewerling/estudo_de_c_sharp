using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using TicketsControl.model;
using System.Text;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TicketsControl.dao {
    public class EmpregadoDao : DaoFactory {

        private const string SQL_LIST_ALL = "SELECT " +
            "e.id AS 'Id', " +
            "e.nome AS 'Nome completo', " +
            "e.cpf AS 'Cadastro de pessoa física', " +
            "e.situacao AS 'Situação', " +
            "e.ultimaAlteracao AS 'Data da última alteração' " +
            "FROM empregado e " +
            "ORDER BY e.nome ASC;";
        private const string SQL_FIND_BY_ID = "SELECT * FROM empregado WHERE id = @id";
        private const string SQL_FIND_BY_CPF = "SELECT * FROM empregado WHERE cpf = @cpf";
        private const string SQL_INSERT = "INSERT INTO empregado(nome, cpf, situacao) VALUES (@nome, @cpf, @situacao)";
        private const string SQL_UPDATE = "UPDATE empregado SET nome = @nome, cpf = @cpf, situacao = @situacao," +
            "ultimaAlteracao = @dataUltimaAlteracao WHERE id = @id";
        private const string SQL_FIND_BY_NAME_OR_CPF = "SELECT " +
            "e.id AS 'Id', " +
            "e.nome AS 'Nome completo', " +
            "e.cpf AS 'Cadastro de pessoa física', " +
            "e.situacao AS 'Situação', " +
            "e.ultimaAlteracao AS 'Data da última alteração' " +
            "FROM empregado e " +
            "WHERE e.nome LIKE @nome OR e.cpf LIKE @cpf ORDER BY e.nome ASC";

        public bool insert(Empregado empregado) {
            SqlConnection connection = null;
            try {
                connection = Connection();
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try {
                    SqlCommand command = new SqlCommand(SQL_INSERT, connection, transaction);

                    command.Parameters.AddWithValue("@nome", empregado.Nome());
                    command.Parameters.AddWithValue("@cpf", empregado.Cpf);
                    if (empregado.Situacao)
                        command.Parameters.AddWithValue("@situacao", "A");
                    else
                        command.Parameters.AddWithValue("@situacao", "I");

                    command.ExecuteNonQuery();
                    command.Dispose();
                    transaction.Commit();
                    return true;
                } catch (Exception e) {
                    transaction.Rollback();
                    throw e;
                }
            } catch (Exception e) {
                throw e;
            } finally {
                connection.Dispose();
            }
        }

        public bool change(Empregado empregado) {
            SqlConnection connection = null;
            try {
                connection = Connection();
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try {
                    SqlCommand command = new SqlCommand(SQL_UPDATE, connection, transaction);

                    command.Parameters.AddWithValue("@nome", empregado.Nome());
                    command.Parameters.AddWithValue("@cpf", empregado.Cpf);
                    if (empregado.Situacao)
                        command.Parameters.AddWithValue("@situacao", "A");
                    else
                        command.Parameters.AddWithValue("@situacao", "I");
                    command.Parameters.AddWithValue("@dataUltimaAlteracao", empregado.DataUltimaAlteracao);
                    command.Parameters.AddWithValue("@id", empregado.Id);

                    command.ExecuteNonQuery();
                    command.Dispose();
                    transaction.Commit();
                    return true;
                } catch (Exception e) {
                    transaction.Rollback();
                    throw e;
                }
            } catch (Exception e) {
                throw e;
            } finally {
                connection.Dispose();
            }
        }

        public void remove(Empregado empregado) {
            throw new NotImplementedException();
        }

        public Empregado findById(int id) {
            Empregado empregado = null;
            SqlConnection connection = null;
            try {
                connection = Connection();
                SqlCommand command = new SqlCommand(SQL_FIND_BY_ID, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows) {
                    sqlDataReader.Read();
                    empregado = new Empregado();
                    empregado.Id = sqlDataReader.GetInt32(0);
                    empregado.Nome(sqlDataReader.GetString(1));
                    empregado.Cpf = sqlDataReader.GetString(2);
                    empregado.Situacao = String.Equals(sqlDataReader.GetString(3), "A");
                    if (!sqlDataReader.IsDBNull(4)) {
                        empregado.DataUltimaAlteracao = sqlDataReader.GetDateTime(4);
                    }
                }
                command.Dispose();
                sqlDataReader.Close();
            } catch (Exception e) {
                throw e;
            } finally {
                connection.Dispose();
            }
            return empregado;
        }

        public DataTable list() {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try {
                connection = Connection();
                SqlCommand command = new SqlCommand(SQL_LIST_ALL, connection);
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataTable);
                command.Dispose();
                sqlDataAdapter.Dispose();
            } catch (Exception e) {
                throw e;
            } finally {
                connection.Close();
            }
            return dataTable;
        }

        public Empregado findByCpf(string cpf) {
            Empregado empregado = null;
            SqlConnection connection = null;
            try {
                connection = Connection();
                SqlCommand command = new SqlCommand(SQL_FIND_BY_CPF, connection);
                command.Parameters.AddWithValue("@cpf", cpf);

                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows) {
                    sqlDataReader.Read();
                    empregado = new Empregado();
                    empregado.Id = sqlDataReader.GetInt32(0);
                    empregado.Nome(sqlDataReader.GetString(1));
                    empregado.Cpf = sqlDataReader.GetString(2);
                    empregado.Situacao = String.Equals(sqlDataReader.GetString(3), "A");
                    if (!sqlDataReader.IsDBNull(4)) {
                        empregado.DataUltimaAlteracao = sqlDataReader.GetDateTime(4);
                    }
                }
                command.Dispose();
                sqlDataReader.Close();
            } catch(Exception e) {
                throw e;
            } finally {
                connection.Dispose();
            }
            return empregado;
        }

        public DataTable find(string dado) {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try {
                connection = Connection();
                SqlCommand command = new SqlCommand(SQL_FIND_BY_NAME_OR_CPF, connection);
                command.Parameters.AddWithValue("@nome", "%" + dado + "%");
                command.Parameters.AddWithValue("@cpf", "%" + dado + "%");

                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataTable);
                command.Dispose();
                sqlDataAdapter.Dispose();
            } catch (Exception e) {
                throw e;
            } finally {
                connection.Close();
            }
            return dataTable;

        }

        public int countEmpregadosAtivos() {
            int count = 0;
            SqlConnection connection = null;
            try {
                connection = Connection();
                SqlCommand command = new SqlCommand("SELECT COUNT(cpf) FROM empregado WHERE situacao = @situacao", connection);
                command.Parameters.AddWithValue("@situacao", "A");

                connection.Open();
                object result = command.ExecuteScalar();
                count = result != null ? Convert.ToInt32(result) : 0;
                command.Dispose();
            } catch (Exception e) {
                throw e;
            } finally {
                connection.Close();
            }
            return count;
        }

        public DataTable find(string nome, string cpf, char[] situacao, DateTime? dataDe, DateTime? dataAte) {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try {
                string sqlFind = "SELECT " +
                "e.id AS 'Id', " +
                "e.nome AS 'Nome completo', " +
                "e.cpf AS 'Cadastro de pessoa física', " +
                "e.situacao AS 'Situação', " +
                "e.ultimaAlteracao AS 'Data da última alteração' " +
                "FROM empregado e";

                connection = Connection();
                SqlCommand command = new SqlCommand(sqlFind, connection);

                if (nome != null || cpf != null || situacao != null || dataDe != null || dataAte != null)
                    sqlFind = sqlFind + " WHERE ";

                if (nome != null) {
                    sqlFind = sqlFind + "e.nome LIKE @nome";
                    command.Parameters.AddWithValue("@nome", "%"+nome+"%");
                }
                if (cpf != null) {
                    if(nome != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "e.cpf LIKE @cpf";
                    command.Parameters.AddWithValue("@cpf", "%" + cpf + "%");
                }

                if (situacao != null) {
                    if (nome != null || cpf != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "e.situacao IN (@paramSituacao)";

                    var nomeDosParametros = new List<string>();
                    int indice = 0;
                    foreach (char valor in situacao) {
                        string parametroNome = "@paramSituacao" + indice;
                        command.Parameters.AddWithValue(parametroNome, valor);
                        nomeDosParametros.Add(parametroNome);
                        indice +=1;
                    }
                    sqlFind = sqlFind.Replace("@paramSituacao", string.Join(",", nomeDosParametros));
                }

                if (dataDe != null && dataAte == null) {
                    if (nome != null || cpf != null || situacao != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "CONVERT(VARCHAR(10), ultimaAlteracao, 103) >= @dataDe";
                    command.Parameters.AddWithValue("@dataDe", dataDe);
                }
                if (dataDe == null && dataAte != null) {
                    if (nome != null || cpf != null || situacao != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "CONVERT(VARCHAR(10), ultimaAlteracao, 103) <= @dataAte";
                    command.Parameters.AddWithValue("@dataAte", dataAte);
                }
                if (dataDe != null && dataAte != null) {
                    if (nome != null || cpf != null || situacao != null)
                            sqlFind = sqlFind + " AND ";
                        sqlFind = sqlFind + "CONVERT(VARCHAR(10), ultimaAlteracao, 103) BETWEEN @dataDe AND @dataAte";
                        command.Parameters.AddWithValue("@dataDe", dataDe);
                        command.Parameters.AddWithValue("@dataAte", dataAte);
                }

                command.CommandText = sqlFind + " ORDER BY e.nome ASC";
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataTable);
                command.Dispose();
                sqlDataAdapter.Dispose();
            } catch (Exception e) {
                throw e;
            } finally {
                connection.Close();
            }
            return dataTable;
        }
    }
}
