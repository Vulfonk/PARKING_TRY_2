using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKING_TRY_2
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\1\source\repos\PARKING_TRY_2\PARKING_TRY_2\Database.accdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Сотрудники' table. You can move, or remove it, as needed.
            this.сотрудникиTableAdapter.Fill(this.databaseDataSet1.Сотрудники);
            // TODO: This line of code loads data into the 'databaseDataSet1.Запрос_Проходы_через_КПП' table. You can move, or remove it, as needed.
            this.запрос_Проходы_через_КППTableAdapter.Fill(this.databaseDataSet1.Запрос_Проходы_через_КПП);

        }

        private void addPassageToDb(bool isInput, int employerId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string inputOrOutput = isInput ? "Вход" : "Выход";
                var sql = "INSERT INTO [Проходы через КПП] ([Дата и Время], [Вход/Выход], [Сотрудник]) values("
                    + DateTime.Now.ToSqlString() + ","
                    + inputOrOutput.ToSqlString() + ","
                    + employerId + ")";

                connection.Open();
                var command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();


                BindingSource source2 = new BindingSource();
                source2.DataSource = databaseDataSet1;
                запросПроходыЧерезКППBindingSource.DataSource = source2;
                
                source2.ResetBindings(false);

                BindingSource source = new BindingSource();
                source.DataSource = запросПроходыЧерезКППBindingSource;
                passagesDataGridView.DataSource = source;

                source.ResetBindings(false);
                this.passagesDataGridView.Update();
                this.passagesDataGridView.Refresh();

            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (employeesComboBox.SelectedItem is DataRowView dataRow)
            {
                if(dataRow.Row is DatabaseDataSet1.СотрудникиRow employerRow)
                {
                    addPassageToDb(true, employerRow.Должность);
                }
            }
            this.passagesDataGridView.Update();
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {

            if (employeesComboBox.SelectedItem is DataRowView dataRow)
            {
                if (dataRow.Row is DatabaseDataSet1.СотрудникиRow employerRow)
                {
                    addPassageToDb(false, employerRow.Должность);
                }
            }
            this.passagesDataGridView.Update();
        }
    }
}

public static class StringExtension
{
    public static string ToSqlString(this object str)
    {
        return "'" + str.ToString() + "'";
    }
}
