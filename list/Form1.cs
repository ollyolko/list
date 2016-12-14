using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace list
{
    public partial class commander : Form
    {
        public commander()
        {
            InitializeComponent();
        }

        public void show(string str, Label label, ListView listwiew)
        {
            label.Text = str;
            listwiew.Items.Clear();
            var folder = Directory.GetDirectories(str);
            foreach (var fol in folder)
            {
                DirectoryInfo dir = new DirectoryInfo(fol);
                listwiew.Items.Add(new ListViewItem(new []{dir.Name,"<DIR>", dir.CreationTime.ToShortDateString()}));
            }

            var file = Directory.GetFiles(str);
            foreach (var ste in file)
            {
                FileInfo ff = new FileInfo(ste);
                //listwiew.Items.Add(new ListViewItem(new []{ff.Name, ff.Length.ToString(), ff.CreationTime.ToShortDateString() }));
                ListViewItem item =new ListViewItem();
                item.Text = "ddd";
                item.SubItems.Add("dddere");
                item.SubItems.Add("dddere");
                
            }
        }
  

        private void Form1_Load(object sender, EventArgs e)
        {
            show("C:\\",currentDirLabel1,listViewPanel1);
            show("C:\\",currentDirLabel2,listViewPanel2);
            var drivers = Environment.GetLogicalDrives();
            foreach (var item in drivers)
            {
                ToolStripButton items = new ToolStripButton();
                items.Text = item;
                items.DisplayStyle=ToolStripItemDisplayStyle.ImageAndText;
                items.Image =Image.FromFile("..\\..\\hard.ico");
                items.Click += toolStripBotton_CLick;
                tsPanel2.Items.Add(items);
            }

            foreach (var item in drivers)
            {
                ToolStripButton items = new ToolStripButton();
                items.Text = item;
                items.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                items.Image = Image.FromFile("..\\..\\hard.ico");
                items.Click += toolStripBotton_CLickF;
                tsPanel1.Items.Add(items);
            }
        }

        void toolStripBotton_CLick(object sender, EventArgs e)
        {
            DriveInfo iii = new DriveInfo(sender.ToString());
            if (iii.IsReady)
            {
                show(sender.ToString(),currentDirLabel2,listViewPanel2);
            }
            else
            {
                MessageBox.Show("drive "+sender.ToString()+" exist","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void toolStripBotton_CLickF(object sender, EventArgs e)
        {
            DriveInfo iii = new DriveInfo(sender.ToString());
            if (iii.IsReady)
            {
                show(sender.ToString(), currentDirLabel1, listViewPanel1);
            }
            else
            {
                MessageBox.Show("drive " + sender.ToString() + " exist", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
