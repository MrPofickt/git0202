using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace up02.MyClass
{
    /// <summary>
    /// Класс для получения и отображения материалов.
    /// </summary>
    internal static class MyProd
    {
        /// <summary>
        /// Получает список всех типов материалов для фильтра.
        /// </summary>
        internal static DataTable GetMaterialTypes()
        {
            DBConnection.dtMaterialType.Clear();
            DBConnection.myCommand!.Parameters.Clear();
            DBConnection.myCommand.CommandText =
                "select id_material_type AS КодТипа, type AS ТипМатериала " +
                "from material_type order by type";
            DBConnection.myAdapter!.Fill(DBConnection.dtMaterialType);
            return DBConnection.dtMaterialType;
        }

        /// <summary>
        /// Загружает материалы в таблицу с учётом поиска, фильтра и сортировки.
        /// </summary>
        /// <param name="searchText">Фрагмент наименования или описания.</param>
        /// <param name="materialTypeId">Код типа; null означает все типы.</param>
        /// <param name="sortDescending">Сортировать цену по убыванию.</param>
        internal static DataTable GetAllMaterials(
            string searchText = "", int? materialTypeId = null, bool sortDescending = false)
        {
            try
            {
                DBConnection.dtMaterials.Clear();
                DBConnection.myCommand!.Parameters.Clear();
                DBConnection.myCommand.CommandText = $@"
                    select material.id_material AS КодМатериала,
                           material_type.type AS ТипМатериала,
                           material.name AS Наименование,
                           material.price AS Цена,
                           material.stock_quantity AS КоличествоНаСкладе,
                           material.min_quantity AS МинимальноеКоличество,
                           spr_units.unit AS ЕдиницаИзмерения,
                           material.quantity_pack AS КоличествоВУпаковке,
                           material.description AS Описание,
                           material.foto AS Фото
                    from material
                    inner join material_type
                        on material.id_material_type = material_type.id_material_type
                    inner join spr_units on material.id_unit = spr_units.id_unit
                    where (@search = '' or material.name like concat('%', @search, '%')
                           or material.description like concat('%', @search, '%'))
                      and (@typeId is null or material.id_material_type = @typeId)
                    order by material.price {(sortDescending ? "desc" : "asc")}, material.name";
                DBConnection.myCommand.Parameters.Add("@search", MySqlDbType.VarChar).Value = searchText.Trim();
                DBConnection.myCommand.Parameters.Add("@typeId", MySqlDbType.Int32).Value = materialTypeId.HasValue ? materialTypeId.Value : DBNull.Value;
                DBConnection.myAdapter!.Fill(DBConnection.dtMaterials);
                return DBConnection.dtMaterials;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка получения списка материалов!\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DBConnection.dtMaterials;
            }
        }

        /// <summary>
        /// Создаёт карточки материалов и выводит их на панель.
        /// </summary>
        internal static void ShowMaterials(FlowLayoutPanel panel, string searchText = "",
            int? materialTypeId = null, bool sortDescending = false)
        {
            panel.SuspendLayout();
            panel.Controls.Clear();

            foreach (DataRow row in GetAllMaterials(searchText, materialTypeId, sortDescending).Rows)
                panel.Controls.Add(new UserComponent.MaterialCard(row));

            panel.ResumeLayout();
        }
    }
}
