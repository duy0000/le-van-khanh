using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace asm_app
{
    public partial class Form3 : Form
    {
        //string[] sinhvien = new string[6];

        public Form3()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
        }
        private List<string[]> dataList = new List<string[]>();
        private void btn1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(dataList);
          //  Form4 form4 = new Form4(listView1.Items.Cast<ListViewItem>().Select(item => item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text).ToArray()).ToList());

            form4.Show();
            this.Hide();
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = "";
            string address = "";
            string This = "";
            string last = "";
            string phone = "";
            string Case = "";

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                name = item.SubItems[0].Text;
                address = item.SubItems[1].Text;
                This = item.SubItems[2].Text;
                last = item.SubItems[3].Text;
                Case = item.SubItems[4].Text;
                phone = item.SubItems[5].Text;

            }
            /*if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string name = item.SubItems[0].Text;
                string address = item.SubItems[1].Text;
                string This = item.SubItems[2].Text;
                string last = item.SubItems[3].Text;
                string Case = item.SubItems[4].Text;
                string phone = item.SubItems[5].Text;

                Form2 form2 = new Form2();
                form2.ReceiveData(name, address, This, last, Case, phone);
                form2.Show();*/
       // }
            txb1.Text = name;
            txb2.Text = address;
            txb3.Text = This;
            txb4.Text = last;
            txb6.Text = phone;


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            /*
                        string name = txb1.Text;
                        string address = txb2.Text;
                        string This = txb3.Text;
                        string last = txb4.Text;
                        string Case = cbCase.Text;
                        string phone = txb6.Text;


                        ListViewItem item = new ListViewItem(name);
                        //item.SubItems.Add(name);
                        item.SubItems.Add(address);
                        item.SubItems.Add(This);
                        item.SubItems.Add(last);
                        item.SubItems.Add(Case);
                        item.SubItems.Add(phone);
                        item.Text = name;
                        //add data to listview
                        listView1.Items.Add(item);

                        //delete data in form
                        txb1.Text = null;
                        txb2.Text = null;
                        txb3.Text = null;
                        txb4.Text = null;
                        txb6.Text = null;
                        cbCase = null;
                        txb1.Focus();*/
            // Thêm dữ liệu vào ListView
            string name = txb1.Text;
            string address = txb2.Text;
            string This = txb3.Text;
            string last = txb4.Text;
            string Case = cbCase.Text;
            string phone = txb6.Text;

            string[] rowData = new string[] { name, address, This, last, Case, phone };
            dataList.Add(rowData); // Thêm dữ liệu vào danh sách

            ListViewItem item = new ListViewItem(rowData);
            listView1.Items.Add(item);

            // Xóa dữ liệu trong các trường nhập liệu
            txb1.Text = "";
            txb2.Text = "";
            txb3.Text = "";
            txb4.Text = "";
            cbCase.Text = "";
            txb6.Text = "";
            txb1.Focus();
        }
    

        private void btndelete_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.Items.Count - 1);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem item1 = new ListViewItem(txb1.Text);

                item1.SubItems.Add(txb2.Text);
                item1.SubItems.Add(txb3.Text);
                item1.SubItems.Add(txb4.Text);
                //item1.SubItems.Add(cbCase.Text);
                item1.SubItems.Add(txb6.Text);

                //add data to listview
                // MessageBox.Show(listView1.Items.ToString());
                listView1.Items.Add(item1);

                //delete data in form
                listView1.Items.Remove(listView1.SelectedItems[0]);

                txb1.Text = null;
                txb2.Text = null;
                txb3.Text = null;
                txb4.Text = null;
               // cbCase.SelectedIndex = -1;
                txb6.Text = null;
                txb1.Focus();

            }
        }
       
    }
}

