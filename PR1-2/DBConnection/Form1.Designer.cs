namespace DBConnection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDBMenuStripElem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectFromDBMenuStripElem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncConnectToDBStripMenuElem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsListStripMenuElem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDBMenuStripElem,
            this.disconnectFromDBMenuStripElem,
            this.asyncConnectToDBStripMenuElem,
            this.connectionsListStripMenuElem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.toolStripMenuItem1.Text = "Работа с базой данных";
            // 
            // connectToDBMenuStripElem
            // 
            this.connectToDBMenuStripElem.Name = "connectToDBMenuStripElem";
            this.connectToDBMenuStripElem.Size = new System.Drawing.Size(320, 26);
            this.connectToDBMenuStripElem.Text = "Подключиться к базе данных";
            this.connectToDBMenuStripElem.Click += new System.EventHandler(this.connectToDBMenuStripElem_Click);
            // 
            // disconnectFromDBMenuStripElem
            // 
            this.disconnectFromDBMenuStripElem.Name = "disconnectFromDBMenuStripElem";
            this.disconnectFromDBMenuStripElem.Size = new System.Drawing.Size(320, 26);
            this.disconnectFromDBMenuStripElem.Text = "Отключиться от базы данных";
            this.disconnectFromDBMenuStripElem.Click += new System.EventHandler(this.disconnectFromDBMenuStripElem_Click);
            // 
            // asyncConnectToDBStripMenuElem
            // 
            this.asyncConnectToDBStripMenuElem.Name = "asyncConnectToDBStripMenuElem";
            this.asyncConnectToDBStripMenuElem.Size = new System.Drawing.Size(320, 26);
            this.asyncConnectToDBStripMenuElem.Text = "Асинхронное подключение к БД";
            this.asyncConnectToDBStripMenuElem.Click += new System.EventHandler(this.asyncConnectToDBStripMenuElem_Click);
            // 
            // connectionsListStripMenuElem
            // 
            this.connectionsListStripMenuElem.Name = "connectionsListStripMenuElem";
            this.connectionsListStripMenuElem.Size = new System.Drawing.Size(320, 26);
            this.connectionsListStripMenuElem.Text = "Список подключений";
            this.connectionsListStripMenuElem.Click += new System.EventHandler(this.connectionsListStripMenuElem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сколько продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сколько продуктов 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(12, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(358, 170);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фасовка";
            this.columnHeader3.Width = 100;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Список продуктов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Транзакция";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem connectToDBMenuStripElem;
        private ToolStripMenuItem disconnectFromDBMenuStripElem;
        private ToolStripMenuItem asyncConnectToDBStripMenuElem;
        private ToolStripMenuItem connectionsListStripMenuElem;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Button button3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button4;
    }
}