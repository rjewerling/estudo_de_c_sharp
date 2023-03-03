using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using TicketsControl.model;
using System.Text;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;

namespace TicketsControl.dao {

    public class TicketDao : DaoFactory {

        private const string SQL_LIST_ALL = "SELECT " +
            "t.id AS 'Id', " +
            "e.nome AS 'Nome do empregado', " +
            "t.quantidade AS 'Quantidade', " +
            "t.situacao AS 'Situação', " +
            "t.dataEntrega AS 'Data e hora da Entrega' " +
            "FROM ticket t " +
            "INNER JOIN empregado e ON t.idEmpregado = e.id " +
            "ORDER BY nome ASC;";

        private const string SQL_FIND_BY_NAME_OR_CPF = "SELECT " +
            "t.id AS 'Id', " +
            "e.nome AS 'Nome do empregado', " +
            "t.quantidade AS 'Quantidade', " +
            "t.situacao AS 'Situação', " +
            "t.dataEntrega AS 'Data e hora da Entrega' " +
            "FROM ticket t " +
            "INNER JOIN empregado e ON t.idEmpregado = e.id " +
            "WHERE e.nome LIKE @nome OR e.cpf LIKE @cpf " +
            "ORDER BY  e.nome ASC, t.dataEntrega ASC;";

        private const string SQL_FIND_BY_ID = "SELECT " +
            "t.id AS 'Id', " +
            "e.id AS 'Id do empregado', " +
            "t.quantidade AS 'Quantidade', " +
            "t.situacao AS 'Situação', " +
            "t.dataEntrega AS 'Data e hora da Entrega' " +
            "FROM ticket t " +
            "INNER JOIN empregado e ON t.idEmpregado = e.id " +
            "WHERE t.id = @id;";

        private const string SQL_INSERT = "INSERT INTO ticket(idEmpregado, quantidade, situacao, dataEntrega) " +
            "VALUES (@idEmpregado, @quantidade, @situacao, @dataEntrega)";

        private const string SQL_UPDATE = "UPDATE ticket SET " +
            "idEmpregado = @idEmpregado, " +
            "quantidade = @quantidade, " +
            "situacao = @situacao, " +
            "dataEntrega = @dataEntrega " +
            "WHERE id = @id;";

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

        public Ticket findById(int idTicket) {
            Ticket ticket = null;
            SqlConnection connection = null;
            try {
                connection = Connection();
                SqlCommand command = new SqlCommand(SQL_FIND_BY_ID, connection);
                command.Parameters.AddWithValue("@id", idTicket);

                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows) {
                    sqlDataReader.Read();
                    ticket = new Ticket();

                    ticket.Id = sqlDataReader.GetInt32(0);
                    ticket.Quantidade = sqlDataReader.GetInt32(2);
                    ticket.Situacao = String.Equals(sqlDataReader.GetString(3), "A");
                    ticket.DataEntrega = sqlDataReader.GetDateTime(4);

                    Empregado empregado = new EmpregadoDao().findById(sqlDataReader.GetInt32(1));
                    ticket.Empregado = empregado;
                }
                command.Dispose();
                sqlDataReader.Close();
            } catch (Exception e) {
                throw e;
            } finally {
                connection.Dispose();
            }
            return ticket;
        }

