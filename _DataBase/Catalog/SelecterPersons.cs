using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_project._DataBase.Catalog
{
    public partial class SelecterPersons : Form
    {
        course_project.f_database.PeopleRuler _people = new course_project.f_database.PeopleRuler();
        public SelecterPersons()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            _people.showPeopleWithLoginFilter("", dataGridView1);
            tbCategory.Text = "Поиск по логину";
            dataGridView1.ClearSelection();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                WindowSwither.next(this, new course_project._DataBase.Catalog.CatalogShower(
                    Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString())));

            }
            catch (Exception)
            {
                MessageBox.Show("Переход невозможен!");
            }
        }


        private void btChange_Click(object sender, EventArgs e)
        {
            _people.showPeopleWithLoginFilter(tbCategory.Text, dataGridView1);
            dataGridView1.ClearSelection();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                try
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                WindowSwither.next(this, new course_project._DataBase.Statement.TimeMaker(
                    Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString())));

            }
            catch (Exception)
            {
                MessageBox.Show("Переход невозможен!");
            }
        }

        private void button1_Click(object sender, EventArgs e) => WindowSwither.return_(this);

        private void buttonRegistration_Click(object sender, EventArgs e)
            => SwitcherBeatweener.roleShower.startPage(this);

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
            => SwitcherBeatweener.roleShower.startPage(this);
    }
}
