using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace asm_app
{
    public partial class Form4 : Form
    {
        public Form4(List<string[]> dataList)
        {
            InitializeComponent();

            // Hiển thị dữ liệu từ Form3 trong ListView của Form4
            foreach (string[] rowData in dataList)
            {
                ListViewItem item = new ListViewItem(rowData);
                listView1.Items.Add(item);
            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnadddata_Click(object sender, EventArgs e)
        {
            
        }
    }
}
