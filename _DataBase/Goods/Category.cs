using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace course_project._DataBase.Goods
{
    class Category : DataBaseWorker
    {
        public void add(string type)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("INSERT INTO Type(type) VALUES(@type);", connection);
                cmd.Parameters.AddWithValue("@type", type);

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

        public void updateCategory(string type, int id)
        {
            try
            {
                connection.Open();
                cmd = new SqlCommand("UPDATE Type SET type = @type WHERE Type.ID = @id;", connection);
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
                cmd = new SqlCommand("DELETE Type WHERE Type.ID = @id", connection);
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

        public void refreshTable(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT ID, type AS 'Название категории' FROM Type", connection);

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

        public List<string> getCategoryesArrayString()
        {
            List<string> categoryes = new List<string>();
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT type FROM Type", connection);

                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    categoryes.Add(dt.Rows[i][0].ToString());
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

            return categoryes;
        }
    }
}
