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

        //Третье
        private Label label1T;
        private Label label2T;
        private Label RezultLabelT;
        private TextBox W1TextBoxT;
        private TextBox S1TextBoxT;
        private TextBox W2TextBoxT;
        private TextBox S2TextBoxT;
        private Button ShowResultBtnT;

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


        private void ShowThird()
        {
            // 
            // label1T
            // 
            this.label1T = new Label();
            this.label1T.AutoSize = true;
            this.label1T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1T.Location = new System.Drawing.Point(13, 58);
            this.label1T.Name = "label1T";
            this.label1T.Size = new System.Drawing.Size(192, 18);
            this.label1T.TabIndex = 1;
            this.label1T.Text = "Масса и Скорость первого тела";
            // 
            // W1TextBoxT
            // 
            this.W1TextBoxT = new TextBox();
            this.W1TextBoxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.W1TextBoxT.Location = new System.Drawing.Point(252, 55);
            this.W1TextBoxT.Name = "W1TextBoxT";
            this.W1TextBoxT.Size = new System.Drawing.Size(57, 24);
            this.W1TextBoxT.TabIndex = 2;
            // 
            // S1TextBoxT
            // 
            this.S1TextBoxT = new TextBox();
            this.S1TextBoxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S1TextBoxT.Location = new System.Drawing.Point(325, 55);
            this.S1TextBoxT.Name = "S1TextBoxT";
            this.S1TextBoxT.Size = new System.Drawing.Size(57, 24);
            this.S1TextBoxT.TabIndex = 2;
            // 
            // label2T
            // 
            this.label2T = new Label();
            this.label2T.AutoSize = true;
            this.label2T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2T.Location = new System.Drawing.Point(12, 92);
            this.label2T.Name = "label2T";
            this.label2T.Size = new System.Drawing.Size(192, 18);
            this.label2T.TabIndex = 1;
            this.label2T.Text = "Масса и Скорость второго тела";
            // 
            // W2TextBoxT
            // 
            this.W2TextBoxT = new TextBox();
            this.W2TextBoxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.W2TextBoxT.Location = new System.Drawing.Point(252, 89);
            this.W2TextBoxT.Name = "W2TextBoxT";
            this.W2TextBoxT.Size = new System.Drawing.Size(57, 24);
            this.W2TextBoxT.TabIndex = 2;
            // 
            // S2TextBoxT
            // 
            this.S2TextBoxT = new TextBox();
            this.S2TextBoxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S2TextBoxT.Location = new System.Drawing.Point(325, 89);
            this.S2TextBoxT.Name = "S2TextBoxT";
            this.S2TextBoxT.Size = new System.Drawing.Size(57, 24);
            this.S2TextBoxT.TabIndex = 2;
            // 
            // ShowResultBtnT
            // 
            this.ShowResultBtnT = new Button();
            this.ShowResultBtnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowResultBtnT.Location = new System.Drawing.Point(13, 124);
            this.ShowResultBtnT.Name = "ShowResultBtnT";
            this.ShowResultBtnT.Size = new System.Drawing.Size(192, 38);
            this.ShowResultBtnT.TabIndex = 3;
            this.ShowResultBtnT.Text = "Рассчитать";
            this.ShowResultBtnT.UseVisualStyleBackColor = true;
            this.ShowResultBtnT.Click += new System.EventHandler(this.ThirdResultButton_Click);
            // 
            // RezultLabelT
            // 
            this.RezultLabelT = new Label();
            this.RezultLabelT.AutoSize = true;
            this.RezultLabelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RezultLabelT.Location = new System.Drawing.Point(13, 184);
            this.RezultLabelT.Name = "RezultLabelT";
            this.RezultLabelT.Size = new System.Drawing.Size(0, 25);
            this.RezultLabelT.TabIndex = 1;


            this.Controls.Add(this.label1T);
            this.Controls.Add(this.label2T);
            this.Controls.Add(this.RezultLabelT);

            this.Controls.Add(this.W1TextBoxT);
            this.Controls.Add(this.S1TextBoxT);
            this.Controls.Add(this.W2TextBoxT);
            this.Controls.Add(this.S2TextBoxT);
            this.Controls.Add(this.ShowResultBtnT);
        }

        private void ThirdResultButton_Click(object sender, EventArgs e)
        {
            Tasks.Body body1 = new Tasks.Body(Convert.ToDecimal(W1TextBoxT.Text), Convert.ToDecimal(S1TextBoxT.Text));
            Tasks.Body body2 = new Tasks.Body(Convert.ToDecimal(W2TextBoxT.Text), Convert.ToDecimal(S2TextBoxT.Text));
            RezultLabelT.Text = $"Тело 1: {body1.FindKineticEnergy()}{"\n"}Тело 2: {body2.FindKineticEnergy()}";
        }

        private void HideThird()
        {
            if (label1T == null)
                return;

            label1T.Dispose();
            label2T.Dispose();
            RezultLabelT.Dispose();
            W1TextBoxT.Dispose();
            S1TextBoxT.Dispose();
            W2TextBoxT.Dispose();
            S2TextBoxT.Dispose();
            ShowResultBtnT.Dispose();
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
            label3.Hide();
            label4.Hide();
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
                    HideThird();
                    HideSecond();
                    break;
                case 1:
                    HideFirst();
                    HideSecond();
                    HideThird();
                    break;
                case 2:
                    HideFirst();
                    ShowThird();
                    HideSecond();
                    break;
                case 3:
                    HideFirst();
                    HideThird();
                    ShowSecond();
                    break;
               
            }
        }


        private void FillButton_Click(object sender, EventArgs e)
        {
            matrix1 = new Matrix(Convert.ToInt32(Arr1NTextBox.Text), Convert.ToInt32(Arr1MTextBox.Text));
            matrix2 = new Matrix(Convert.ToInt32(Arr2NTextBox.Text), Convert.ToInt32(Arr2MTextBox.Text));
            matrix1.FillMatrixRandom(DateTime.Now.Millisecond);
            matrix2.FillMatrixRandom(DateTime.Now.Second);
            WriteData(dataGridView1, matrix1);
            System.Threading.Thread.Sleep(3);
            WriteData(dataGridView2, matrix2);
        }

        private void do_button_Click(object sender, EventArgs e)
        {
            if (acs.SelectedIndex == 1)
            {
                WriteData(dataGridView3, matrix1.MultiplicationMatrix(matrix2));
            }
            else if (acs.SelectedIndex == 0)
            {
                WriteData(dataGridView3, matrix1.Additionmatrix(matrix2));
            }
        }
    }
}
