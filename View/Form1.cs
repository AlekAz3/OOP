using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasks;

namespace View
{
    public partial class Form1 : Form
    {
        //Первое
        private Label label1;
        private Label label2;
        private Label RezultLabel;
        private TextBox x1TextBox;
        private TextBox y1TextBox;
        private TextBox x2TextBox;
        private TextBox y2TextBox;
        private Button ShowResultBtn;

        // Матрица
        private Matrix matrix1;
        private Matrix matrix2;
        private Matrix matrix3;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChooseAction.SelectedIndex = 0;
            acs.SelectedIndex = 0;
        }

        private void ShowFirst()
        {
            // 
            // label1
            // 
            this.label1 = new Label();
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координаты первой точки";
            // 
            // x1TextBox
            // 
            this.x1TextBox = new TextBox();
            this.x1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1TextBox.Location = new System.Drawing.Point(212, 55);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(57, 24);
            this.x1TextBox.TabIndex = 2;
            // 
            // y1TextBox
            // 
            this.y1TextBox = new TextBox();
            this.y1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y1TextBox.Location = new System.Drawing.Point(275, 55);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(57, 24);
            this.y1TextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2 = new Label();
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Координаты второй точки";
            // 
            // x2TextBox
            // 
            this.x2TextBox = new TextBox();
            this.x2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2TextBox.Location = new System.Drawing.Point(212, 89);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(57, 24);
            this.x2TextBox.TabIndex = 2;
            // 
            // y2TextBox
            // 
            this.y2TextBox = new TextBox();
            this.y2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y2TextBox.Location = new System.Drawing.Point(275, 89);
            this.y2TextBox.Name = "y2TextBox";
            this.y2TextBox.Size = new System.Drawing.Size(57, 24);
            this.y2TextBox.TabIndex = 2;
            // 
            // ShowResultBtn
            // 
            this.ShowResultBtn = new Button();
            this.ShowResultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowResultBtn.Location = new System.Drawing.Point(13, 124);
            this.ShowResultBtn.Name = "ShowResultBtn";
            this.ShowResultBtn.Size = new System.Drawing.Size(192, 38);
            this.ShowResultBtn.TabIndex = 3;
            this.ShowResultBtn.Text = "Рассчитать";
            this.ShowResultBtn.UseVisualStyleBackColor = true;
            this.ShowResultBtn.Click += new System.EventHandler(this.FirstResultButton_Click);
            // 
            // RezultLabel
            // 
            this.RezultLabel = new Label();
            this.RezultLabel.AutoSize = true;
            this.RezultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RezultLabel.Location = new System.Drawing.Point(13, 184);
            this.RezultLabel.Name = "RezultLabel";
            this.RezultLabel.Size = new System.Drawing.Size(0, 25);
            this.RezultLabel.TabIndex = 1;


            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RezultLabel);

            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.y1TextBox);
            this.Controls.Add(this.x2TextBox);
            this.Controls.Add(this.y2TextBox);
            this.Controls.Add(this.ShowResultBtn);
    }

        private void HideFirst()
        {
            if (label1 == null)
                return;
            
            label1.Dispose();
            label2.Dispose();
            RezultLabel.Dispose();
            x1TextBox.Dispose();
            y1TextBox.Dispose();
            x2TextBox.Dispose();
            y2TextBox.Dispose();
            ShowResultBtn.Dispose();
        }


        private void ShowSecond() 
        {
            dataGridView1.Show();
            dataGridView2.Show();
            dataGridView3.Show();
            acs.Show();
            do_button.Show();
            FillButton.Show();
            label3.Show();
            label4.Show();
            Arr1MTextBox.Show();
            Arr1NTextBox.Show();
            Arr2NTextBox.Show();
            Arr2MTextBox.Show();

        }

        private void HideSecond()
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            acs.Hide();
            do_button.Hide();
            FillButton.Hide();
            Arr1MTextBox.Hide();
            Arr1NTextBox.Hide();
            Arr2NTextBox.Hide();
            Arr2MTextBox.Hide();
        }


        public void WriteData(DataGridView dataGridView, Matrix matrix)
        {
            dataGridView.RowCount = matrix.N;
            dataGridView.ColumnCount = matrix.M;
            for (int i = 0; i < matrix.N; i++)
                for (int j = 0; j < matrix.M; j++)
                    dataGridView.Rows[i].Cells[j].Value = matrix.Matrixx[i, j];
        }



        public void FirstResultButton_Click(object sender, EventArgs e)
        {
            Tasks.Point point1 = new Tasks.Point(Convert.ToDouble(x1TextBox.Text), Convert.ToDouble(y1TextBox.Text));
            Tasks.Point point2 = new Tasks.Point(Convert.ToDouble(x2TextBox.Text), Convert.ToDouble(y2TextBox.Text));
            RezultLabel.Text = Tasks.Point.FindDistance(point1, point2).ToString();
        }

        private void ChooseAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChooseAction.SelectedIndex)
            {
                case 0:
                    ShowFirst();
                    HideSecond();
                    break;
                case 1:
                    HideFirst();
                    HideSecond();
                    break;
                case 2:
                    HideFirst();
                    HideSecond();
                    break;
                case 3:
                    HideFirst();
                    ShowSecond();
                    break;

            }
        }

        private void FillButton_Click(object sender, EventArgs e)
        {

        }
    }
}
