
namespace course_project
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "КОМПЬЮТЕРНАЯ ФИРМА";
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAuthorization.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAuthorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthorization.Location = new System.Drawing.Point(231, 261);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(353, 37);
            this.buttonAuthorization.TabIndex = 1;
            this.buttonAuthorization.Text = "Авторизация";
            this.buttonAuthorization.UseVisualStyleBackColor = false;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegistration.BackColor = System.Drawing.Color.White;
            this.buttonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(231, 316);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(353, 38);
            this.buttonRegistration.TabIndex = 2;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            //////////////////////////////
            // справкаToolStripMenuItem //
            //////////////////////////////
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            ////////////////
            //// label2 ////
            ////////////////
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(714, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Иванин Г. М. / КП";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::course_project.Properties.Resources.icons8_приложение_для_ноутбука_100;
            this.panel1.Location = new System.Drawing.Point(356, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 100);
            this.panel1.TabIndex = 6;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "КОМПЬЮТЕРНАЯ ФИРМА";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

