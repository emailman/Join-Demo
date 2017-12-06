using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Join_Demo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book_PublisherDataSet.DataTable1' table. You can move, or remove it, as needed.
            dataTable1TableAdapter.Fill(book_PublisherDataSet.DataTable1);
        }

        private void dataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
