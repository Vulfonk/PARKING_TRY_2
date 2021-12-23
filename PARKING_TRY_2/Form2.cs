using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKING_TRY_2
{
    public partial class Form2 : Form
    {
        public List<Employer> EmployersList;
        public SqlOrmProvider SqlProvider;

        public Form1 Form1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.EmployersList = SqlProvider.GetEmployers();
            this.comboBox1.DataSource = this.EmployersList.Select(c => c.FullName).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filter = new Filter();
            if (DateTime.TryParse(this.maskedTextBox1.Text, out DateTime withDate))
            {
                filter.WithDate = withDate;
            }

            if (DateTime.TryParse(this.maskedTextBox3.Text, out DateTime toDate))
            {
                filter.ToDate = toDate;
            }
            
            if (DateTime.TryParse(this.maskedTextBox2.Text, out DateTime withTime))
            {
                filter.WithTime = withTime;
            }

            if (DateTime.TryParse(this.maskedTextBox4.Text, out DateTime toTime))
            {
                filter.ToTime = toTime;
            }

            filter.employerName = comboBox1.SelectedItem?.ToString() ?? string.Empty;

            if(comboBox2.Text != string.Empty)
            {
                filter.inputStatus = InputStatusConverter.StringToStatus(comboBox2.Text);
            }
            else
            {
                filter.inputStatus = null;
            }

            Form1.AcceptFilter(filter);
        }
    }
}
