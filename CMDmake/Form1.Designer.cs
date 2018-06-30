namespace CMDmake
{
    partial class Form1
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
            this.cmdAddList = new System.Windows.Forms.ListBox();
            this.AddCmd = new System.Windows.Forms.Button();
            this.buttonMaker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAddList
            // 
            this.cmdAddList.FormattingEnabled = true;
            this.cmdAddList.Location = new System.Drawing.Point(0, 0);
            this.cmdAddList.Name = "cmdAddList";
            this.cmdAddList.Size = new System.Drawing.Size(363, 745);
            this.cmdAddList.TabIndex = 0;
            // 
            // AddCmd
            // 
            this.AddCmd.Location = new System.Drawing.Point(451, 219);
            this.AddCmd.Name = "AddCmd";
            this.AddCmd.Size = new System.Drawing.Size(205, 152);
            this.AddCmd.TabIndex = 1;
            this.AddCmd.Text = "ADD";
            this.AddCmd.UseVisualStyleBackColor = true;
            this.AddCmd.Click += new System.EventHandler(this.AddCmd_Click);
            // 
            // buttonMaker
            // 
            this.buttonMaker.Location = new System.Drawing.Point(722, 219);
            this.buttonMaker.Name = "buttonMaker";
            this.buttonMaker.Size = new System.Drawing.Size(205, 152);
            this.buttonMaker.TabIndex = 2;
            this.buttonMaker.Text = "Make Cmd";
            this.buttonMaker.UseVisualStyleBackColor = true;
            this.buttonMaker.Click += new System.EventHandler(this.buttonMaker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 747);
            this.Controls.Add(this.buttonMaker);
            this.Controls.Add(this.AddCmd);
            this.Controls.Add(this.cmdAddList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cmdAddList;
        private System.Windows.Forms.Button AddCmd;
        private System.Windows.Forms.Button buttonMaker;
    }
}

