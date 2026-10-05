namespace up02
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            headerPanel = new Panel();
            logoBox = new PictureBox();
            titleLabel = new Label();
            filterPanel = new Panel();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            typeLabel = new Label();
            typeComboBox = new ComboBox();
            sortLabel = new Label();
            sortComboBox = new ComboBox();
            countLabel = new Label();
            materialsPanel = new FlowLayoutPanel();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            filterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(171, 207, 206);
            headerPanel.Controls.Add(logoBox);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1100, 84);
            headerPanel.TabIndex = 2;
            // 
            // logoBox
            // 
            logoBox.Image = (Image)resources.GetObject("logoBox.Image");
            logoBox.Location = new Point(20, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(60, 60);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(96, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(324, 38);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Мозаика — материалы";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.White;
            filterPanel.Controls.Add(searchLabel);
            filterPanel.Controls.Add(searchTextBox);
            filterPanel.Controls.Add(typeLabel);
            filterPanel.Controls.Add(typeComboBox);
            filterPanel.Controls.Add(sortLabel);
            filterPanel.Controls.Add(sortComboBox);
            filterPanel.Controls.Add(countLabel);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 84);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1100, 92);
            filterPanel.TabIndex = 1;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(20, 12);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(53, 19);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Поиск";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(20, 40);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(260, 26);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += FilterChanged;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(300, 12);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(112, 19);
            typeLabel.TabIndex = 2;
            typeLabel.Text = "Тип материала";
            // 
            // typeComboBox
            // 
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.Location = new Point(300, 40);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(235, 26);
            typeComboBox.TabIndex = 3;
            typeComboBox.SelectedIndexChanged += FilterChanged;
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(555, 12);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(142, 19);
            sortLabel.TabIndex = 4;
            sortLabel.Text = "Сортировка по цене";
            // 
            // sortComboBox
            // 
            sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortComboBox.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            sortComboBox.Location = new Point(555, 40);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(205, 26);
            sortComboBox.TabIndex = 5;
            sortComboBox.SelectedIndexChanged += FilterChanged;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(790, 43);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(168, 19);
            countLabel.TabIndex = 6;
            countLabel.Text = "Найдено материалов: 0";
            // 
            // materialsPanel
            // 
            materialsPanel.AutoScroll = true;
            materialsPanel.BackColor = Color.White;
            materialsPanel.Dock = DockStyle.Fill;
            materialsPanel.FlowDirection = FlowDirection.TopDown;
            materialsPanel.Location = new Point(0, 176);
            materialsPanel.Name = "materialsPanel";
            materialsPanel.Padding = new Padding(16);
            materialsPanel.Size = new Size(1100, 544);
            materialsPanel.TabIndex = 0;
            materialsPanel.WrapContents = false;
            materialsPanel.Paint += materialsPanel_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 720);
            Controls.Add(materialsPanel);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(900, 600);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мозаика — учёт материалов";
            Load += Main_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private PictureBox logoBox;
        private Label titleLabel;
        private Panel filterPanel;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Label typeLabel;
        private ComboBox typeComboBox;
        private Label sortLabel;
        private ComboBox sortComboBox;
        private Label countLabel;
        private FlowLayoutPanel materialsPanel;
    }
}
