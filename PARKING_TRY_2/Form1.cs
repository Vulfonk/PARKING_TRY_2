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
        List<Passage> passagesList;
        List<Employer> employersList;
        SqlOrmProvider sqlProvider;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlProvider = new SqlOrmProvider();

            this.updatePassages();

            passagesDataGridView.Columns[0].HeaderText = "Дата и время";
            passagesDataGridView.Columns[1].HeaderText = "Полное имя";
            passagesDataGridView.Columns[2].HeaderText = "Вход/Выход";

            this.employersList = sqlProvider.GetEmployers();
            this.employeesComboBox.DataSource = this.employersList.Select(c => c.FullName).ToList();

            this.employeesComboBox.Update();
            this.employeesComboBox.Refresh();


        }

        public void AcceptFilter(Filter filter)
        {
            this.passagesList = sqlProvider.GetPassages();

            this.passagesList = filter.Accept(this.passagesList);

            this.passagesDataGridView.DataSource = passagesList.Select(
                c => new { c.DateTime, c.FullName, V = InputStatusConverter.StatusToString(c.InputStatus) }).ToList();
            this.passagesDataGridView.Update();
            this.passagesDataGridView.Refresh();
        }

        private void updatePassages()
        {
            this.passagesList = sqlProvider.GetPassages();

            this.passagesDataGridView.DataSource = passagesList.Select(
                c => new { c.DateTime, c.FullName, V = InputStatusConverter.StatusToString(c.InputStatus) }).ToList();
            this.passagesDataGridView.Update();
            this.passagesDataGridView.Refresh();
        }

        private void addPassageToDb(bool isInput)
        {
            var status = isInput ? InputStatus.Input : InputStatus.Output;
            var passage = new Passage()
            {
                DateTime = DateTime.Now,
                InputStatus = status,
                FullName = employeesComboBox.Text,
            };

            try
            {
                sqlProvider.InsertPassage(passage);
            }
            catch
            {
                MessageBox.Show($"Имя {passage.FullName} не найдено в базе данных.\nПроверьте корректность введенных данных.");
            }

            this.updatePassages();

        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            addPassageToDb(true);
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            addPassageToDb(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employeesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.EmployersList = this.employersList;
            form2.SqlProvider = this.sqlProvider;
            form2.Form1 = this;
            form2.Show();
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
