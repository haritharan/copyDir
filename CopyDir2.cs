using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyDirectory
{
    public partial class CopyDir2 : Form
    {
        public static int index = 1;
        public CopyDir2()
        {
            InitializeComponent();
        }

        private void CopyDir2_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();
        }

        private void btn_NewCopy_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Please select a folder to copy!";
            folderBrowserDialog.ShowNewFolderButton = false;
            var Result = folderBrowserDialog.ShowDialog();
            string copyPath = folderBrowserDialog.SelectedPath;
            if (Result == DialogResult.OK && copyPath.Length > 0)
            {
                folderBrowserDialog.Description = "Please select a folder to paste to!";
                folderBrowserDialog.ShowNewFolderButton = true;

                var Result2 = folderBrowserDialog.ShowDialog();
                string pastePath = folderBrowserDialog.SelectedPath;

                if (Result2 == DialogResult.OK && pastePath.Length > 0)
                {
                    CopyOperation co = new CopyOperation();
                    co.selected_copyPath = copyPath;
                    co.selected_pastePath = pastePath;

                    TabPage copyTab = new TabPage();
                    copyTab.Controls.Add(co);
                    copyTab.Name = index.ToString();
                    copyTab.Text = "Operation " + index;
                    tabControl.TabPages.Add(copyTab);

                    index++;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (tabControl.HasChildren)
            {
                TabPage tp = tabControl.SelectedTab;
                CopyOperation co = tp.Controls.Find("CopyOperation", true).FirstOrDefault() as CopyOperation;
                co.Dispose();
                tp.Dispose();
            }
        }
    }
}
