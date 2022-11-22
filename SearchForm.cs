using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class SearchForm : Form
    {
        
        public SearchForm()
        {
            
            InitializeComponent();
            SearchDataGridView.ColumnCount = 7;
            SearchDataGridView.Columns[0].Name = "id";
            SearchDataGridView.Columns[1].Name = "Назва ресурсу";
            SearchDataGridView.Columns[2].Name = "Анотація";
            SearchDataGridView.Columns[3].Name = "Вид";
            SearchDataGridView.Columns[4].Name = "Автор";
            SearchDataGridView.Columns[5].Name = "Умови використання";
            SearchDataGridView.Columns[6].Name = "Адреса";
            SearchDataGridView.AllowUserToAddRows = false;
            ShowResult();
        }

        private void ShowResult()
        {
            foreach (ListComponent component in DataStorage.searchList)
            {
                SearchDataGridView.Rows.Add(component.Id, component.Name, component.Anonation, component.Type, component.Author, component.UseConditions, component.Address);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
