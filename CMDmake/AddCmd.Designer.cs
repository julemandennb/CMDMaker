namespace CMDmake
{
    partial class AddCmd
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
            this.CMDCombobox = new System.Windows.Forms.ComboBox();
            this.groupUrl = new System.Windows.Forms.GroupBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.groupUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMDCombobox
            // 
            this.CMDCombobox.FormattingEnabled = true;
            this.CMDCombobox.Items.AddRange(new object[] {
            "None"});
            this.CMDCombobox.Location = new System.Drawing.Point(306, 106);
            this.CMDCombobox.Name = "CMDCombobox";
            this.CMDCombobox.Size = new System.Drawing.Size(374, 21);
            this.CMDCombobox.TabIndex = 0;
            this.CMDCombobox.SelectedIndex = 0;
            this.CMDCombobox.SelectedIndexChanged += new System.EventHandler(this.CMDCombobox_SelectedIndexChanged);
            // 
            // groupUrl
            // 
            this.groupUrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupUrl.Controls.Add(this.labelUrl);
            this.groupUrl.Controls.Add(this.textBoxUrl);
            this.groupUrl.Location = new System.Drawing.Point(112, 168);
            this.groupUrl.Name = "groupUrl";
            this.groupUrl.Size = new System.Drawing.Size(794, 53);
            this.groupUrl.TabIndex = 1;
            this.groupUrl.TabStop = false;
            this.groupUrl.Visible = false;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(94, 19);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(651, 20);
            this.textBoxUrl.TabIndex = 0;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(53, 22);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(23, 13);
            this.labelUrl.TabIndex = 1;
            this.labelUrl.Text = "Url:";
            // 
            // AddCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 620);
            this.Controls.Add(this.groupUrl);
            this.Controls.Add(this.CMDCombobox);
            this.Name = "AddCmd";
            this.Text = "AddCmd";
            this.groupUrl.ResumeLayout(false);
            this.groupUrl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CMDCombobox;
        private System.Windows.Forms.GroupBox groupUrl;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label labelUrl;
    }
}