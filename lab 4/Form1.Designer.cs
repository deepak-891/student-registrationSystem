namespace lab_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.addLink = new System.Windows.Forms.LinkLabel();
            this.modifyLink = new System.Windows.Forms.LinkLabel();
            this.Search = new System.Windows.Forms.LinkLabel();
            this.viewLink = new System.Windows.Forms.LinkLabel();
            this.changePassword = new System.Windows.Forms.LinkLabel();
            this.Fee = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(280, 20, 280, 10);
            this.label1.Size = new System.Drawing.Size(747, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER CHOICES";
            // 
            // addLink
            // 
            this.addLink.AutoSize = true;
            this.addLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addLink.Location = new System.Drawing.Point(90, 101);
            this.addLink.Name = "addLink";
            this.addLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addLink.Size = new System.Drawing.Size(229, 16);
            this.addLink.TabIndex = 7;
            this.addLink.TabStop = true;
            this.addLink.Text = "ADD APLIICANT INFORMATION";
            this.addLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addLink_LinkClicked);
            // 
            // modifyLink
            // 
            this.modifyLink.AutoSize = true;
            this.modifyLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.modifyLink.Location = new System.Drawing.Point(90, 200);
            this.modifyLink.Name = "modifyLink";
            this.modifyLink.Size = new System.Drawing.Size(260, 16);
            this.modifyLink.TabIndex = 8;
            this.modifyLink.TabStop = true;
            this.modifyLink.Text = "MODIFY APPLICANT INFORMATION";
            this.modifyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.modifyLink_LinkClicked);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Search.Location = new System.Drawing.Point(99, 294);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(265, 16);
            this.Search.TabIndex = 9;
            this.Search.TabStop = true;
            this.Search.Text = "SEARCH APPLICANT INFORMATION";
            this.Search.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Search_LinkClicked);
            // 
            // viewLink
            // 
            this.viewLink.AutoSize = true;
            this.viewLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.viewLink.Location = new System.Drawing.Point(481, 101);
            this.viewLink.Name = "viewLink";
            this.viewLink.Size = new System.Drawing.Size(245, 16);
            this.viewLink.TabIndex = 10;
            this.viewLink.TabStop = true;
            this.viewLink.Text = "VIEW APPLICANT INFORMATION ";
            this.viewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewLink_LinkClicked);
            // 
            // changePassword
            // 
            this.changePassword.AutoSize = true;
            this.changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.changePassword.Location = new System.Drawing.Point(473, 200);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(162, 16);
            this.changePassword.TabIndex = 11;
            this.changePassword.TabStop = true;
            this.changePassword.Text = "CHANGE PASSWORD";
            this.changePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePassword_LinkClicked);
            // 
            // Fee
            // 
            this.Fee.AutoSize = true;
            this.Fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee.LinkColor = System.Drawing.Color.Blue;
            this.Fee.Location = new System.Drawing.Point(481, 292);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(106, 16);
            this.Fee.TabIndex = 12;
            this.Fee.TabStop = true;
            this.Fee.Text = "FEE RECEIPT";
            this.Fee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Fee_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 379);
            this.Controls.Add(this.Fee);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.viewLink);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.modifyLink);
            this.Controls.Add(this.addLink);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel addLink;
        private System.Windows.Forms.LinkLabel modifyLink;
        private System.Windows.Forms.LinkLabel Search;
        private System.Windows.Forms.LinkLabel viewLink;
        private System.Windows.Forms.LinkLabel changePassword;
        private System.Windows.Forms.LinkLabel Fee;
    }
}