        public bool insert(Ticket ticket) {
            SqlConnection connection = null;
            try {
                connection = Connection();
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try {
                    SqlCommand command = new SqlCommand(SQL_INSERT, connection, transaction);

                    command.Parameters.AddWithValue("@idEmpregado", ticket.Empregado.Id);
                    command.Parameters.AddWithValue("@quantidade", ticket.Quantidade);
                    command.Parameters.AddWithValue("@dataEntrega", ticket.DataEntrega);
                    if (ticket.Situacao)
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

        public bool change(Ticket ticket) {
            SqlConnection connection = null;
            try {
                connection = Connection();
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try {
                    SqlCommand command = new SqlCommand(SQL_UPDATE, connection, transaction);

                    command.Parameters.AddWithValue("@idEmpregado", ticket.Empregado.Id);
                    command.Parameters.AddWithValue("@quantidade", ticket.Quantidade);
                    if (ticket.Situacao)
                        command.Parameters.AddWithValue("@situacao", "A");
                    else
                        command.Parameters.AddWithValue("@situacao", "I");
                    command.Parameters.AddWithValue("@dataEntrega", ticket.DataEntrega);
                    command.Parameters.AddWithValue("@id", ticket.Id);

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

        public DataTable find(Empregado empregado, int? qtdDe, int? qtdAte, char[] situacao, DateTime? dataDe, DateTime? dataAte) {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try {
                string sqlFind = "SELECT " +
                "t.id AS 'Id', " +
                "e.nome AS 'Nome do empregado', " +
                "e.cpf AS 'Cadastro de pessoa física', " +
                "t.quantidade AS 'Quantidade', " +
                "t.situacao AS 'Situação', " +
                "t.dataEntrega AS 'Data e hora da Entrega' " +
                "FROM ticket t " +
                "INNER JOIN empregado e ON t.idEmpregado = e.id ";

                connection = Connection();
                SqlCommand command = new SqlCommand(sqlFind, connection);

                if (empregado != null || situacao != null || qtdDe != null || qtdAte != null)
                    sqlFind = sqlFind + " WHERE ";

                if (empregado != null) {
                    sqlFind = sqlFind + "e.id = @idEmpregado";
                    command.Parameters.AddWithValue("@idEmpregado", empregado.Id);
                }

                if (situacao != null) {
                    if (empregado != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "t.situacao IN (@paramSituacao)";

                    var nomeDosParametros = new List<string>();
                    int indice = 0;
                    foreach (char valor in situacao) {
                        string parametroNome = "@paramSituacao" + indice;
                        command.Parameters.AddWithValue(parametroNome, valor);
                        nomeDosParametros.Add(parametroNome);
                        indice += 1;
                    }
                    sqlFind = sqlFind.Replace("@paramSituacao", string.Join(",", nomeDosParametros));
                }

                if (qtdDe != null && qtdAte == null) {
                    if (empregado != null || situacao != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "t.quantidade >= @qtdDe";
                    command.Parameters.AddWithValue("@qtdDe", qtdDe);
                }
                if (qtdDe == null && qtdAte != null) {
                    if (empregado != null || situacao != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "t.quantidade <= @qtdAte";
                    command.Parameters.AddWithValue("@qtdAte", qtdAte);
                }
                if (qtdDe != null && qtdAte != null) {
                    if (empregado != null || situacao != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "t.quantidade BETWEEN @qtdDe AND @qtdAte";
                    command.Parameters.AddWithValue("@qtdDe", qtdDe);
                    command.Parameters.AddWithValue("@qtdAte", qtdAte);
                }

                if (dataDe != null && dataAte == null) {
                    if (empregado != null || situacao != null || dataDe != null || dataAte != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "CONVERT(VARCHAR(10), t.dataEntrega, 103) >= @dataDe";
                    command.Parameters.AddWithValue("@dataDe", dataDe);
                }
                if (dataDe == null && dataAte != null) {
                    if (empregado != null || situacao != null || dataDe != null || dataAte != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "CONVERT(VARCHAR(10), t.dataEntrega, 103) <= @dataAte";
                    command.Parameters.AddWithValue("@dataAte", dataAte);
                }
                if (dataDe != null && dataAte != null) {
                    if (empregado != null || situacao != null || dataDe != null || dataAte != null)
                        sqlFind = sqlFind + " AND ";
                    sqlFind = sqlFind + "CONVERT(VARCHAR(10), t.dataEntrega, 103) BETWEEN @dataDe AND @dataAte";
                    command.Parameters.AddWithValue("@dataDe", dataDe);
                    command.Parameters.AddWithValue("@dataAte", dataAte);
                }

                command.CommandText = sqlFind + " ORDER BY e.nome ASC, t.dataEntrega ASC";
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
