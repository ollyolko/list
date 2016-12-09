using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class commander : Form
    {
        public commander()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listViewPanel1.Items.Add(textBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem currentItem in listViewPanel1.SelectedItems)
            {
                listViewPanel1.Items.Remove(currentItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show("c:\\");
        }

        public void show(string str)
        {
            listViewPanel1.Clear();
            var folder = Directory.GetDirectories(str);
            foreach (var fol in folder)
            {
                listViewPanel1.Items.Add(fol);
            }

            var file = Directory.GetFiles(str);
            foreach (var ste in file)
            {
                listViewPanel1.Items.Add(ste);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show("d:\\");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var drivers = Environment.GetLogicalDrives();
            foreach (var item in drivers)
            {
                
                ToolStripButton items = new ToolStripButton();
                items.Text = item.ToString();
                items.DisplayStyle=ToolStripItemDisplayStyle.ImageAndText;
                items.Image =Image.FromFile("..\\..\\hard.ico");
                //items.Click += toolStripBotton_CLick();
                items.Click+=new EventHandler(toolStripBotton_CLick);
                tsPanel2.Items.Add(items);
            }
        }

        private void toolStripBotton_CLick(object sender, EventArgs e)
        {
            show("d:\\");
        }
    }
}
