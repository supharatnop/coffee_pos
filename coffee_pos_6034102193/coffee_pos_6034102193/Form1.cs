using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_6034102193
{
    public partial class Form1 : Form
    {
        string sn = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }
        public void coflist(string menu,string bath)
        {
            string[] BM = { menu, bath };
            var listview = new ListViewItem(BM);
            listView1.Items.Add(listview);
            ListPrice();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            coflist("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coflist("Esspresso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coflist("Esspresso(Frappe)", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coflist("Americano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coflist("Americano(Ice)", "45");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coflist("Latte(Hot)", "35");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            coflist("Latte(Ice)", "45");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            coflist("Latte(Frappe)", "50");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            coflist("Mocha(Hot)", "35");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            coflist("Mocha(Ice)", "45");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            coflist("Mocha(Frappe)", "50");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            coflist("Cappuccino(Hot)", "35");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            coflist("Cappuccino(Ice)", "45");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            coflist("Cappuccino(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            coflist("Green Tea(Hot)", "20");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            coflist("Green Tea(Ice)", "25");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            coflist("Green Tea(Frappe)", "30");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            coflist("Thai Tea(Hot)", "20");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            coflist("Thai Tea(Ice)", "25");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            coflist("Thai Tea(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            coflist("CoCoa(Hot)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            coflist("CoCoa(Ice)", "25");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            coflist("CoCoa(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            coflist("Milk(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            coflist("Milk(Ice)", "25");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            coflist("Milk(Frappe)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            coflist("Milk Tea(Ice)", "25");
        }

        private void button288_Click(object sender, EventArgs e)
        {
            coflist("Milk Tea(Frappe)", "30");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            coflist("Lemon Tea(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            coflist("Lemon Tea(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            coflist("Milo(Hot)", "20");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            coflist("Milo(Ice)", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            coflist("Milo(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            coflist("Nescafe(Hot)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            coflist("Nescafe(Ice)", "25");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            coflist("Nescafe(Frappe)", "30");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            coflist("Nastea Tea(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            coflist("Nastea Tea(Ice)", "25");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            coflist("Nastea Tea(Frappe)", "20");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            coflist("Italian Soda", "25");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            coflist("Red lime Soda", "25");
        }
        private void button42_Click(object sender, EventArgs e)
        {
            coflist("Honey lime Soda", "25");
        }


        double pr;
        public string[] ListPrice()
        {
            pr = 0;
            string[] a = new string[listView1.Items.Count];
            int li = listView1.Items.Count;
            for (int i = 0; i < li; i++) 
            {
                pr += double.Parse(listView1.Items[i].SubItems[1].Text);
                a[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            labelPrice.Text = pr.ToString();
            return a;
        }

        public string[] inListPrice()
        {
            string[] a = new string[listView1.Items.Count];
            int li = listView1.Items.Count;
            for (int i = 0; i < li; i++)
            {
                a[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return a;
        }


        public void sef()
        {
            string[] su = ListPrice();
            string[] no = inListPrice();
            string file = "KaToei_coffe" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string filebill = "KaToei_coffe";
            filebill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm/yyyy") + "\r\n" + "\r\n";
            filebill += "Menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++ )
            {
                filebill += su[i] + new string(' ', 20) + no[i] + " Bath" + "\r\n";
            }
            filebill += "\r\n";
            filebill += "Total Price : " + labelPrice.Text;
            System.IO.File.WriteAllText(sn + @"\" + file + ".txt", filebill);
            labelPa.Text += filebill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + sn + @"\" + file + ".txt";
        }


        bool ok = false;
        private void button28_Click(object sender, EventArgs e)
        {
            labelPa.Text = "";
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                ok = true;
                tabControl1.SelectedTab = Payment;
            }
            else tabControl1.SelectedTab = Payment;

            if (listView1.Items.Count > 0)
                sef();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ok = false;
            tabControl1.Controls.Remove(Payment);
            labelPrice.Text = "";
        }
    }
}
