
namespace WorkAssistantFV.ViewModel
{
    partial class UserContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserContacts));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblPhone = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblLastName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFirstName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblEmail = new System.Windows.Forms.RichTextBox();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.bunifuCards1.BackColor = System.Drawing.Color.FloralWhite;
            this.bunifuCards1.BorderRadius = 15;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.MediumSeaGreen;
            this.bunifuCards1.Controls.Add(this.lblEmail);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.lblPhone);
            this.bunifuCards1.Controls.Add(this.lblLastName);
            this.bunifuCards1.Controls.Add(this.lblFirstName);
            this.bunifuCards1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(220, 221);
            this.bunifuCards1.TabIndex = 1;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // lblPhone
            // 
            this.lblPhone.AllowParentOverrides = false;
            this.lblPhone.AutoEllipsis = false;
            this.lblPhone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPhone.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(63, 170);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhone.Size = new System.Drawing.Size(208, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "{phone_number_contact}";
            this.lblPhone.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPhone.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblLastName
            // 
            this.lblLastName.AllowParentOverrides = false;
            this.lblLastName.AutoEllipsis = false;
            this.lblLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLastName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(63, 61);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastName.Size = new System.Drawing.Size(114, 23);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "{last_name}";
            this.lblLastName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLastName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AllowParentOverrides = false;
            this.lblFirstName.AutoEllipsis = false;
            this.lblFirstName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFirstName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(63, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstName.Size = new System.Drawing.Size(110, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "{first_name}";
            this.lblFirstName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFirstName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(21, 91);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(181, 8);
            this.bunifuSeparator1.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.FloralWhite;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(12, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.ReadOnly = true;
            this.lblEmail.Size = new System.Drawing.Size(197, 51);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "{e_mail}";
            // 
            // UserContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "UserContacts";
            this.Size = new System.Drawing.Size(235, 227);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuLabel lblPhone;
        private Bunifu.UI.WinForms.BunifuLabel lblLastName;
        private Bunifu.UI.WinForms.BunifuLabel lblFirstName;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.RichTextBox lblEmail;
    }
}
