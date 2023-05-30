namespace laba_7_forms
{
    partial class Form1
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
            this.tbNameObserver = new System.Windows.Forms.TextBox();
            this.listObservers = new System.Windows.Forms.ListBox();
            this.btnAddObserver = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.btnDeleteStation = new System.Windows.Forms.Button();
            this.listStations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteObserver = new System.Windows.Forms.Button();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNameObserver
            // 
            this.tbNameObserver.Location = new System.Drawing.Point(12, 29);
            this.tbNameObserver.Name = "tbNameObserver";
            this.tbNameObserver.Size = new System.Drawing.Size(159, 20);
            this.tbNameObserver.TabIndex = 0;
            // 
            // listObservers
            // 
            this.listObservers.FormattingEnabled = true;
            this.listObservers.Location = new System.Drawing.Point(12, 55);
            this.listObservers.Name = "listObservers";
            this.listObservers.Size = new System.Drawing.Size(159, 108);
            this.listObservers.TabIndex = 1;
            // 
            // btnAddObserver
            // 
            this.btnAddObserver.Location = new System.Drawing.Point(12, 170);
            this.btnAddObserver.Name = "btnAddObserver";
            this.btnAddObserver.Size = new System.Drawing.Size(159, 23);
            this.btnAddObserver.TabIndex = 2;
            this.btnAddObserver.Text = "Добавить слушателя";
            this.btnAddObserver.UseVisualStyleBackColor = true;
            this.btnAddObserver.Click += new System.EventHandler(this.btnAddObserver_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 272);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(594, 164);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Слушатели";
            // 
            // btnAddStation
            // 
            this.btnAddStation.Location = new System.Drawing.Point(197, 29);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(159, 23);
            this.btnAddStation.TabIndex = 2;
            this.btnAddStation.Text = "Добавить станцию";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // btnDeleteStation
            // 
            this.btnDeleteStation.Location = new System.Drawing.Point(447, 29);
            this.btnDeleteStation.Name = "btnDeleteStation";
            this.btnDeleteStation.Size = new System.Drawing.Size(159, 23);
            this.btnDeleteStation.TabIndex = 2;
            this.btnDeleteStation.Text = "Удалить станцию";
            this.btnDeleteStation.UseVisualStyleBackColor = true;
            this.btnDeleteStation.Click += new System.EventHandler(this.btnDeleteStation_Click);
            // 
            // listStations
            // 
            this.listStations.FormattingEnabled = true;
            this.listStations.Location = new System.Drawing.Point(197, 55);
            this.listStations.Name = "listStations";
            this.listStations.Size = new System.Drawing.Size(409, 160);
            this.listStations.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Коллекция станций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логи";
            // 
            // btnDeleteObserver
            // 
            this.btnDeleteObserver.Location = new System.Drawing.Point(12, 199);
            this.btnDeleteObserver.Name = "btnDeleteObserver";
            this.btnDeleteObserver.Size = new System.Drawing.Size(159, 23);
            this.btnDeleteObserver.TabIndex = 2;
            this.btnDeleteObserver.Text = "Удалить слушателя";
            this.btnDeleteObserver.UseVisualStyleBackColor = true;
            this.btnDeleteObserver.Click += new System.EventHandler(this.btnDeleteObserver_Click);
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(514, 246);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(92, 23);
            this.btnClearLogs.TabIndex = 2;
            this.btnClearLogs.Text = "Очистить логи";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDeleteStation);
            this.Controls.Add(this.btnClearLogs);
            this.Controls.Add(this.btnAddStation);
            this.Controls.Add(this.btnDeleteObserver);
            this.Controls.Add(this.btnAddObserver);
            this.Controls.Add(this.listStations);
            this.Controls.Add(this.listObservers);
            this.Controls.Add(this.tbNameObserver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "События и делегаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameObserver;
        private System.Windows.Forms.ListBox listObservers;
        private System.Windows.Forms.Button btnAddObserver;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Button btnDeleteStation;
        private System.Windows.Forms.ListBox listStations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteObserver;
        private System.Windows.Forms.Button btnClearLogs;
    }
}

