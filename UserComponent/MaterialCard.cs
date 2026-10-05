using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace up02.UserComponent
{

    public partial class MaterialCard : UserControl
    {
        internal int MaterialId { get; }

        public MaterialCard(DataRow material)
        {
            InitializeComponent();

            MaterialId = Convert.ToInt32(material["КодМатериала"]);

            labelName.Text = $"{material["ТипМатериала"]} | {material["Наименование"]}";

            labelDetails.Text = $"Минимальное количество: {material["МинимальноеКоличество"]} {material["ЕдиницаИзмерения"]}\n" +
                                $"Количество на складе:   {material["КоличествоНаСкладе"]} {material["ЕдиницаИзмерения"]}\n" +
                                $"Количество в упаковке:  {material["КоличествоВУпаковке"]}\n" +
                                $"Цена: {Convert.ToDecimal(material["Цена"]):N2} р / Единица измерения: {material["ЕдиницаИзмерения"]}";

            labelShortage.Text = GetStockStatus(material);

            labelHiddenId.Text = MaterialId.ToString();

            LoadImage(pictureBoxImage, Convert.ToString(material["Фото"]));
        }

        private static string GetStockStatus(DataRow row)
        {
            int stock = Convert.ToInt32(row["КоличествоНаСкладе"]);
            int minimum = Convert.ToInt32(row["МинимальноеКоличество"]);
            int cena = Convert.ToInt32(row["Цена"]);
            if (stock < minimum):
                    return $"Стоимость партии: ";
            return stock < minimum ? $"Ниже минимума на\n{minimum - stock}" : "Запас достаточен";
        }

        private void LoadImage(PictureBox target, string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                target.Paint += (_, e) =>
                {
                    const string text = "Нет фото";
                    Font fontToUse = target.Font ?? this.Font ?? SystemFonts.DefaultFont;
                    SizeF size = e.Graphics.MeasureString(text, fontToUse);
                    e.Graphics.DrawString(text, fontToUse, Brushes.Gray,
                        (target.Width - size.Width) / 2, (target.Height - size.Height) / 2);
                };
                return;
            }

            using Image source = Image.FromFile(path);
            target.Image = new Bitmap(source);
        }
    }
}