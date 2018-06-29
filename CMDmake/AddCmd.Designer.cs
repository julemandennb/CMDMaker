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
            this.SuspendLayout();
            // 
            // CMDCombobox
            // 
            this.CMDCombobox.FormattingEnabled = true;
            this.CMDCombobox.Location = new System.Drawing.Point(306, 106);
            this.CMDCombobox.Name = "CMDCombobox";
            this.CMDCombobox.Size = new System.Drawing.Size(374, 21);
            this.CMDCombobox.Items.AddRange(new object[] {
            "None"});
            this.CMDCombobox.SelectedIndex = 0;
            this.CMDCombobox.TabIndex = 0;
            // 
            // AddCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 620);
            this.Controls.Add(this.CMDCombobox);
            this.Name = "AddCmd";
            this.Text = "AddCmd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CMDCombobox;
    }
}