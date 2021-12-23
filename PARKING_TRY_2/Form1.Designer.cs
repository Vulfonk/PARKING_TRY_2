
namespace PARKING_TRY_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.passagesDataGridView = new System.Windows.Forms.DataGridView();
            this.датаИВремяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.входВыходDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полноеИмяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.запросПроходыЧерезКППBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new PARKING_TRY_2.DatabaseDataSet1();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InputButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.employeesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.запрос_Проходы_через_КППTableAdapter = new PARKING_TRY_2.DatabaseDataSet1TableAdapters.Запрос_Проходы_через_КППTableAdapter();
            this.сотрудникиTableAdapter = new PARKING_TRY_2.DatabaseDataSet1TableAdapters.СотрудникиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.passagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запросПроходыЧерезКППBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // passagesDataGridView
            // 
            this.passagesDataGridView.AllowUserToAddRows = false;
            this.passagesDataGridView.AllowUserToDeleteRows = false;
            this.passagesDataGridView.AutoGenerateColumns = false;
            this.passagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаИВремяDataGridViewTextBoxColumn,
            this.входВыходDataGridViewTextBoxColumn,
            this.полноеИмяDataGridViewTextBoxColumn});
            this.passagesDataGridView.DataSource = this.запросПроходыЧерезКППBindingSource;
            this.passagesDataGridView.Location = new System.Drawing.Point(12, 72);
            this.passagesDataGridView.Name = "passagesDataGridView";
            this.passagesDataGridView.ReadOnly = true;
            this.passagesDataGridView.Size = new System.Drawing.Size(776, 366);
            this.passagesDataGridView.TabIndex = 0;
            // 
            // датаИВремяDataGridViewTextBoxColumn
            // 
            this.датаИВремяDataGridViewTextBoxColumn.DataPropertyName = "Дата и время";
            this.датаИВремяDataGridViewTextBoxColumn.HeaderText = "Дата и время";
            this.датаИВремяDataGridViewTextBoxColumn.Name = "датаИВремяDataGridViewTextBoxColumn";
            this.датаИВремяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // входВыходDataGridViewTextBoxColumn
            // 
            this.входВыходDataGridViewTextBoxColumn.DataPropertyName = "Вход/Выход";
            this.входВыходDataGridViewTextBoxColumn.HeaderText = "Вход/Выход";
            this.входВыходDataGridViewTextBoxColumn.Name = "входВыходDataGridViewTextBoxColumn";
            this.входВыходDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // полноеИмяDataGridViewTextBoxColumn
            // 
            this.полноеИмяDataGridViewTextBoxColumn.DataPropertyName = "Полное имя";
            this.полноеИмяDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.полноеИмяDataGridViewTextBoxColumn.Name = "полноеИмяDataGridViewTextBoxColumn";
            this.полноеИмяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // запросПроходыЧерезКППBindingSource
            // 
            this.запросПроходыЧерезКППBindingSource.DataMember = "Запрос Проходы через КПП";
            this.запросПроходыЧерезКППBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.databaseDataSet1;
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(360, 6);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 23);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "Вошел";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(441, 6);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(75, 23);
            this.OutputButton.TabIndex = 2;
            this.OutputButton.Text = "Вышел";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // employeesComboBox
            // 
            this.employeesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.employeesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.employeesComboBox.DataSource = this.сотрудникиBindingSource;
            this.employeesComboBox.DisplayMember = "Полное имя";
            this.employeesComboBox.FormattingEnabled = true;
            this.employeesComboBox.Location = new System.Drawing.Point(84, 6);
            this.employeesComboBox.Name = "employeesComboBox";
            this.employeesComboBox.Size = new System.Drawing.Size(270, 21);
            this.employeesComboBox.TabIndex = 3;
            this.employeesComboBox.ValueMember = "Код";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сотрудники";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Фильтры";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // запрос_Проходы_через_КППTableAdapter
            // 
            this.запрос_Проходы_через_КППTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesComboBox);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.passagesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запросПроходыЧерезКППBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView passagesDataGridView;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.ComboBox employeesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource запросПроходыЧерезКППBindingSource;
        private DatabaseDataSet1TableAdapters.Запрос_Проходы_через_КППTableAdapter запрос_Проходы_через_КППTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private DatabaseDataSet1TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИВремяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn входВыходDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеИмяDataGridViewTextBoxColumn;
    }
}

