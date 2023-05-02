using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;


namespace course_project._DataBase
{
    class Good : DataBaseWorker
    {
        public void refreshTable(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                adapter = new SqlDataAdapter("SELECT ID, photo AS 'фото', model AS 'название', quan AS 'кол-во', " +
                    " retail AS 'розничная'," +
                    " supplied AS 'актуальность'," +
                    " (SELECT type FROM Type WHERE Type.ID = Stock.FK_Type) AS 'категория' FROM Stock; ", connection);

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

        public void refreshTableOnlyActuality(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                adapter = new SqlDataAdapter("SELECT ID, photo AS 'фото', model AS 'название', quan AS 'кол-во', " +
                    " retail AS 'розничная'," +
                    " supplied AS 'актуальность'," +
                    " (SELECT type FROM Type WHERE Type.ID = Stock.FK_Type) AS 'категория' FROM Stock WHERE Stock.supplied = 1; ", connection);

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

        public int findFK_TypeInt(string FK_TypeString)
        {
            int FK_TypeInt = 0;

            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                cmd = new SqlCommand("SELECT ID FROM Type WHERE Type.type = @FK_TypeString", connection);
                cmd.Parameters.AddWithValue("@FK_TypeString", FK_TypeString);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                FK_TypeInt = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return FK_TypeInt;
        }

        public int findCategoryPosition(string FK_TypeString)
        {
            int FK_TypeInt = 0;

            try
            {
                DataTable dt = new DataTable();

                connection.Open();

                cmd = new SqlCommand("SELECT type FROM Type", connection);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (FK_TypeString.Equals(Convert.ToInt32(dt.Rows[i][0].ToString())))
                    {
                        FK_TypeInt = i;
                    }
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return FK_TypeInt;
        }

        public void add(string FK_TypeString, double retail, int quan, bool supplied, string model, byte[] photo)
        {
            try
            {
                DataTable dt = new DataTable();

                int FK_TypeInt = findFK_TypeInt(FK_TypeString);

                connection.Open();

                cmd = new SqlCommand("INSERT INTO Stock(retail, quan, FK_Type, supplied, model, photo)" +
                    " VALUES(@retail, @quan, @FK_TypeInt, @supplied, @model, @photo); ", connection);

                cmd.Parameters.AddWithValue("@retail", retail);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@FK_TypeInt", FK_TypeInt);
                cmd.Parameters.AddWithValue("@supplied", supplied);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@photo", photo);

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

        public void dell(int ID)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("DELETE Stock WHERE ID = @ID;", connection);
                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
        }

        public void update_(string FK_TypeString, double retail, int quan, bool supplied, string model, byte[] photo, int id)
        {

            try
            {
                DataTable dt = new DataTable();

                int FK_TypeInt = findFK_TypeInt(FK_TypeString);

                connection.Open();

                cmd = new SqlCommand("UPDATE Stock SET retail = @retail, quan = @quan, FK_Type = @FK_TypeInt, " +
                    " supplied = @supplied, model = @model, photo = @photo WHERE Stock.ID = @id", connection);

                cmd.Parameters.AddWithValue("@retail", retail);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@FK_TypeInt", FK_TypeInt);
                cmd.Parameters.AddWithValue("@supplied", supplied);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@photo", photo);
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

        public void updateCategoryCombobox(ComboBox cmb)
        {
            try
            {
                DataTable dt = new DataTable();

                connection.Open();
                adapter = new SqlDataAdapter("SELECT type FROM Type", connection);

                adapter.Fill(dt);

                cmb.DataSource = dt;
                cmb.DisplayMember = "type";
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
        }
    }
}
