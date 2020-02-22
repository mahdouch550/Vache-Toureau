namespace Vache_Toureau
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CreateSessionButton = new System.Windows.Forms.Button();
            this.SessionIDTextBox = new System.Windows.Forms.TextBox();
            this.JoinsSessionButton = new System.Windows.Forms.Button();
            this.CreatedSessionID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(60, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 10);
            this.label1.TabIndex = 0;
            // 
            // CreateSessionButton
            // 
            this.CreateSessionButton.Location = new System.Drawing.Point(71, 23);
            this.CreateSessionButton.Name = "CreateSessionButton";
            this.CreateSessionButton.Size = new System.Drawing.Size(124, 23);
            this.CreateSessionButton.TabIndex = 21;
            this.CreateSessionButton.Text = "Create Session";
            this.CreateSessionButton.UseVisualStyleBackColor = true;
            this.CreateSessionButton.Click += new System.EventHandler(this.CreateSessionButton_Click);
            // 
            // SessionIDTextBox
            // 
            this.SessionIDTextBox.Location = new System.Drawing.Point(71, 116);
            this.SessionIDTextBox.Name = "SessionIDTextBox";
            this.SessionIDTextBox.Size = new System.Drawing.Size(124, 20);
            this.SessionIDTextBox.TabIndex = 22;
            this.SessionIDTextBox.Tag = "Session ID";
            // 
            // JoinsSessionButton
            // 
            this.JoinsSessionButton.Location = new System.Drawing.Point(98, 154);
            this.JoinsSessionButton.Name = "JoinsSessionButton";
            this.JoinsSessionButton.Size = new System.Drawing.Size(75, 23);
            this.JoinsSessionButton.TabIndex = 23;
            this.JoinsSessionButton.Text = "Join Session";
            this.JoinsSessionButton.UseVisualStyleBackColor = true;
            // 
            // CreatedSessionID
            // 
            this.CreatedSessionID.Enabled = false;
            this.CreatedSessionID.Location = new System.Drawing.Point(71, 53);
            this.CreatedSessionID.Name = "CreatedSessionID";
            this.CreatedSessionID.Size = new System.Drawing.Size(124, 20);
            this.CreatedSessionID.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 198);
            this.Controls.Add(this.CreatedSessionID);
            this.Controls.Add(this.JoinsSessionButton);
            this.Controls.Add(this.SessionIDTextBox);
            this.Controls.Add(this.CreateSessionButton);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Vache Toureau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateSessionButton;
        private System.Windows.Forms.TextBox SessionIDTextBox;
        private System.Windows.Forms.Button JoinsSessionButton;
        private System.Windows.Forms.TextBox CreatedSessionID;
    }
}

