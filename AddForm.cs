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
    public partial class AddForm : Form
    {
        MainForm mainForm;
        public AddForm(MainForm form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void RefreshTextBoxes()//чистимо всі тексбокси
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            AnotationTextBox.Clear();
            TypeTextBox.Clear();
            AuthorTextBox.Clear();
            UseConditionsTextBox.Clear();
            AddressTextBox.Clear();
        }
        private void AddComponent()//додаємо новий елемент
        {
            try
            {

                ListComponent listComponent = new ListComponent();
                listComponent.Id = Int32.Parse(IdTextBox.Text);
                if (listComponent.Id < 0) MessageBox.Show("id повинне бути невід'ємним числом");
                else
                {
                    listComponent.Name = NameTextBox.Text;
                    listComponent.Anonation = AnotationTextBox.Text;
                    listComponent.Type = TypeTextBox.Text;
                    listComponent.Author = AuthorTextBox.Text;
                    listComponent.UseConditions = UseConditionsTextBox.Text;
                    listComponent.Address = AddressTextBox.Text;
                    IEnumerable<ListComponent> tempList = DataStorage.tableList;
                    tempList = from comp in DataStorage.tableList
                               where comp.Id == listComponent.Id
                               select comp;
                    if (!tempList.Any())
                    {
                        DataStorage.tableList.Add(listComponent);
                        mainForm.RefreshTable();
                    }
                    else MessageBox.Show("Таке id вже існує");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RefreshTextBoxes();
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddComponent();
        }
    }
}
