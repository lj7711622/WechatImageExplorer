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

namespace WechatExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum FileExtension
        {
            JPG = 255216,
            GIF = 7173,
            PNG = 13780,
            SWF = 6787,
            RAR = 8297,
            ZIP = 8075,
            _7Z = 55122,
            VALIDFILE = 9999999
        }


        private void button1_Click(object sender, EventArgs e)
        {
            initROOT(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\WeChat Files");
        }

        public static string current = "";

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.IsExpanded)
            {
                e.Node.Collapse();
            }
            else
            {
                e.Node.Nodes.Clear();
                listBox1.Items.Clear();
                current = e.Node.Text;
                statusStrip1.Text = e.Node.Text;
                statusStrip1.Show();
                DirectoryInfo dir = new DirectoryInfo(e.Node.Text);
                FileInfo[] fil = dir.GetFiles();
                DirectoryInfo[] dii = dir.GetDirectories();
                foreach (DirectoryInfo subDir in dii)
                {
                    e.Node.Nodes.Add(subDir.FullName);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo fileInfo in files)
                {
                    listBox1.Items.Add(fileInfo.Name);
                }
                e.Node.Expand();
            }

        }

        public void initROOT(string PATH)
        {
            treeView1.Nodes.Add(PATH);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileExtension fe = CheckTextFile(current + "\\" + this.listBox1.SelectedItem.ToString());
            if (fe == FileExtension.GIF || fe == FileExtension.JPG || fe == FileExtension.PNG) {
                pictureBox1.Image = Image.FromFile(current + "\\" + this.listBox1.SelectedItem.ToString());
            }
            

            if (current.Contains("Data")) {
                byte[] fileBytes = File.ReadAllBytes(current + "\\" + this.listBox1.SelectedItem.ToString());
                byte first = fileBytes[0];
                byte second = fileBytes[1];
                byte[] bs1 = new byte[] { 0xff,0x89,0x42,0x47};
                byte[] bs2 = new byte[] { 0xd8, 0x50, 0x4d, 0x49 };
                int i = 0;
                byte magic = 0x00;
                for (; i < 3; i++) {
                    if ((first ^ bs1[i]) == (second ^ bs2[i])) {
                        magic = bs1[i];
                    }
                }
                if (magic != 0x00) {
                    for (int j = 0; j < fileBytes.Length; j++)
                    {
                        fileBytes[j] = (byte)(magic ^ fileBytes[j] ^ first);
                    }
                    pictureBox1.Image = Image.FromStream(new MemoryStream(fileBytes));
                }
                
            }
        }
        public static FileExtension CheckTextFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
            string fileType = string.Empty; ;
            try
            {
                byte data = br.ReadByte();
                fileType += data.ToString();
                data = br.ReadByte();
                fileType += data.ToString();
                FileExtension extension;
                try
                {
                    extension = (FileExtension)Enum.Parse(typeof(FileExtension), fileType);
                }
                catch
                {

                    extension = FileExtension.VALIDFILE;
                }
                return extension;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    br.Close();
                }
            }
        }

    }
}

