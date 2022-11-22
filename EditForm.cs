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
    public partial class EditForm : Form
    {
        MainForm mainForm;
        public EditForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();
            EditDataGridView.ColumnCount = 7;
            EditDataGridView.Columns[0].Name = "id";
            EditDataGridView.Columns[1].Name = "Назва ресурсу";
            EditDataGridView.Columns[2].Name = "Анотація";
            EditDataGridView.Columns[3].Name = "Вид";
            EditDataGridView.Columns[4].Name = "Автор";
            EditDataGridView.Columns[5].Name = "Умови використання";
            EditDataGridView.Columns[6].Name = "Адреса";
            EditDataGridView.AllowUserToAddRows = false;
            foreach (ListComponent component in DataStorage.tableList)
            {
                EditDataGridView.Rows.Add(component.Id, component.Name, component.Anonation, component.Type, component.Author, component.UseConditions, component.Address);
            }
        }

        private void Edit()
        {
            try
            {
                List<ListComponent> list = new List<ListComponent>();
                bool canChange = true;
                for (int i = 0; i < EditDataGridView.Rows.Count; i++)
                {
                    ListComponent component = new ListComponent();
                    component.Id = Int32.Parse(EditDataGridView.Rows[i].Cells[0].Value.ToString());
                    if(component.Id<0) canChange = false;//перевірка id на невід'ємне число
                    component.Name = EditDataGridView.Rows[i].Cells[1].Value.ToString();
                    component.Anonation = EditDataGridView.Rows[i].Cells[2].Value.ToString();
                    component.Type = EditDataGridView.Rows[i].Cells[3].Value.ToString();
                    component.Author = EditDataGridView.Rows[i].Cells[4].Value.ToString();
                    component.UseConditions = EditDataGridView.Rows[i].Cells[5].Value.ToString();
                    component.Address = EditDataGridView.Rows[i].Cells[6].Value.ToString();
                    IEnumerable<ListComponent> tempList = list;
                    tempList = from comp in list//перевірка id на неповтюваність
                               where comp.Id == component.Id
                               select comp;
                    if (tempList.Any()) canChange = false;
                    list.Add(component);
                }
                if (canChange)
                {
                    DataStorage.tableList = list;
                    mainForm.RefreshTable();
                }
                else MessageBox.Show("Не вдалося змінити список, id поторюється або є від'ємним числом");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося змінити список, некоректно задане id");
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void EditDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
