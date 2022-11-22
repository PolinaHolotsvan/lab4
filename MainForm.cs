using System.Text.Json;

namespace lab4
{
    public partial class MainForm : Form
    {
        string _filePath = "";
        string _jsonPath = "";
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "����� �������";
            dataGridView1.Columns[2].Name = "��������";
            dataGridView1.Columns[3].Name = "���";
            dataGridView1.Columns[4].Name = "�����";
            dataGridView1.Columns[5].Name = "����� ������������";
            dataGridView1.Columns[6].Name = "������";
            dataGridView1.AllowUserToAddRows=false;
        }
        
        private void OpenFile()//��������� ����
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "File|*.txt";
                openFileDialog.Title = "������ ����";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("�� �� ������ ����!");
                    return;
                }
                _filePath = openFileDialog.FileName;
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                Int32.TryParse(streamReader.ReadLine(), out int row);//������� ������� ��������
                List<ListComponent> tempList = new List<ListComponent>();
                for (int i = 0; i < row; i++)//������� ���������� ��� �������
                {
                    ListComponent component = new ListComponent();
                    component.Id = Int32.Parse(streamReader.ReadLine());
                    component.Name = streamReader.ReadLine();
                    component.Anonation = streamReader.ReadLine();
                    component.Type = streamReader.ReadLine();
                    component.Author = streamReader.ReadLine();
                    component.UseConditions = streamReader.ReadLine();
                    component.Address = streamReader.ReadLine();
                    tempList.Add(component);
                }
                DataStorage.tableList = tempList;
                RefreshTable();
                streamReader.Close();
            }
            catch (Exception ex) { MessageBox.Show("������� �� ��� �������� �����!"); }
        }
        private void OpenStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add()//��������� ����� ��� ��������� ��������
        {
            AddForm form2 = new AddForm(this);
            form2.ShowDialog();
        }
        private void AddComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        public void RefreshTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (ListComponent component in DataStorage.tableList)
            {
                dataGridView1.Rows.Add(component.Id, component.Name, component.Anonation, component.Type, component.Author, component.UseConditions, component.Address);
            }
        }

        private void Edit()//��������� ����� ��� ����������� ������
        {
            EditForm editForm = new EditForm(this);
            editForm.ShowDialog();
        }

        private void EditComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Help()//���������� ��� ��������
        {
            MessageBox.Show($"�������� ����� �-27 ������7 2022 ��{Environment.NewLine}" +
                $"��� �������� ���� �� ������ ������ �������� �� �� ��������. �� �� ������ �������� ����, ���� �� ����� �� ���� ������ ���� �� �����. ������ �����������, ��� ������� ����{Environment.NewLine}" +
                $"��� ������������ ���� �� ������ ������ ������������ �� �� ������������. �� �� ������ ������������ ����, ���� �� ����� �� ���� ������ ���� �� �����. ������ ��������������, ��� ��������������� �� ������� json-����{Environment.NewLine}"+ 
                $"��� �������� ��������, ������ �������� ����� �� �������� ��������{Environment.NewLine}"+
                $"��� ������ �������, ������ ������ �������, ������ ��������� ����������, �������� ������{Environment.NewLine}" +
                $"��� ���������� ������, ������ ���������� ������, ������� �������� �����������, �������� �������� ����{Environment.NewLine}" +
                $"��� �������� �����, ������ ��������� �������, �������� ���������, �������� �����, �������� �����. ������� �������� ����� �� ��������� ���������"); 
        }
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void Save()//��������
        {
            try
            {
                if (_filePath != "")
                {
                    FileStream fileStream = new FileStream(_filePath, FileMode.Open, FileAccess.Write);
                    Saving(fileStream);
                    fileStream.Close();
                }
                else MessageBox.Show("���� �� �� ���������!");
            }
            catch (Exception ex) { MessageBox.Show("������� �� ��� ����������!"); }
        }
        private void SaveAs()//�������� ��
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File|*.txt";
                saveFileDialog.Title = "Save as";
                saveFileDialog.ShowDialog();
                _filePath = saveFileDialog.FileName;

                if (_filePath != "")
                {
                    FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                    Saving(fileStream);
                    fileStream.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void Saving(FileStream fileStream) //����������
        {
            StreamWriter streamWriter = new StreamWriter(fileStream);
            SaveFile(streamWriter);
            streamWriter.Close();
        }
        private void SaveFile(StreamWriter streamWriter) //����� ���������� � ����
        {
            streamWriter.WriteLine(dataGridView1.RowCount);
            foreach(ListComponent component in DataStorage.tableList)
            {
                streamWriter.WriteLine(component.Id);
                streamWriter.WriteLine(component.Name);
                streamWriter.WriteLine(component.Anonation);
                streamWriter.WriteLine(component.Type);
                streamWriter.WriteLine(component.Author);
                streamWriter.WriteLine(component.UseConditions);
                streamWriter.WriteLine(component.Address);
            }

        }
        private void DeleteRow()
        {
            try
            {
                int delNum = dataGridView1.SelectedRows.Count;//������ ��������
                int delBegin;//� ����� ������� ��������
                if (dataGridView1.SelectedRows[0].Index > dataGridView1.SelectedRows[delNum - 1].Index)
                {
                    delBegin = dataGridView1.SelectedRows[delNum - 1].Index;
                }
                else { delBegin = dataGridView1.SelectedRows[0].Index; }
                DataStorage.tableList.RemoveRange(delBegin, delNum);
            }
            catch (Exception ex) { MessageBox.Show("������� �������"); }
            RefreshTable();
        }
        private void DeleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private async void SerializeAs()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File|*.json";
                saveFileDialog.Title = "Serialize as";
                saveFileDialog.ShowDialog();
                _jsonPath = saveFileDialog.FileName;
                using (FileStream fs = new FileStream(_jsonPath, FileMode.OpenOrCreate))
                {
                    await JsonSerializer.SerializeAsync<List<ListComponent>>(fs, DataStorage.tableList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� �� ��� ����������");
            }
        }
        private void SerializeAsToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {   
            SerializeAs();
        }

        private void Deserialize()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "File|*.json";
                openFileDialog.Title = "������ json-����";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("�� �� ������ ����!");
                    return;
                }
                _jsonPath = openFileDialog.FileName;
                string jsonString = File.ReadAllText(_jsonPath);
                MessageBox.Show(jsonString);
                DataStorage.tableList = JsonSerializer.Deserialize<List<ListComponent>>(jsonString);
                RefreshTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show("������� �� ��� ������������");
            }
        }
        private void DeserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deserialize();
        }

        private async void Serialize()
        {
            try
            {
                if (_jsonPath != "")
                {
                    using (FileStream fs = new FileStream(_jsonPath, FileMode.OpenOrCreate))
                    {
                        await JsonSerializer.SerializeAsync<List<ListComponent>>(fs, DataStorage.tableList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� �� ��� ����������");
            }
        }
        private void SerializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serialize();
        }
        private IEnumerable<ListComponent> SearchId(IEnumerable<ListComponent> list)
        {
            IEnumerable<ListComponent> tempList = list;
            tempList = from comp in list
                   where comp.Id == Int32.Parse(IdTextBox.Text)
                   select comp;
            return tempList;
        }

        private IEnumerable<ListComponent> SearchName(IEnumerable<ListComponent> list)
        {
            IEnumerable<ListComponent> tempList = list;
            tempList = from comp in list
                       where comp.Name.Contains(NameTextBox.Text)
                       select comp;
            return tempList;
        }

        private IEnumerable<ListComponent> SearchAnotation(IEnumerable<ListComponent> list)
        {
            IEnumerable<ListComponent> tempList = list;
            tempList = from comp in list
                       where comp.Anonation.Contains(AnotationTextBox.Text)
                       select comp;
            return tempList;
        }

        private IEnumerable<ListComponent> SearchType(IEnumerable<ListComponent> list)
        {
            IEnumerable<ListComponent> tempList = list;
            tempList = from comp in list
                       where comp.Type.Contains(TypeTextBox.Text)
                       select comp;
            return tempList;
        }

        private IEnumerable<ListComponent> SearchAuthor(IEnumerable<ListComponent> list)
        {
            IEnumerable<ListComponent> tempList = list;
            tempList = from comp in list
                       where comp.Author.Contains(AuthorTextBox.Text)
                       select comp;
            return tempList;
        }

        private IEnumerable<ListComponent> SearchUseConditions(IEnumerable<ListComponent> list)
        {
            IEnumerable<ListComponent> tempList = list;
            tempList = from comp in list
                       where comp.UseConditions.Contains(UseConditionsTextBox.Text)
                       select comp;
            return tempList;
        }

        private IEnumerable<ListComponent> SearchAddress(IEnumerable<ListComponent> list)
        {
            IEnumerable<ListComponent> tempList = list;
            tempList = from comp in list
                       where comp.Address.Contains(AddressTextBox.Text)
                       select comp;
            return tempList;
        }

        public void RefreshSearch() 
        {
            IdCheckBox.Checked = false;
            NameCheckBox.Checked = false;
            AnotationCheckBox.Checked = false;
            TypeCheckBox.Checked = false;
            AuthorCheckBox.Checked = false;
            UseConditionsCheckBox.Checked = false;
            AddressCheckBox.Checked = false;
            IdTextBox.Clear();
            NameTextBox.Clear();
            AnotationTextBox.Clear();
            AuthorTextBox.Clear();
            TypeTextBox.Clear();
            UseConditionsTextBox.Clear();
            AddressTextBox.Clear();
        }
        private void Search()
        {
            try
            {
                IEnumerable<ListComponent> list = DataStorage.tableList;
                if (IdCheckBox.Checked) list = SearchId(list);
                if (NameCheckBox.Checked) list = SearchName(list);
                if (AnotationCheckBox.Checked) list = SearchAnotation(list);
                if (TypeCheckBox.Checked) list = SearchType(list);
                if (AuthorCheckBox.Checked) list = SearchAuthor(list);
                if (UseConditionsCheckBox.Checked) list = SearchUseConditions(list);
                if (AddressCheckBox.Checked) list = SearchAddress(list);


                DataStorage.searchList = list.ToList();
                RefreshSearch();
                SearchForm searchForm = new SearchForm();
                searchForm.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("������� �� ��� ������"); }
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}