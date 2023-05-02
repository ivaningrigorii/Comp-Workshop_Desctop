using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace course_project._DataBase
{
    class CataloG: DataBaseWorker
    {
        public void refreshTable(DataGridView g, List<string> categories, double min, double max, bool zakaz)
        {
            try
            {
                DataTable dt = new DataTable();
                string categInQuer = "";
                connection.Open();

                for (int i = 0; i < categories.Count; i++)
                {
                    categInQuer += "@x" + i;
                    if (i != categories.Count - 1)
                        categInQuer += ", ";
                }
                categInQuer.Remove(categInQuer.Length - 2);

                #region Quer

                string quer = "" +
                    "SELECT Stock.ID, Stock.photo AS 'Фотография', model AS 'Название товара',   " +
                    "                      retail AS 'Цена за 1 штуку',   " +
                    "                      CASE WHEN(Stock.quan -ISNULL(t, 0))< 0 THEN 0 ELSE(Stock.quan - ISNULL(t, 0)) END" +
                    "                   AS 'Осталось на складе', Type.type AS 'Категория товаров'" +
                    "                      FROM Stock" +
                    "                      left outer join" +
                    "                      (" +
                    "                      SELECT Stock.ID AS ID_fromD, ISNULL(SUM(OrderedProducts.quan), 0) as t" +
                    "                      FROM Stock left outer join OrderedProducts" +
                    "                      ON Stock.ID = OrderedProducts.FK_Stock" +
                    "                      left outer join Statement" +
                    "                      ON OrderedProducts.FK_Statement = Statement.ID" +
                    "                      WHERE Statement.FK_Status = 2" +
                    "                      GROUP BY Stock.ID" +
                    "                      ) as d" +
                    "                      ON Stock.ID = d.ID_fromD" +
                    "                      left outer join Type" +
                    "                      ON Type.ID = Stock.FK_Type" +
                    $" WHERE retail < @max AND retail > @min AND Stock.supplied = 1 AND type IN ({categInQuer}) ";
                
                if (zakaz)
                {
                    quer += "AND Stock.quan-ISNULL(t, 0)<=0";
                }
                else
                {
                    quer += "AND Stock.quan-ISNULL(t, 0)> 0";
                }

                cmd = new SqlCommand(quer, connection);

                #endregion

                cmd.Parameters.AddWithValue("@min", min);
                cmd.Parameters.AddWithValue("@max", max);

                for (int i = 0; i < categories.Count; i++)
                {
                    cmd.Parameters.AddWithValue(Convert.ToString("@x" + i), categories[i]);
                }

                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                g.DataSource = dt;
                g.Columns[0].Visible = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
