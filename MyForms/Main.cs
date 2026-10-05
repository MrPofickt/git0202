using up02.MyClass;
using System.Data;

namespace up02
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object? sender, EventArgs e)
        {
            if (!DBConnection.ConnectDB())
            {
                Close();
                return;
            }

            DataTable types = MyProd.GetMaterialTypes();
            DataRow allTypes = types.NewRow();
            allTypes["КодТипа"] = 0;
            allTypes["ТипМатериала"] = "Все типы";
            types.Rows.InsertAt(allTypes, 0);

            typeComboBox.DataSource = types;
            typeComboBox.DisplayMember = "ТипМатериала";
            typeComboBox.ValueMember = "КодТипа";
            sortComboBox.SelectedIndex = 0;
            RefreshMaterials();
        }

        private void FilterChanged(object? sender, EventArgs e)
        {
            if (IsHandleCreated && DBConnection.myCommand != null)
                RefreshMaterials();
        }

        private void RefreshMaterials()
        {

            int? typeId = typeComboBox.SelectedValue is int value && value > 0 ? value : null;
            MyProd.ShowMaterials(materialsPanel, searchTextBox.Text, typeId, sortComboBox.SelectedIndex == 1);
            countLabel.Text = $"Найдено материалов: {materialsPanel.Controls.Count}";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DBConnection.CloseDB();
            base.OnFormClosed(e);
        }

        private void materialsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
