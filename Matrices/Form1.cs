using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices
{
    public partial class Form1 : Form
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Matrix matrix;
        MyData data;
        int total = 0;
        Label[,] labelArray;
        int locationWidth = 0;
        int locationHeight = 0;



        public Form1()
        {
            InitializeComponent();
            data = new MyData();
            matrix = new Matrix(data);
            matrix.Size = new Size(900, 600);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            matrix.ShowDialog();
            label1.Text = "25.522";
           
                        
        }

        private void SizeGroupBox()
        {
            int width;
            int height;
            switch (Columns)
            {
                case 1: 
                width = 200;
                     break;
                case 2:
                width = 500;
                    break;
                case 3:
                    width = 700;
                    break;
                case 4:
                    width = 900;
                    break;
                case 5:
                    width = 1200;
                    break;
                default:
                    width = 1600;
                    break;

            }
            switch (Rows)
            {
                case 1:
                    height = 200;
                    break;
                case 2:
                    height = 300;
                    break;
                case 3:
                    height = 400;
                    break;
                case 4:
                    height = 800;
                    break;
                case 5:
                    height = 1200;
                    break;
                default:
                    height = 1200;
                    break;
            }
            groupBox1.Size = new Size(width, height);
        }
   
        private void SetLabelLocations()
        {
            
                locationWidth = (groupBox1.Width - 100) / Columns;
                int widthIncrement = locationWidth;
                locationWidth -= widthIncrement;
                locationHeight = (groupBox1.Height - 100) / Rows;
                int heightIncrement = locationHeight;
                locationHeight -= heightIncrement;
                           
                 for (int i = 0;i < Rows;i++)
                 {
                      locationWidth = 50;
                      locationHeight += heightIncrement;
                    for (int j = 0;j < Columns;j++)
                    {

                        labelArray[i, j].Top = locationHeight;
                        labelArray[i, j].Left = locationWidth;
                    labelArray[i, j].Text = (i * j).ToString();
                    locationWidth += widthIncrement;
                    Debug.WriteLine(labelArray[i, j].Text);
                    Debug.WriteLine(labelArray[i, j].Location.ToString());


                    }
                 }

            //MessageBox.Show(labelArray.Length.ToString());

            
        }

        private void CheckLabelWidthsAfterSettingNumber()
        {
            int width = 150;
            int height = 150;
            groupBox1.Size = new Size(width, height);
        }

        private void CreateLabels()
        {
            Font font = new Font("Arial", 12);
            if (data != null & Rows > 0)
            {

                total = Rows * Columns;
                labelArray = new Label[Rows, Columns];
                Label label;

                for(int i = 0;i < Rows;i++)
                {   
                    for (int j = 0;j < Columns; j++)
                    {
                        label = new Label();
                        label.Font = font;
                        label.Name = "label" + i;
                        label.Text = i.ToString();
                        labelArray[i, j] = label;
                        this.groupBox1.Controls.Add(label);
                    }
                }
                
                
             //this.Controls.AddRange(new Control[] { labelArray[0], labelArray[1] });
            }
        }

        private void SetLabelFontSize()
        {
           
            
        }

        private void ClearGroupBox()
        {
            groupBox1.Controls.Clear();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                Rows = data.Rows;
                Columns = data.Cols;
                ClearGroupBox();
                SizeGroupBox();
                CreateLabels();
                SizeGroupBox();
                SetLabelLocations();


            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
