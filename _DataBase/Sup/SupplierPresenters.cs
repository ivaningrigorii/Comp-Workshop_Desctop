using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace course_project._DataBase.Sup
{
    class SupplierPresenters: DataBaseWorker
    {
        public void refreshNullFirms(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Supplier.name AS 'название' FROM" +
                    " Supplier left outer join SupplierPresenter" +
                    " ON Supplier.ID = SupplierPresenter.FK_Supplier" +
                    " WHERE SupplierPresenter.FK_Supplier IS NULL; ", connection);
                adapter.Fill(dt);

                g.DataSource = dt;
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

        public void refreshNullPerson(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Person.ID, f AS 'Ф', i AS 'И', o AS 'О', telephone AS 'телефон' FROM" +
                    " Person LEFT OUTER JOIN SupplierPresenter" +
                    " ON Person.ID = SupplierPresenter.FK_Person" +
                    " LEFT OUTER JOIN Job" +
                    " ON Person.ID = Job.FK_Person" +
                    " WHERE Job.FK_Person IS NULL AND SupplierPresenter.FK_Person IS NULL; ", connection);
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

        public void refreshPeopleInFirms(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT SupplierPresenter.FK_Supplier, SupplierPresenter.FK_Person, f AS 'Ф', i AS 'И', o AS 'О', " +
                    " telephone AS 'телефон', Supplier.name AS 'фирма поставщика'" +
                    " FROM" +
                    " SupplierPresenter inner join Supplier" +
                    " ON SupplierPresenter.FK_Supplier = Supplier.ID" +
                    " inner join Person" +
                    " ON SupplierPresenter.FK_Person = Person.ID; ", connection);
                adapter.Fill(dt);

                g.DataSource = dt;
                g.Columns[0].Visible = false;
                g.Columns[1].Visible = false;
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

        public void refreshComboboxSupplier(ComboBox cmb)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Supplier.name FROM Supplier", connection);
                adapter.Fill(dt);
                dt.Rows.Add(new object[] { "-----" });
                cmb.DataSource = dt;
                cmb.DisplayMember = "name";
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

        public void updatePresenters(int id_sup, int FK_Person)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("UPDATE SupplierPresenter SET FK_Supplier = @id_sup WHERE FK_Person = @FK_Person;", connection);
                cmd.Parameters.AddWithValue("@FK_Person", FK_Person);
                cmd.Parameters.AddWithValue("@id_sup", id_sup);

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

        public void addPresenter(int id_sup, int FK_Person)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("INSERT INTO SupplierPresenter(FK_Person, FK_Supplier) VALUES(@FK_Person, @id_sup);", connection);
                cmd.Parameters.AddWithValue("@FK_Person", FK_Person);
                cmd.Parameters.AddWithValue("@id_sup", id_sup);

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

        public void dell(int FK_Person)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("DELETE SupplierPresenter WHERE FK_Person = @id", connection);
                cmd.Parameters.AddWithValue("@id", FK_Person);

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

        public int supStringToInt32(string sup)
        {
            int res = -1;
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand("SELECT Supplier.ID FROM Supplier WHERE Supplier.name = @namePost", connection);
                cmd.Parameters.AddWithValue("@namePost", sup);
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
    }
}
