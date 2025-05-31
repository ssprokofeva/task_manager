using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_manager
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _db = new AppDbContext();
        private Task _selectedTask;

        public Form1(ITaskService taskService)
        {
            ConfigureDataGridView();
            InitializeComponent();
            LoadTasks();
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Visible = false
            });
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "IsCompleted",
                HeaderText = "Выполнено",
                Width = 80
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Title",
                HeaderText = "Задача",
                Width = 300
            });
        }
        private void LoadTasks()
        {
            _db.Tasks.Load();
            dataGridView1.DataSource = _db.Tasks.Local.ToBindingList();
        }

        public Form1()
        {
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _selectedTask = dataGridView1.SelectedRows[0].DataBoundItem as Task;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                _db.Tasks.Add(new Task { Title = txtTask.Text });
                _db.SaveChanges();
                txtTask.Clear();
                LoadTasks();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedTask != null)
            {
                _db.Tasks.Remove(_selectedTask);
                _db.SaveChanges();
                LoadTasks();
            }
        }
    }
}
