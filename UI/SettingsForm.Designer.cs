namespace UI
{
    partial class SettingsForm
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
            this.ButtonBoardSize = new System.Windows.Forms.Button();
            this.ButtonAgainstPC = new System.Windows.Forms.Button();
            this.ButtonAgainstFriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBoardSize
            // 
            this.ButtonBoardSize.Location = new System.Drawing.Point(12, 12);
            this.ButtonBoardSize.Name = "ButtonBoardSize";
            this.ButtonBoardSize.Size = new System.Drawing.Size(344, 57);
            this.ButtonBoardSize.TabIndex = 0;
            this.ButtonBoardSize.Text = "Board size: 6x6 (Click to increase)";
            this.ButtonBoardSize.UseVisualStyleBackColor = true;
            this.ButtonBoardSize.Click += new System.EventHandler(this.ButtonBoardSize_Click);
            // 
            // ButtonAgainstPC
            // 
            this.ButtonAgainstPC.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAgainstPC.Location = new System.Drawing.Point(12, 75);
            this.ButtonAgainstPC.Name = "ButtonAgainstPC";
            this.ButtonAgainstPC.Size = new System.Drawing.Size(160, 61);
            this.ButtonAgainstPC.TabIndex = 1;
            this.ButtonAgainstPC.Text = "Play against the computer";
            this.ButtonAgainstPC.UseVisualStyleBackColor = true;
            this.ButtonAgainstPC.Click += new System.EventHandler(this.AgainstPc_Click);
            // 
            // ButtonAgainstFriend
            // 
            this.ButtonAgainstFriend.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAgainstFriend.Location = new System.Drawing.Point(178, 75);
            this.ButtonAgainstFriend.Name = "ButtonAgainstFriend";
            this.ButtonAgainstFriend.Size = new System.Drawing.Size(178, 61);
            this.ButtonAgainstFriend.TabIndex = 2;
            this.ButtonAgainstFriend.Text = "Play against your friend";
            this.ButtonAgainstFriend.UseVisualStyleBackColor = true;
            this.ButtonAgainstFriend.Click += new System.EventHandler(this.ButtonAgainstFriend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 148);
            this.Controls.Add(this.ButtonAgainstFriend);
            this.Controls.Add(this.ButtonAgainstPC);
            this.Controls.Add(this.ButtonBoardSize);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(386, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(386, 195);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Othello - Game Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBoardSize;
        private System.Windows.Forms.Button ButtonAgainstPC;
        private System.Windows.Forms.Button ButtonAgainstFriend;
    }
}

