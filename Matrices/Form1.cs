using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int width = 0;
        int height = 0;
        int total = 0;
        Label[] labelArray;



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
                        
        }

        private void SizeGroupBox(int matrixWidth, int matrixHeight)
        {
           int width = matrixHeight * 150;
            int height = matrixHeight * 100;
            groupBox1.Size = new Size(width, height);
        }

        private void SetLabelLocations(int matrixWidth, int matrixHeight)
        {
            int width = matrixHeight * 150;
            int height = matrixHeight * 100;
            groupBox1.Size = new Size(width, height);
        }

        private void CheckLabelWidthsAfterSettingNumber(int matrixWidth, int matrixHeight)
        {
            int width = matrixHeight * 150;
            int height = matrixHeight * 100;
            groupBox1.Size = new Size(width, height);
        }

        private void CreateLabelsFromMyData()
        {
            if (data != null)
            {
                width = data.Rows;
                height = data.Cols;
                total = width * height;
                labelArray = new Label[total];

                for(int i = 1;i <= total;i++)
                {
                    labelArray[i] = new Label();
                    this.Controls.Add(labelArray[i]);
                    this.groupBox1.Controls.Add(labelArray[i]);
                }
                //this.Controls.AddRange(new Control[] { labelArray[0], labelArray[1] });



            }
        }

        private void SetLabelFontSize(int matrixWidth, int matrixHeight)
        {
            int width = matrixHeight * 150;
            int height = matrixHeight * 100;
            groupBox1.Size = new Size(width, height);
        }



        private void Form1_Activated(object sender, EventArgs e)
        {
            if (data != null)
            {
                //label9.Text = data.Rows.ToString();
                //label11.Text = data.Cols.ToString();
            }
            
        }
    }
}
