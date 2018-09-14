using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
		

        //Колонки таблицы
        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;

        //Инициализация таблицы
        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.AutoResizeColumns();
        }
        //Динамическое создание первой колонки в таблице
        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Название";
                dataGridViewColumn1.ValueType = typeof(string);
                dataGridViewColumn1.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn1;
        }
        //Динамическое создание второй колонки в таблице
        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Цвет";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn2;
        }
        //Динамическое создание третей колонки в таблице
        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Цена";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn3;
        }

        //Колекция LinkedList
        private LinkedList<Furniture> furnitureList = new LinkedList<Furniture>();

        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }

        //Добавление студента в колекцию
        private void addFurniture(string name, string surname, string
        recordBookNumber)
        {
            Furniture s = new Furniture(name, surname, recordBookNumber);
            furnitureList.AddFirst(s);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";
            showListInGrid();
        }
        //Удаление студента с колекции
        private void deleteFurniture(int elementIndex)
        {
			Furniture eb = furnitureList.ElementAt(elementIndex);


		furnitureList.Remove(eb);
            showListInGrid();
        }

		private Furniture LinkedListNode(int elementIndex)
		{
			throw new NotImplementedException();
		}

		//Отображение колекции в таблице
		private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Furniture s in furnitureList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new
                DataGridViewTextBoxCell();
                cell1.ValueType = typeof(string);
                cell1.Value = s.getName();
                cell2.ValueType = typeof(string);
                cell2.Value = s.getColor();
                cell3.ValueType = typeof(string);
                cell3.Value = s.getPrice();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addFurniture(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Обработчик нажатия на удалить
        private void удалитьToolStripMenuItem_Click(object sender,EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Удалить мебель?", "",
            MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    deleteFurniture(selectedRow);
                }
                catch (Exception)
                {
                }
            }
        }

	
	}
}
