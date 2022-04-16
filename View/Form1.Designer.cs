namespace View
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
            this.ChooseAction = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.do_button = new System.Windows.Forms.Button();
            this.acs = new System.Windows.Forms.ComboBox();
            this.FillButton = new System.Windows.Forms.Button();
            this.Arr1NTextBox = new System.Windows.Forms.TextBox();
            this.Arr1MTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Arr2NTextBox = new System.Windows.Forms.TextBox();
            this.Arr2MTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseAction
            // 
            this.ChooseAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseAction.FormattingEnabled = true;
            this.ChooseAction.Items.AddRange(new object[] {
            "1. Нахождение расстояния между двумя точками на плоскости.",
            "2. Сложение или умножение комплесксных чисел.",
            "3. Вычислить энергию тела, если известны его масса и скорость.",
            "4. Умножить матрицы"});
            this.ChooseAction.Location = new System.Drawing.Point(13, 13);
            this.ChooseAction.Name = "ChooseAction";
            this.ChooseAction.Size = new System.Drawing.Size(521, 26);
            this.ChooseAction.TabIndex = 0;
            this.ChooseAction.SelectedIndexChanged += new System.EventHandler(this.ChooseAction_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(350, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 300);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(679, 82);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(300, 300);
            this.dataGridView3.TabIndex = 1;
            // 
            // do_button
            // 
            this.do_button.Location = new System.Drawing.Point(198, 430);
            this.do_button.Name = "do_button";
            this.do_button.Size = new System.Drawing.Size(96, 33);
            this.do_button.TabIndex = 2;
            this.do_button.Text = "Выполнить ";
            this.do_button.UseVisualStyleBackColor = true;
            // 
            // acs
            // 
            this.acs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acs.FormattingEnabled = true;
            this.acs.Items.AddRange(new object[] {
            "1. Сложить",
            "2. Умножить "});
            this.acs.Location = new System.Drawing.Point(13, 435);
            this.acs.Name = "acs";
            this.acs.Size = new System.Drawing.Size(156, 24);
            this.acs.TabIndex = 3;
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(12, 45);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(96, 33);
            this.FillButton.TabIndex = 2;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // Arr1NTextBox
            // 
            this.Arr1NTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arr1NTextBox.Location = new System.Drawing.Point(119, 389);
            this.Arr1NTextBox.Name = "Arr1NTextBox";
            this.Arr1NTextBox.Size = new System.Drawing.Size(30, 24);
            this.Arr1NTextBox.TabIndex = 4;
            // 
            // Arr1MTextBox
            // 
            this.Arr1MTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arr1MTextBox.Location = new System.Drawing.Point(155, 389);
            this.Arr1MTextBox.Name = "Arr1MTextBox";
            this.Arr1MTextBox.Size = new System.Drawing.Size(30, 24);
            this.Arr1MTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размерность";
            // 
            // Arr2NTextBox
            // 
            this.Arr2NTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arr2NTextBox.Location = new System.Drawing.Point(454, 391);
            this.Arr2NTextBox.Name = "Arr2NTextBox";
            this.Arr2NTextBox.Size = new System.Drawing.Size(30, 24);
            this.Arr2NTextBox.TabIndex = 4;
            // 
            // Arr2MTextBox
            // 
            this.Arr2MTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arr2MTextBox.Location = new System.Drawing.Point(490, 391);
            this.Arr2MTextBox.Name = "Arr2MTextBox";
            this.Arr2MTextBox.Size = new System.Drawing.Size(30, 24);
            this.Arr2MTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(347, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Размерность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Arr2MTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Arr2NTextBox);
            this.Controls.Add(this.Arr1MTextBox);
            this.Controls.Add(this.Arr1NTextBox);
            this.Controls.Add(this.acs);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.do_button);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChooseAction);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Объектно-ориентированное программирование";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseAction;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button do_button;
        private System.Windows.Forms.ComboBox acs;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox Arr1NTextBox;
        private System.Windows.Forms.TextBox Arr1MTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Arr2NTextBox;
        private System.Windows.Forms.TextBox Arr2MTextBox;
        private System.Windows.Forms.Label label4;
    }
}

