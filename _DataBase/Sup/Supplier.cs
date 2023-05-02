using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace course_project._DataBase.Sup
{
    class Supplier : DataBaseWorker
    {
        public void refreshCompanies(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT ID, name FROM Supplier", connection);
                adapter.Fill(dt);

                g.DataSource = dt;
                g.Columns[0].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить!");
            }
            finally
            {
                connection.Close();
            }
        }

        public void refreshCompanies(ComboBox g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT ID, name FROM Supplier", connection);
                adapter.Fill(dt);

                g.DataSource = dt;
                g.DisplayMember = "name";
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить!");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getIdCompany(string nameCompany)
        {
            int res = -1;

            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand("SELECT ID FROM Supplier WHERE Supplier.name = @nameCompany;", connection);
                cmd.Parameters.AddWithValue("@nameCompany", nameCompany);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                res = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }

            return res;
        }

        public void add(string name)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("INSERT INTO Supplier(name) VALUES(@name);", connection);
                cmd.Parameters.AddWithValue("@name", name);

                cmd.ExecuteNonQuery();
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

        public void updateSupplier(string type, int id)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("UPDATE Supplier SET name = @type WHERE Supplier.ID = @id;", connection);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Изменение невозможно");
            }
            finally
            {
                connection.Close();
            }
        }

        public void dell(int id)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("DELETE Supplier WHERE Supplier.ID = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Удаление невозможно!");
            }
            finally
            {
                connection.Close();
            }
        }

        public double getAvgMaxTimeOfSup(int id_p)
        {
            double res = 0;

            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand("SELECT MAX(day_sup_avg) AS 'max' FROM Statement " +
                    " inner join OrderedProducts" +
                    " ON OrderedProducts.FK_Statement = Statement.ID" +
                    " inner join Stock" +
                    " ON Stock.ID = OrderedProducts.FK_Stock" +
                    " inner join StockAvg" +
                    " ON Stock.ID = StockAvg.ID" +
                    " WHERE Stock.quan - OrderedProducts.quan <= 0" +
                    " GROUP BY Statement.ID, Statement.FK_Person" +
                    " HAVING Statement.FK_Person = @id AND Statement.FK_Status IN (2, 3, 4); ", connection);
                cmd.Parameters.AddWithValue("@id", id_p);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                res = Convert.ToDouble(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                res = 0;
            }
            finally
            {
                connection.Close();
            }

            return res;
        }

        public double getAvgTimeOfSupOneGood(int id_stock)
        {
            double res = 0;

            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand("SELECT day_sup_avg FROM StockAvg WHERE ID = @id;", connection);
                cmd.Parameters.AddWithValue("@id", id_stock);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                res = Convert.ToDouble(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить!");
            }
            finally
            {
                connection.Close();
            }

            return res;
        }

        public void refreshTalbeAllModels(DataGridView g, string findString)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Stock.ID, Stock.model AS 'Название', " +
                    "Stock.quan AS 'Кол-во на складе', " +
                    $"Stock.retail AS 'Розничная цена' FROM Stock WHERE Stock.model LIKE '%{findString}%';", connection);
                adapter.Fill(dt);

                g.DataSource = dt;
                g.Columns[0].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить!");
            }
            finally
            {
                connection.Close();
            }
        }

        public void refreshNeedGoodsTalbe(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Stock.ID, Stock.model AS 'Название', -(quan - ISNULL(t.q, 0) + ISNULL(t_.quan_, 0)) as 'Не хватает'" +
                    " FROM Stock" +
                    " left outer join" +
                    " (SELECT OrderedProducts.FK_Stock as id, ISNULL(SUM(OrderedProducts.quan), 0) as q FROM" +
                    " OrderedProducts inner join Statement" +
                    " ON OrderedProducts.FK_Statement = Statement.ID" +
                    " WHERE Statement.FK_Status = 2" +
                    " GROUP BY OrderedProducts.FK_Stock) as t" +
                    " ON Stock.ID = t.id" +
                    " left outer join" +
                    " (SELECT SupplyContract.FK_Stock as id_, SUM(SupplyContract.quan) as quan_ FROM" +
                    " SupplyContract" +
                    " WHERE SupplyContract.FK_Status = 2" +
                    " GROUP BY SupplyContract.FK_Stock) as t_" +
                    " ON Stock.ID = t_.id_" +
                    " WHERE - (quan - ISNULL(t.q, 0) + ISNULL(t_.quan_, 0)) >= 0; ", connection);
                adapter.Fill(dt);

                g.DataSource = dt;
                g.Columns[0].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить!");
            }
            finally
            {
                connection.Close();
            }
        }

        public void sendQuerToSup(int fk_sup, int fk_stock, double whoolsale, int quan, int days)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("INSERT INTO SupplyContract(FK_Supplier, FK_Stock, whoolsale, quan, FK_Status, " +
                    "days_sup, message_close, dateStart)" +
                    " VALUES(@fk_sup, @fk_stock, @whoolsale, @quan, 1, @days, '', @dateStart); ", connection);
                cmd.Parameters.AddWithValue("@fk_sup", fk_sup);
                cmd.Parameters.AddWithValue("@fk_stock", fk_stock);
                cmd.Parameters.AddWithValue("@whoolsale", whoolsale);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@days", days);
                cmd.Parameters.AddWithValue("@dateStart", DateTime.Now);

                cmd.ExecuteNonQuery();
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

        public int getIdToIDPerson(int idPerson)
        {
            int res = 0;

            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand("SELECT FK_Supplier FROM SupplierPresenter WHERE FK_Person = @id;", connection);
                cmd.Parameters.AddWithValue("@id", idPerson);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                res = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить!");
            }
            finally
            {
                connection.Close();
            }

            return res;
        }

        public void refreshSupContarcts(DataGridView g, int id_sup)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand("SELECT SupplyContract.ID, Stock.model AS 'Название', Type.type AS 'Категория', " +
                    " SupplyContract.days_sup AS 'Время доставки'," +
                    " SupplyContract.quan AS 'Кол-во в поставке', SupplyContract.whoolsale AS 'Закупочная цена за штуку'," +
                    " SupplyContract.dateStart AS 'Дата заявки'" +
                    " FROM" +
                    " SupplyContract left outer join Stock" +
                    " ON Stock.ID = SupplyContract.FK_Stock" +
                    " left outer join Type" +
                    " ON Type.ID = Stock.FK_Type" +
                    " WHERE SupplyContract.FK_Supplier = @id AND FK_Status = 1; ", connection);
                cmd.Parameters.AddWithValue("@id", id_sup);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                g.DataSource = dt;
                g.Columns[0].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить!");
            }
            finally
            {
                connection.Close();
            }
        }

        public void udateStatusContract(int status, string message, int id_contract)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("UPDATE SupplyContract SET FK_Status = @status, " +
                    "message_close = @message WHERE SupplyContract.ID = @id;", connection);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@id", id_contract);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Изменение невозможно");
            }
            finally
            {
                connection.Close();
            }
        }

        public void refreshAllForKeeper(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand(" SELECT SupplyContract.ID, Stock.ID, Supplier.name AS 'Фирма-поставщик', Stock.model AS 'Название товара'," +
                    " SupplyContract.quan AS 'Кол-во', SupplyContract.whoolsale AS 'Оптовая цена за шт.'," +
                    " SupplyContract.days_sup AS 'Дней на доставку', SupplyContract.dateStart AS 'Дата заявки'," +
                    " SupplyContract.message_close AS 'Сообщение фирмы-поставщика'" +
                    " " +
                    " FROM" +
                    " SupplyContract" +
                    " left outer join Stock" +
                    " ON Stock.ID = SupplyContract.FK_Stock" +
                    " left outer join Supplier" +
                    " ON Supplier.ID = SupplyContract.FK_Supplier" +
                    " WHERE FK_Status = 2" +
                    " ORDER BY SupplyContract.dateStart; ", connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                g.DataSource = dt;
                g.Columns[0].Visible = false;
                g.Columns[1].Visible = false;
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

        public void refreshAll(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand(" SELECT Supplier.name AS 'Фирма-поставщик', Stock.model AS 'Название товара'," +
                    " SupplyContract.quan AS 'Кол-во', SupplyContract.whoolsale AS 'Оптовая цена за шт.'," +
                    " SupplyContract.days_sup AS 'Дней на доставку', SupplyContract.dateStart AS 'Дата заявки'," +
                    " SupplyContract.message_close AS 'Сообщение фирмы-поставщика', StatusSupplyContract.name AS 'Статус договора' " +
                    " FROM" +
                    " SupplyContract" +
                    " left outer join Stock" +
                    " ON Stock.ID = SupplyContract.FK_Stock" +
                    " left outer join Supplier" +
                    " ON Supplier.ID = SupplyContract.FK_Supplier" +
                    " left outer join StatusSupplyContract" +
                    " ON StatusSupplyContract.ID = SupplyContract.FK_Status " +
                    " WHERE FK_Status IN (2, 3, 4)" +
                    " ORDER BY SupplyContract.dateStart; ", connection);
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

        public void refreshAll(DataGridView g, int idCompany)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand(" SELECT Supplier.name AS 'Фирма-поставщик', Stock.model AS 'Название товара'," +
                    " SupplyContract.quan AS 'Кол-во', SupplyContract.whoolsale AS 'Оптовая цена за шт.'," +
                    " SupplyContract.days_sup AS 'Дней на доставку', SupplyContract.dateStart AS 'Дата заявки'," +
                    " SupplyContract.message_close AS 'Сообщение фирмы-поставщика', StatusSupplyContract.name AS 'Статус договора' " +
                    " FROM" +
                    " SupplyContract" +
                    " left outer join Stock" +
                    " ON Stock.ID = SupplyContract.FK_Stock" +
                    " left outer join Supplier" +
                    " ON Supplier.ID = SupplyContract.FK_Supplier" +
                    " left outer join StatusSupplyContract" +
                    " ON StatusSupplyContract.ID = SupplyContract.FK_Status " +
                    " WHERE Supplier.ID = @id AND  FK_Status IN (2, 3, 4)" +
                    " ORDER BY SupplyContract.dateStart; ", connection);
                cmd.Parameters.AddWithValue("@id", idCompany);
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

        public void payContract(int id_contract)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("UPDATE SupplyContract SET FK_Status = 4 WHERE SupplyContract.ID = @id;", connection);
                cmd.Parameters.AddWithValue("@id", id_contract);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Изменение невозможно");
            }
            finally
            {
                connection.Close();
            }
        }

        public void setStock(int id_stock, int quan)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("UPDATE Stock SET quan = quan+@quan WHERE Stock.ID = @id;", connection);
                cmd.Parameters.AddWithValue("@id", id_stock);
                cmd.Parameters.AddWithValue("@quan", quan);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Изменение невозможно");
            }
            finally
            {
                connection.Close();
            }
        }

        
    }
}
