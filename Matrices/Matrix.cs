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
    public partial class Matrix : Form
    {
        MyData data1;
        public Matrix()
        {
            InitializeComponent();
        }
        
        public Matrix(MyData data)
        {
            InitializeComponent();
            data1 = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data1.Rows = Int32.Parse(numericUpDownRows.Value.ToString());
            data1.Cols = Int32.Parse(numericUpDownColumns.Value.ToString());
            this.Close();
            
        }
    }
}
