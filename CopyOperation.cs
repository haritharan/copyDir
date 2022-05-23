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

namespace CopyDirectory
{
    public partial class CopyOperation : UserControl
    {
        public string selected_copyPath { get; set; }
        public string selected_pastePath { get; set; }

        public CopyOperation()
        {
            InitializeComponent();
        }

        private void CopyOperation_Load(object sender, EventArgs e)
        {
            try
            {
                Copy(selected_copyPath, selected_pastePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Copy(string copyPath, string pastePath)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(copyPath);

                DirectoryInfo di = new DirectoryInfo(copyPath);
                string[] files = Directory.GetFiles(copyPath);

                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);

                    try
                    {
                        richText_log.Text = "\n\n COPYING FROM: " + fi.FullName + "\n TO: " + pastePath + '\\' + fi.Name + "\n\n" + richText_log.Text; ;
                        richText_log.ScrollToCaret();

                        await CopyDir(di.FullName, pastePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Copy Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (dirs.Length > 0)
                {
                    foreach (string dir in dirs)
                    {
                        di = new DirectoryInfo(dir);
                        richText_log.Text = "\n\n CREATING FOLDER: " + pastePath + '\\' + di.Name + "\n\n" + richText_log.Text;
                        Directory.CreateDirectory(pastePath + '\\' + di.Name);
                        files = Directory.GetFiles(dir);

                        foreach (string file in files)
                        {
                            FileInfo fi = new FileInfo(file);

                            try
                            {
                                richText_log.Text = "\n\n COPYING FROM: " + fi.FullName + "\n TO: " + pastePath + '\\' + di.Name + '\\' + fi.Name + "\n\n" + richText_log.Text;
                                richText_log.ScrollToCaret();
                                await CopyDir(di.FullName, pastePath + '\\' + di.Name);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Copy Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        Copy(di.FullName, pastePath + '\\' + di.Name);
                    }
                }
                richText_log.Text = "\n\n" + "COPYING OPERATION COMPLETE!!!" + richText_log.Text;
                richText_log.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // resource: https://docs.microsoft.com/en-us/dotnet/api/system.io.stream.copytoasync?redirectedfrom=MSDN&view=net-5.0#System_IO_Stream_CopyToAsync_System_IO_Stream_
        private async Task CopyDir(string copyPath, string pastPath)
        {
            foreach (string filename in Directory.EnumerateFiles(copyPath))
            {
                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    using (FileStream DestinationStream = File.Create(pastPath + filename.Substring(filename.LastIndexOf('\\'))))
                    {
                        await SourceStream.CopyToAsync(DestinationStream);
                    }
                }
            }
        }
    }
}
