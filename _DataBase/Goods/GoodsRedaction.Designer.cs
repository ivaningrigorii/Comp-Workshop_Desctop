
namespace course_project._DataBase.Goods
{
    partial class GoodsRedaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsRedaction));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяВПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDell = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuan = new System.Windows.Forms.TextBox();
            this.chBActuality = new System.Windows.Forms.CheckBox();
            this.cBCategory = new System.Windows.Forms.ComboBox();
            this.chBSortActuality = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddPhoto = new System.Windows.Forms.Button();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
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
            this.menuStrip1.TabIndex = 7;
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
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Location = new System.Drawing.Point(603, 256);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(162, 32);
            this.btAdd.TabIndex = 21;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btDell
            // 
            this.btDell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btDell.BackColor = System.Drawing.Color.Bisque;
            this.btDell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDell.Location = new System.Drawing.Point(603, 294);
            this.btDell.Name = "btDell";
            this.btDell.Size = new System.Drawing.Size(162, 32);
            this.btDell.TabIndex = 22;
            this.btDell.Text = "Удалить";
            this.btDell.UseVisualStyleBackColor = false;
            this.btDell.Click += new System.EventHandler(this.btDEL_Click);
            // 
            // btChange
            // 
            this.btChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btChange.BackColor = System.Drawing.Color.Bisque;
            this.btChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btChange.Location = new System.Drawing.Point(603, 332);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(162, 32);
            this.btChange.TabIndex = 23;
            this.btChange.Text = "Изменить";
            this.btChange.UseVisualStyleBackColor = false;
            this.btChange.Click += new System.EventHandler(this.btUPDATE_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.dataGridView1.Location = new System.Drawing.Point(40, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(715, 116);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(94, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Название:";
            // 
            // tbModel
            // 
            this.tbModel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModel.Location = new System.Drawing.Point(187, 262);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(235, 26);
            this.tbModel.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Категория:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Розничная цена:";
            // 
            // tBPrice
            // 
            this.tBPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tBPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPrice.Location = new System.Drawing.Point(187, 294);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(235, 26);
            this.tBPrice.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(88, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "На складе:";
            // 
            // tbQuan
            // 
            this.tbQuan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuan.Location = new System.Drawing.Point(187, 326);
            this.tbQuan.Name = "tbQuan";
            this.tbQuan.Size = new System.Drawing.Size(235, 26);
            this.tbQuan.TabIndex = 30;
            // 
            // chBActuality
            // 
            this.chBActuality.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chBActuality.AutoSize = true;
            this.chBActuality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBActuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBActuality.Location = new System.Drawing.Point(253, 373);
            this.chBActuality.Name = "chBActuality";
            this.chBActuality.Size = new System.Drawing.Size(169, 24);
            this.chBActuality.TabIndex = 32;
            this.chBActuality.Text = "Актуальный товар";
            this.chBActuality.UseVisualStyleBackColor = true;
            // 
            // cBCategory
            // 
            this.cBCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cBCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBCategory.FormattingEnabled = true;
            this.cBCategory.Location = new System.Drawing.Point(188, 230);
            this.cBCategory.Name = "cBCategory";
            this.cBCategory.Size = new System.Drawing.Size(234, 28);
            this.cBCategory.TabIndex = 33;
            // 
            // chBSortActuality
            // 
            this.chBSortActuality.AutoSize = true;
            this.chBSortActuality.Checked = true;
            this.chBSortActuality.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBSortActuality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chBSortActuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBSortActuality.Location = new System.Drawing.Point(40, 47);
            this.chBSortActuality.Name = "chBSortActuality";
            this.chBSortActuality.Size = new System.Drawing.Size(236, 24);
            this.chBSortActuality.TabIndex = 34;
            this.chBSortActuality.Text = "Только актуальные товары";
            this.chBSortActuality.UseVisualStyleBackColor = true;
            this.chBSortActuality.CheckedChanged += new System.EventHandler(this.chB_SORT_ACTUALITY_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(449, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Фотография:";
            // 
            // btAddPhoto
            // 
            this.btAddPhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAddPhoto.BackColor = System.Drawing.Color.White;
            this.btAddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddPhoto.Location = new System.Drawing.Point(443, 377);
            this.btAddPhoto.Name = "btAddPhoto";
            this.btAddPhoto.Size = new System.Drawing.Size(141, 54);
            this.btAddPhoto.TabIndex = 36;
            this.btAddPhoto.Text = "+";
            this.btAddPhoto.UseVisualStyleBackColor = false;
            this.btAddPhoto.Click += new System.EventHandler(this.btAddPhoto_Click);
            // 
            // panelPhoto
            // 
            this.panelPhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelPhoto.Location = new System.Drawing.Point(443, 230);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(141, 141);
            this.panelPhoto.TabIndex = 37;
            // 
            // btClear
            // 
            this.btClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClear.Location = new System.Drawing.Point(603, 377);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(162, 54);
            this.btClear.TabIndex = 38;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // GoodsRedaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.panelPhoto);
            this.Controls.Add(this.btAddPhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chBSortActuality);
            this.Controls.Add(this.cBCategory);
            this.Controls.Add(this.chBActuality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btDell);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoodsRedaction";
            this.Text = "КОМПЬЮТЕРНАЯ ФИРМА";
            this.Load += new System.EventHandler(this.GoodsRedaction_Load);
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
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDell;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuan;
        private System.Windows.Forms.CheckBox chBActuality;
        private System.Windows.Forms.ComboBox cBCategory;
        private System.Windows.Forms.CheckBox chBSortActuality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAddPhoto;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
    }
}