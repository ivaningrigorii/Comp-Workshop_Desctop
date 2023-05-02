
namespace course_project._DataBase.PeopleRuler
{
    partial class ChangeWorkers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeWorkers));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяВПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonOnlyPersonal = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyClients = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_tools,
            this.выйтиИзАккаунтаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_tools
            // 
            this.toolStripMenuItem_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяВПрофильToolStripMenuItem});
            this.toolStripMenuItem_tools.Name = "toolStripMenuItem_tools";
            this.toolStripMenuItem_tools.Size = new System.Drawing.Size(95, 20);
            this.toolStripMenuItem_tools.Text = "Инструменты";
            // 
            // вернутьсяВПрофильToolStripMenuItem
            // 
            this.вернутьсяВПрофильToolStripMenuItem.Name = "вернутьсяВПрофильToolStripMenuItem";
            this.вернутьсяВПрофильToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.вернутьсяВПрофильToolStripMenuItem.Text = "Вернуться в профиль";
            this.вернутьсяВПрофильToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяВПрофильToolStripMenuItem_Click);
            // 
            // выйтиИзАккаунтаToolStripMenuItem
            // 
            this.выйтиИзАккаунтаToolStripMenuItem.Name = "выйтиИзАккаунтаToolStripMenuItem";
            this.выйтиИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.выйтиИзАккаунтаToolStripMenuItem.Text = "Выйти из аккаунта";
            this.выйтиИзАккаунтаToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзАккаунтаToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(219, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(536, 209);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radioButtonOnlyPersonal
            // 
            this.radioButtonOnlyPersonal.AutoSize = true;
            this.radioButtonOnlyPersonal.BackColor = System.Drawing.Color.White;
            this.radioButtonOnlyPersonal.Checked = true;
            this.radioButtonOnlyPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonOnlyPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyPersonal.Location = new System.Drawing.Point(27, 58);
            this.radioButtonOnlyPersonal.Name = "radioButtonOnlyPersonal";
            this.radioButtonOnlyPersonal.Size = new System.Drawing.Size(157, 24);
            this.radioButtonOnlyPersonal.TabIndex = 26;
            this.radioButtonOnlyPersonal.TabStop = true;
            this.radioButtonOnlyPersonal.Text = "Только персонал";
            this.radioButtonOnlyPersonal.UseVisualStyleBackColor = false;
            this.radioButtonOnlyPersonal.CheckedChanged += new System.EventHandler(this.radioButtonOnlyPersonal_CheckedChanged);
            // 
            // radioButtonOnlyClients
            // 
            this.radioButtonOnlyClients.AutoSize = true;
            this.radioButtonOnlyClients.BackColor = System.Drawing.Color.White;
            this.radioButtonOnlyClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonOnlyClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyClients.Location = new System.Drawing.Point(27, 97);
            this.radioButtonOnlyClients.Name = "radioButtonOnlyClients";
            this.radioButtonOnlyClients.Size = new System.Drawing.Size(179, 24);
            this.radioButtonOnlyClients.TabIndex = 27;
            this.radioButtonOnlyClients.Text = "Только не персонал";
            this.radioButtonOnlyClients.UseVisualStyleBackColor = false;
            this.radioButtonOnlyClients.CheckedChanged += new System.EventHandler(this.radioButtonOnlyClients_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(453, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPost
            // 
            this.cbPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(339, 300);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(302, 28);
            this.cbPost.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(282, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Роль:";
            // 
            // tbSalary
            // 
            this.tbSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSalary.Location = new System.Drawing.Point(376, 340);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(265, 26);
            this.tbSalary.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(280, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Зарплата:";
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClear.Location = new System.Drawing.Point(579, 383);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(62, 32);
            this.btClear.TabIndex = 42;
            this.btClear.Text = "X";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.BackColor = System.Drawing.Color.Bisque;
            this.btChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btChange.Location = new System.Drawing.Point(289, 383);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(284, 32);
            this.btChange.TabIndex = 41;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = false;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // ChangeWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonOnlyClients);
            this.Controls.Add(this.radioButtonOnlyPersonal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeWorkers";
            this.Text = "КОМПЬЮТЕРНАЯ ФИРМА";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_tools;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяВПрофильToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonOnlyPersonal;
        private System.Windows.Forms.RadioButton radioButtonOnlyClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
    }
}