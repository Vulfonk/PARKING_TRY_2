using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKING_TRY_2
{
    public class SqlOrmProvider
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\1\source\repos\PARKING_TRY_2\PARKING_TRY_2\Database.accdb";
        public void InsertPassage(Passage passage)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                var sqlSelect = $"SELECT FIRST (Код) AS id FROM Сотрудники WHERE [Полное имя] = '{passage.FullName}'";
                connection.Open();
                var commandSelect = new OleDbCommand(sqlSelect, connection);
                var reader = commandSelect.ExecuteReader();
                int id;
                while (reader.Read())
                {
                    id = (int)reader["id"];
                    var sql = $"INSERT INTO [Проходы через КПП] (Сотрудник, [Вход/Выход], [Дата и время]) VALUES(" +
                       $"{id}," +
                       $"'{InputStatusConverter.StatusToString(passage.InputStatus)}'," +
                       $"'{passage.DateTime}')";
                    var command = new OleDbCommand(sql, connection);
                    command.ExecuteNonQuery();
                    return;
                }
            }
        }

        public List<Passage> GetPassages()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                var sql = "SELECT * FROM [Запрос Проходы через КПП]";
                var passages = new List<Passage>();
                connection.Open();
                var command = new OleDbCommand(sql, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var input = InputStatusConverter.StringToStatus(reader["Вход/Выход"].ToString());
                    var name = reader["Полное Имя"].ToString();
                    var time = DateTime.Parse((reader["Дата и время"].ToString()));

                    var passage = new Passage()
                    {
                        InputStatus = input,
                        DateTime = time,
                        FullName = name,
                    };
                    passages.Add(passage);
                }

                return passages;
            }
        }

        internal List<Employer> GetEmployers()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                var sql = "SELECT * FROM Сотрудники";
                var employers = new List<Employer>();
                connection.Open();
                var command = new OleDbCommand(sql, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var name = reader["Полное Имя"].ToString();

                    var employer = new Employer()
                    {
                        FullName = name,
                    };
                    employers.Add(employer);
                }

                return employers;
            }
        }
    }
}
