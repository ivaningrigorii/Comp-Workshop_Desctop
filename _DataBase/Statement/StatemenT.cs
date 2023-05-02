using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace course_project._DataBase
{
    class StatemenT: DataBaseWorker
    {
        public void deleteStatmentsWithoutPayment(int id)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("DELETE Statement WHERE Statement.FK_Person = @id AND Statement.FK_Status = 1;", connection);
                cmd.Parameters.AddWithValue("@id", id);
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

        public void addStatment(int id)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                cmd = new SqlCommand("INSERT INTO Statement(FK_Status, order_date, issue_date, FK_Person)" +
                    " VALUES(1, GETDATE(), GETDATE(), @id); ", connection);
                cmd.Parameters.AddWithValue("@id", id);

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

        public int findIndexOfStatmentWithoutPayment(int id)
        {
            int res = -1;
            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                cmd = new SqlCommand("SELECT ID FROM Statement WHERE Statement.FK_Person = @id AND  Statement.FK_Status = 1;", connection);
                cmd.Parameters.AddWithValue("@id", id);

                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                res = Convert.ToInt32( dt.Rows[0][0].ToString());
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

        public void addGoodToStatment(int id_statment, int id_stock)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                cmd = new SqlCommand("SELECT ISNULL(COUNT(*), 0) AS c FROM OrderedProducts WHERE FK_Stock=@fk_stock AND FK_Statement = @fk_statement", connection);
                cmd.Parameters.AddWithValue("@fk_statement", id_statment);
                cmd.Parameters.AddWithValue("@fk_stock", id_stock);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 0)
                {
                    cmd = new SqlCommand("INSERT INTO OrderedProducts(FK_Statement, FK_Stock, quan)" +
                    " VALUES(@fk_statement, @fk_stock, 1); ", connection);
                    cmd.Parameters.AddWithValue("@fk_statement", id_statment);
                    cmd.Parameters.AddWithValue("@fk_stock", id_stock);

                    cmd.ExecuteNonQuery();
                }
                
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

        public void dellGoodFromStatment(int id_order)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                cmd = new SqlCommand("DELETE OrderedProducts WHERE ID = @id_order", connection);
                cmd.Parameters.AddWithValue("@id_order", id_order);

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

        public void updateQuanInOrdered(int id_ordP, int quan)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("UPDATE OrderedProducts SET quan = @quan WHERE OrderedProducts.ID = @id", connection);

                cmd.Parameters.AddWithValue("@id", id_ordP);
                cmd.Parameters.AddWithValue("@quan", quan);

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

        public void updateReady(int id_st)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("UPDATE Statement SET  Statement.FK_Status = 3 WHERE Statement.ID = @id;", connection);
                cmd.Parameters.AddWithValue("@id", id_st);

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

        public void updateIssue(int id_st)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("UPDATE Statement SET Statement.FK_Status = 4 WHERE Statement.ID = @id;", connection);
                cmd.Parameters.AddWithValue("@id", id_st);

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

        public void refreshTableAboutStatment(int id, DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("SELECT OrderedProducts.ID, Stock.model AS 'Название товара', OrderedProducts.quan AS 'Кол-во в заказе'," +
                    "type AS 'Категория' FROM" +
                    " Statement inner join OrderedProducts" +
                    " ON OrderedProducts.FK_Statement = Statement.ID" +
                    " inner join Stock" +
                    " ON Stock.ID = OrderedProducts.FK_Stock" +
                    " inner join Type" +
                    "   ON Stock.FK_Type = Type.ID " +
                    " WHERE Statement.ID = @id; ", connection);

                cmd.Parameters.AddWithValue("@id", id);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                g.DataSource = dt;
                g.Columns[0].Visible = false;
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
        }

        public void refreshTableFullInformAbouStatement(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("SELECT Statement.ID AS 'Номер заказа', Person.f AS 'Ф.', Person.i AS 'И.', Person.o AS 'О.', Person.login AS 'Логин', " +
                    "Person.telephone AS 'Номер для связи' FROM" +
                    " Statement inner join Person" +
                    " ON Statement.FK_Person = Person.ID" +
                    " WHERE  Statement.FK_Status = 3; ", connection);

                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                g.DataSource = dt;
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
        }

        public double getSumStat(int id_st)
        {
            double sum = -1;
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("SELECT ISNULL(SUM(Stock.retail*OrderedProducts.quan), 0) AS cost FROM " +
                    " Statement" +
                    " left outer join OrderedProducts" +
                    " ON Statement.ID = OrderedProducts.FK_Statement" +
                    " left outer join Stock" +
                    " ON OrderedProducts.FK_Stock = Stock.ID" +
                    " WHERE Statement.ID = @id " +
                    " GROUP BY Statement.ID; ", connection);

                cmd.Parameters.AddWithValue("@id", id_st);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                sum = Convert.ToDouble(dt.Rows[0][0].ToString());
            }
            catch (Exception exp) 
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }

            return sum;
        }

        public void getMyBasketStatement1(int id, DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("SELECT ID AS 'Номер заказа'," +
                    "order_date AS 'Дата заказа', cost AS 'Сумма заказа'" +
                    "FROM ST_FOR_USERS_SHOW WHERE FK_Person = @id AND  status = 'корзина';", connection);

                cmd.Parameters.AddWithValue("@id", id);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                g.DataSource = dt;
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

        public void getMyNotReadyStatements1(int id, DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("SELECT ID AS 'Номер заказа'," +
                    "order_date AS 'Дата заказа', issue_date AS 'Ожидаемая дата выдачи', cost AS 'Сумма заказа'" +
                    "FROM ST_FOR_USERS_SHOW WHERE FK_Person = @id AND  status = 'оплачено';", connection);

                cmd.Parameters.AddWithValue("@id", id);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                g.DataSource = dt;
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

        public void getReadyStatemens1(int id, DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("SELECT ID AS 'Номер заказа'," +
                    "order_date AS 'Дата заказа', issue_date AS 'Дата полной подготовки товара', cost AS 'Сумма заказа'" +
                    "FROM ST_FOR_USERS_SHOW WHERE FK_Person = @id AND  status = 'собрано';", connection);

                cmd.Parameters.AddWithValue("@id", id);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                g.DataSource = dt;
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

        public void getNotReadyStatemens1(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("SELECT ID AS 'Номер заказа'," +
                    "order_date AS 'Дата заказа', issue_date AS 'Ожидаемая дата подготовки товара', cost AS 'Сумма заказа'" +
                    " FROM ST_FOR_USERS_SHOW WHERE  status = 'оплачено';", connection);

                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                g.DataSource = dt;
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

        public void getIssueStatements1(int id, DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                cmd = new SqlCommand("SELECT ID AS 'Номер заказа'," +
                    "order_date AS 'Дата заказа', issue_date AS 'Дата полной подготовки товара', cost AS 'Сумма заказа'" +
                    "FROM ST_FOR_USERS_SHOW WHERE FK_Person = @id AND  status = 'выдано';", connection);

                cmd.Parameters.AddWithValue("@id", id);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                g.DataSource = dt;
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

        public void setTime(double time, int id_st)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("UPDATE Statement SET issue_date = @date WHERE Statement.ID = @id_st", connection);

                DateTime date = DateTime.Now.AddDays(time);

                cmd.Parameters.AddWithValue("@id_st", id_st);
                cmd.Parameters.AddWithValue("@date", date);

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

        public void makePayment(int id_st)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                cmd = new SqlCommand("UPDATE Statement SET  Statement.FK_Status = 2 WHERE ID = @id_st", connection);
                cmd.Parameters.AddWithValue("@id_st", id_st);

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

        public void stockMin(int id_st)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                cmd = new SqlCommand("SELECT OrderedProducts.FK_Stock AS ID, (Stock.quan - OrderedProducts.quan) AS quan" +
                    " FROM OrderedProducts inner join Stock" +
                    " ON Stock.ID = OrderedProducts.FK_Stock" +
                    " WHERE OrderedProducts.FK_Statement = @id_st", connection);
                cmd.Parameters.AddWithValue("@id_st", id_st);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                connection.Close();

                List<string> quan = new List<string>();
                List<string> id = new List<string>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    id.Add(dt.Rows[i][0].ToString());
                    quan.Add(dt.Rows[i][1].ToString());
                }

                for (int i = 0; i < quan.Count; i++)
                {
                    connection.Open();
                    cmd = new SqlCommand("UPDATE Stock SET Stock.quan = @quan WHERE Stock.ID = @id", connection);
                    cmd.Parameters.AddWithValue("@quan", quan[i]);
                    cmd.Parameters.AddWithValue("@id", id[i]);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
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
