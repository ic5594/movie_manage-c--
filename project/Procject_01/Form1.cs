using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Procject_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 콤보 박스 리스트 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Details");
            comboBox1.Items.Add("SmallIcon");
            comboBox1.Items.Add("LargeIcon");
            comboBox1.Items.Add("List");
            comboBox1.Items.Add("Tile");
          
            comboBox1.SelectedIndex = 0;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //노드 이름
            TreeNode root = treeview.Nodes.Add("즐겨찾기");

            string[] surch = Directory.GetLogicalDrives();
            foreach (string drive in surch)
            {
                TreeNode node = root.Nodes.Add(drive);
                node.Nodes.Add("@%");
            }
        }
        private void treeview_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode current = e.Node;

            if (current.Nodes.Count == 1 && current.Nodes[0].Text.Equals("@%"))
            {
                current.Nodes.Clear();

                String path = current.FullPath.Substring(current.FullPath.IndexOf(@"\") + 1);

                try // 하위 장치(목록)이 없을 경우 예외 처리
                {
                    string[] directories = Directory.GetDirectories(path);
                    foreach (string directory in directories)
                    {
                        TreeNode newNode = current.Nodes.Add(directory.Substring(directory.LastIndexOf("\\") + 1));
                        newNode.Nodes.Add("@%");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       

        private void treeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode current = e.Node;
            string path = current.FullPath;

            txtPath.Text = path.Substring(path.IndexOf(@"\")+1);

            try
            {
                lvFile.Items.Clear();

                //디렉토리 목록 표시
                string[] directories = Directory.GetDirectories(txtPath.Text);
                foreach (string directory in directories)
                {
                    DirectoryInfo info = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        
                        info.Name, "",
                        "파일폴더", info.LastWriteTime.ToString()
                    });
                    item.ImageIndex = 2;
                    
                    lvFile.Items.Add(item);
                }


                //파일 목록 표시
                string[] files = Directory.GetFiles(txtPath.Text);

                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        info.Name, info.Length.ToString(),
                        info.Extension, info.LastWriteTime.ToString()
                    });
                    lvFile.Items.Add(item);
                    item.ImageIndex = 4;
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            //경로 받기.
            string path = txtPath.Text;
            MessageBox.Show(path);
            // 문자열 합치기
            string a = path.Substring(3);
            string b = path.Substring(0,2);
            
            string path1 =  b + a;
            MessageBox.Show(path1);
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = path1;
            dialog.ShowDialog();

            txtPath.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Details":
                    lvFile.View = View.Details;
                    break;
                case "SmallIcon":
                    lvFile.View = View.SmallIcon;
                    break;
                case "LargeIcon":
                    lvFile.View = View.LargeIcon;
                    break;
                case "List":
                    lvFile.View = View.List;
                    break;
                case "Tile":
                    lvFile.View = View.Tile;
                    break;
            }
        }
        public string path;
        private void button2_Click(object sender, EventArgs e)
        {
            //경로받기
            string path = txtPath.Text;
            string c;
            // 문자열 합치기
            string a = path.Substring(3);
            string b = path.Substring(0, 2);
           
            string path1 = b +"\\" +a; // 경로
            MessageBox.Show(path);
            //label2.Text = txtPath.Text;

            
            //경로 저장
            DirectoryInfo direct = new DirectoryInfo(path);
            FileInfo[] get = direct.GetFiles(textBox1.Text, SearchOption.AllDirectories);

            txtPath.Clear();
            lvFile.Items.Clear();
            try
            {
                
                foreach (FileInfo fi in get)
                {
                    lvFile.Items.Add(new ListViewItem(new string[] { fi.Name, fi.Extension,fi.Length.ToString()}));
                    txtPath.Text = fi.DirectoryName;
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void lvFile_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtPath.Text);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
           
        }

        private void treeview_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}

     
