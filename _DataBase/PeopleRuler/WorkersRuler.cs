using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace course_project._DataBase.PeopleRuler
{
    class WorkersRuler: course_project.f_database.PeopleRuler
    {
        public string getSalary(int id)
        {
            string salary = "-1";
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                cmd = new SqlCommand("SELECT salary FROM Job WHERE FK_Person = @id;", connection);
                cmd.Parameters.AddWithValue("@id", id);

                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                salary = dt.Rows[0][0].ToString();
            }
            finally
            {
                connection.Close();
            }

            return salary;
        }


        public void refreshWorkers(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Person.ID, Post.ID, f AS 'Ф', i AS 'И', o AS 'О', telephone AS 'телефон', salary AS 'зарплата', Post.name AS 'роль' FROM" +
                    " Job INNER JOIN Post ON Job.FK_Post = Post.ID" +
                    " INNER JOIN Person ON Job.FK_Person = Person.ID; ", connection);
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

        public void refreshClients(DataGridView g)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Person.ID, f AS 'Ф', i AS 'И', o AS 'О', telephone AS 'телефон' " +
                    " FROM Person WHERE NOT Person.ID IN(SELECT Job.FK_Person FROM Job); ", connection);
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

        public void refreshComboboxPost(ComboBox cmb)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT Post.name AS 'роли' FROM Post", connection);
                adapter.Fill(dt);
                dt.Rows.Add(new object[] { "клиент" });
                cmb.DataSource = dt;
                cmb.DisplayMember = "роли";
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

        public int postStringToInt32(string post)
        {
            int res = -1;
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                cmd = new SqlCommand("SELECT Post.ID FROM Post WHERE Post.name = @namePost", connection);
                cmd.Parameters.AddWithValue("@namePost", post);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                res =  Convert.ToInt32(dt.Rows[0][0].ToString());
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

        public void changeWorker(int id, double salary, int post)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("UPDATE Job SET salary = @salary, FK_Post = @fk_post WHERE Job.FK_Person = @id;", connection);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@fk_post", post);
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

        public void changerWorkerToClient(int id)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("DELETE Job WHERE Job.FK_Person = @id;", connection);
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

        public void changeClientToWorker(int id, double salary, int post)
        {
            try
            {
                connection.Open();

                cmd = new SqlCommand("INSERT INTO Job(salary, FK_Post, FK_Person) VALUES(@salary, @fk_post, @fk_person)", connection);

                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@fk_post", post);
                cmd.Parameters.AddWithValue("@fk_person", id);

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
    }
}
