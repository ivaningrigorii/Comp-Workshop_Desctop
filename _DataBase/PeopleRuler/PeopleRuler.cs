using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace course_project.f_database
{
    //надо заполнить методы
    class PeopleRuler: _DataBase.DataBaseWorker
    {

        public bool findPerson(string login, string password, out int id)
        {
            bool res = false;
            DataTable dt = new DataTable();
            id = - 1;

            try
            {
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Person.ID, Person.login, Person.pass FROM Person", connection);
                adapter.Fill(dt);
                connection.Close();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (login.Equals(dt.Rows[i]["login"].ToString()) && password.Equals(dt.Rows[i]["pass"].ToString()))
                    {
                        id = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                        res = true;
                        break;
                    }
                }
            }
            finally
            {
                connection.Close();
            }

            return res;
        }

        public List<string> findPersonData(int id)
        {
            List<string> data = new List<string>();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT i, f, o, login, pass, telephone FROM Person WHERE Person.ID = @id_;", connection);
                cmd.Parameters.AddWithValue("@id_", id);
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows[0].ItemArray.Length; i++)
                {
                    data.Add(dt.Rows[0][i].ToString());
                }
            }
            finally
            {
                connection.Close();
            }

            return data;
        }

        //предполагается, что авторизацию прошёл
        public string getRole(int id)
        {
            string role = "клиент";

            role = isWorker(id, role);
            role = isSupplierPresent(id, role);

            return role;
        }

        private string isWorker(int id, string role)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();

                adapter = new SqlDataAdapter("SELECT FK_Person, Post.name FROM " +
                " Job INNER JOIN Post" +
                " ON Job.FK_Post = Post.ID; ", connection);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["FK_Person"].ToString().Equals(id.ToString()))
                    {
                        return dt.Rows[i]["name"].ToString();
                    }
                }
            }
            finally
            {
                connection.Close();
            }

            return role;
        }

        private string isSupplierPresent(int id, string role)
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                adapter = new SqlDataAdapter("SELECT FK_Person FROM SupplierPresenter; ", connection);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["FK_Person"].ToString().Equals(id.ToString()))
                    {
                        return "представитель";
                    }
                }
            }
            finally
            {
                connection.Close();
            }


            return role;
        }

        public double getSalary(int id)
        {
            double salary = -1;
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                cmd = new SqlCommand("SELECT Job.salary FROM Job WHERE Job.FK_Person = @ID;", connection);
                cmd.Parameters.AddWithValue("@ID", id);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                salary = Convert.ToDouble(dt.Rows[0]["salary"].ToString());
                
            }
            finally
            {
                connection.Close();
            }

            return salary;
        }

        public string getSupplierNameCompany(int id)
        {
            string name = "...";
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                cmd = new SqlCommand("" +
                    " SELECT Supplier.name FROM" +
                    " SupplierPresenter left outer join Supplier" +
                    " ON Supplier.ID = SupplierPresenter.FK_Supplier" +
                    " WHERE SupplierPresenter.FK_Person = @id; ", connection);

                cmd.Parameters.AddWithValue("@id", id);

                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                name = dt.Rows[0][0].ToString();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }


            return name;
        }

        public bool registration(string f, string i, string o, string login, string password, string telephone)
        {
            bool transaction = false;

            try
            {
                connection.Open();

                cmd = new SqlCommand("INSERT INTO Person(f, i, o, login, pass, telephone) VALUES (@f, @i, @o, @login, @password, @telephone);", connection);
                cmd.Parameters.AddWithValue("@f", f);
                cmd.Parameters.AddWithValue("@i", i);
                cmd.Parameters.AddWithValue("@o", o);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@telephone", telephone);

                cmd.ExecuteNonQuery();

                connection.Close();

                transaction = true;

            }
            catch (Exception)
            {
                transaction = false;
            }
            finally
            {
                connection.Close();
            }

            return transaction;
        }

        public bool changeDataPerson(string password, string telephone, int id)
        {
            bool res = true;

            try
            {
                connection.Open();
                cmd = new SqlCommand("UPDATE Person SET pass = @password, telephone = @telephone WHERE ID = @id;", connection);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@telephone", telephone);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                res = false;
            }
            finally
            {
                connection.Close();
            }

            return res;
        }

        public void showPeopleWithLoginFilter(string logFinderString, DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT ID, f AS 'Ф.', i AS 'И.', o AS 'О.', login AS 'Логин' FROM Person" +
                    $" WHERE login LIKE '%{logFinderString}%';", connection);

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
