
namespace CopyDirectory
{
    partial class CopyDir2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Navigation = new System.Windows.Forms.GroupBox();
            this.button_minus = new System.Windows.Forms.Button();
            this.btn_NewCopy = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.groupBox_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Navigation
            // 
            this.groupBox_Navigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Navigation.Controls.Add(this.button_minus);
            this.groupBox_Navigation.Controls.Add(this.btn_NewCopy);
            this.groupBox_Navigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Navigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Navigation.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Navigation.Name = "groupBox_Navigation";
            this.groupBox_Navigation.Size = new System.Drawing.Size(694, 53);
            this.groupBox_Navigation.TabIndex = 1;
            this.groupBox_Navigation.TabStop = false;
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.Red;
            this.button_minus.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_minus.Location = new System.Drawing.Point(131, 16);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 34);
            this.button_minus.TabIndex = 3;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // btn_NewCopy
            // 
            this.btn_NewCopy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_NewCopy.Location = new System.Drawing.Point(3, 16);
            this.btn_NewCopy.Name = "btn_NewCopy";
            this.btn_NewCopy.Size = new System.Drawing.Size(128, 34);
            this.btn_NewCopy.TabIndex = 0;
            this.btn_NewCopy.Text = "New Copy Operation";
            this.btn_NewCopy.UseVisualStyleBackColor = true;
            this.btn_NewCopy.Click += new System.EventHandler(this.btn_NewCopy_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 53);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(694, 228);
            this.tabControl.TabIndex = 0;
            // 
            // CopyDir2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 281);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox_Navigation);
            this.MaximumSize = new System.Drawing.Size(720, 320);
            this.Name = "CopyDir2";
            this.ShowIcon = false;
            this.Text = "CopyDir2";
            this.Load += new System.EventHandler(this.CopyDir2_Load);
            this.groupBox_Navigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Navigation;
        private System.Windows.Forms.Button btn_NewCopy;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button button_minus;
    }
}