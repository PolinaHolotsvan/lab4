namespace lab4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.даніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerializeAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerializeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCheckBox = new System.Windows.Forms.CheckBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.TypeCheckBox = new System.Windows.Forms.CheckBox();
            this.AnotationTextBox = new System.Windows.Forms.TextBox();
            this.AnotationCheckBox = new System.Windows.Forms.CheckBox();
            this.UseConditionsCheckBox = new System.Windows.Forms.CheckBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.AuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.UseConditionsTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.даніToolStripMenuItem,
            this.списокToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1167, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenStripMenuItem
            // 
            this.OpenStripMenuItem.Name = "OpenStripMenuItem";
            this.OpenStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.OpenStripMenuItem.Text = "Завантажити";
            this.OpenStripMenuItem.Click += new System.EventHandler(this.OpenStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.SaveToolStripMenuItem.Text = "Збегегти";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.SaveAsToolStripMenuItem.Text = "Зберегти як";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // даніToolStripMenuItem
            // 
            this.даніToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.даніToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerializeAsToolStripMenuItem,
            this.DeserializeToolStripMenuItem,
            this.SerializeToolStripMenuItem1});
            this.даніToolStripMenuItem.Name = "даніToolStripMenuItem";
            this.даніToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.даніToolStripMenuItem.Text = "Дані";
            // 
            // SerializeAsToolStripMenuItem
            // 
            this.SerializeAsToolStripMenuItem.Name = "SerializeAsToolStripMenuItem";
            this.SerializeAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SerializeAsToolStripMenuItem.Text = "Серіалізувати як";
            this.SerializeAsToolStripMenuItem.Click += new System.EventHandler(this.SerializeAsToolStripMenuItem_ClickAsync);
            // 
            // DeserializeToolStripMenuItem
            // 
            this.DeserializeToolStripMenuItem.Name = "DeserializeToolStripMenuItem";
            this.DeserializeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DeserializeToolStripMenuItem.Text = "Десеріалазувати";
            this.DeserializeToolStripMenuItem.Click += new System.EventHandler(this.DeserializeToolStripMenuItem_Click);
            // 
            // SerializeToolStripMenuItem1
            // 
            this.SerializeToolStripMenuItem1.Name = "SerializeToolStripMenuItem1";
            this.SerializeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.SerializeToolStripMenuItem1.Text = "Серіалізувати";
            this.SerializeToolStripMenuItem1.Click += new System.EventHandler(this.SerializeToolStripMenuItem_Click);
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.списокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.AddComponentToolStripMenuItem,
            this.EditComponentToolStripMenuItem});
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.списокToolStripMenuItem.Text = "Список";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.DeleteToolStripMenuItem.Text = "Видалити елемент";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteRowToolStripMenuItem_Click);
            // 
            // AddComponentToolStripMenuItem
            // 
            this.AddComponentToolStripMenuItem.Name = "AddComponentToolStripMenuItem";
            this.AddComponentToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.AddComponentToolStripMenuItem.Text = "Додати елемент";
            this.AddComponentToolStripMenuItem.Click += new System.EventHandler(this.AddComponentToolStripMenuItem_Click);
            // 
            // EditComponentToolStripMenuItem
            // 
            this.EditComponentToolStripMenuItem.Name = "EditComponentToolStripMenuItem";
            this.EditComponentToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.EditComponentToolStripMenuItem.Text = "Редагувати список";
            this.EditComponentToolStripMenuItem.Click += new System.EventHandler(this.EditComponentToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.HelpToolStripMenuItem.Text = "Про програму";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(587, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(568, 686);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdCheckBox
            // 
            this.IdCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdCheckBox.AutoSize = true;
            this.IdCheckBox.Location = new System.Drawing.Point(17, 38);
            this.IdCheckBox.Name = "IdCheckBox";
            this.IdCheckBox.Size = new System.Drawing.Size(44, 24);
            this.IdCheckBox.TabIndex = 4;
            this.IdCheckBox.Text = "id";
            this.IdCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(261, 38);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(294, 27);
            this.IdTextBox.TabIndex = 5;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(12, 134);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(131, 24);
            this.NameCheckBox.TabIndex = 6;
            this.NameCheckBox.Text = "Назва ресурсу";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // TypeCheckBox
            // 
            this.TypeCheckBox.AutoSize = true;
            this.TypeCheckBox.Location = new System.Drawing.Point(17, 332);
            this.TypeCheckBox.Name = "TypeCheckBox";
            this.TypeCheckBox.Size = new System.Drawing.Size(57, 24);
            this.TypeCheckBox.TabIndex = 9;
            this.TypeCheckBox.Text = "Вид";
            this.TypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnotationTextBox
            // 
            this.AnotationTextBox.Location = new System.Drawing.Point(261, 230);
            this.AnotationTextBox.Name = "AnotationTextBox";
            this.AnotationTextBox.Size = new System.Drawing.Size(294, 27);
            this.AnotationTextBox.TabIndex = 8;
            // 
            // AnotationCheckBox
            // 
            this.AnotationCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnotationCheckBox.AutoSize = true;
            this.AnotationCheckBox.Location = new System.Drawing.Point(17, 230);
            this.AnotationCheckBox.Name = "AnotationCheckBox";
            this.AnotationCheckBox.Size = new System.Drawing.Size(94, 24);
            this.AnotationCheckBox.TabIndex = 7;
            this.AnotationCheckBox.Text = "Анотація";
            this.AnotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseConditionsCheckBox
            // 
            this.UseConditionsCheckBox.AutoSize = true;
            this.UseConditionsCheckBox.Location = new System.Drawing.Point(17, 542);
            this.UseConditionsCheckBox.Name = "UseConditionsCheckBox";
            this.UseConditionsCheckBox.Size = new System.Drawing.Size(179, 24);
            this.UseConditionsCheckBox.TabIndex = 12;
            this.UseConditionsCheckBox.Text = "Умови використання";
            this.UseConditionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(261, 438);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(294, 27);
            this.AuthorTextBox.TabIndex = 11;
            // 
            // AuthorCheckBox
            // 
            this.AuthorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorCheckBox.AutoSize = true;
            this.AuthorCheckBox.Location = new System.Drawing.Point(17, 438);
            this.AuthorCheckBox.Name = "AuthorCheckBox";
            this.AuthorCheckBox.Size = new System.Drawing.Size(73, 24);
            this.AuthorCheckBox.TabIndex = 10;
            this.AuthorCheckBox.Text = "Автор";
            this.AuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(261, 134);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(294, 27);
            this.NameTextBox.TabIndex = 13;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBtn.Location = new System.Drawing.Point(12, 688);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 29);
            this.SearchBtn.TabIndex = 14;
            this.SearchBtn.Text = "Пошук";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(261, 332);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(294, 27);
            this.TypeTextBox.TabIndex = 15;
            // 
            // UseConditionsTextBox
            // 
            this.UseConditionsTextBox.Location = new System.Drawing.Point(261, 542);
            this.UseConditionsTextBox.Name = "UseConditionsTextBox";
            this.UseConditionsTextBox.Size = new System.Drawing.Size(294, 27);
            this.UseConditionsTextBox.TabIndex = 16;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddressTextBox.Location = new System.Drawing.Point(261, 648);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(294, 27);
            this.AddressTextBox.TabIndex = 18;
            // 
            // AddressCheckBox
            // 
            this.AddressCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddressCheckBox.AutoSize = true;
            this.AddressCheckBox.Location = new System.Drawing.Point(17, 648);
            this.AddressCheckBox.Name = "AddressCheckBox";
            this.AddressCheckBox.Size = new System.Drawing.Size(81, 24);
            this.AddressCheckBox.TabIndex = 17;
            this.AddressCheckBox.Text = "Адреса";
            this.AddressCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1167, 729);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressCheckBox);
            this.Controls.Add(this.UseConditionsTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UseConditionsCheckBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.AuthorCheckBox);
            this.Controls.Add(this.TypeCheckBox);
            this.Controls.Add(this.AnotationTextBox);
            this.Controls.Add(this.AnotationCheckBox);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem OpenStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private CheckBox IdCheckBox;
        private TextBox IdTextBox;
        private CheckBox NameCheckBox;
        private CheckBox TypeCheckBox;
        private TextBox AnotationTextBox;
        private CheckBox AnotationCheckBox;
        private CheckBox UseConditionsCheckBox;
        private TextBox AuthorTextBox;
        private CheckBox AuthorCheckBox;
        private TextBox NameTextBox;
        private Button SearchBtn;
        private TextBox TypeTextBox;
        private TextBox UseConditionsTextBox;
        private TextBox AddressTextBox;
        private CheckBox AddressCheckBox;
        private ToolStripMenuItem даніToolStripMenuItem;
        private ToolStripMenuItem SerializeAsToolStripMenuItem;
        private ToolStripMenuItem DeserializeToolStripMenuItem;
        private ToolStripMenuItem списокToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem AddComponentToolStripMenuItem;
        private ToolStripMenuItem EditComponentToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem HelpToolStripMenuItem;
        private ToolStripMenuItem SerializeToolStripMenuItem1;
    }
}