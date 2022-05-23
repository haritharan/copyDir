
namespace CopyDirectory
{
    partial class CopyOperation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.richText_log = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            // 
            // richText_log
            // 
            this.richText_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richText_log.BackColor = System.Drawing.Color.Black;
            this.richText_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText_log.ForeColor = System.Drawing.Color.Lime;
            this.richText_log.Location = new System.Drawing.Point(0, 0);
            this.richText_log.Name = "richText_log";
            this.richText_log.Size = new System.Drawing.Size(680, 200);
            this.richText_log.TabIndex = 1;
            this.richText_log.Text = "";
            // 
            // CopyOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.richText_log);
            this.Name = "CopyOperation";
            this.Size = new System.Drawing.Size(683, 203);
            this.Load += new System.EventHandler(this.CopyOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.RichTextBox richText_log;
    }
}
