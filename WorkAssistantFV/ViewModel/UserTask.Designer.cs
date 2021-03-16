
namespace WorkAssistantFV.ViewModel
{
    partial class UserTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTask));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtForTask = new System.Windows.Forms.RichTextBox();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.bunifuCards1.BackColor = System.Drawing.Color.FloralWhite;
            this.bunifuCards1.BorderRadius = 15;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.MediumSeaGreen;
            this.bunifuCards1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuCards1.Controls.Add(this.txtForTask);
            this.bunifuCards1.Controls.Add(this.lblTime);
            this.bunifuCards1.Controls.Add(this.lblDate);
            this.bunifuCards1.Controls.Add(this.bunifuCheckBox1);
            this.bunifuCards1.Controls.Add(this.lblTitle);
            this.bunifuCards1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(25, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(220, 221);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 13;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(6, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(27, 27);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 7;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // txtForTask
            // 
            this.txtForTask.BackColor = System.Drawing.Color.White;
            this.txtForTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtForTask.ForeColor = System.Drawing.Color.Black;
            this.txtForTask.Location = new System.Drawing.Point(22, 58);
            this.txtForTask.Name = "txtForTask";
            this.txtForTask.ReadOnly = true;
            this.txtForTask.Size = new System.Drawing.Size(180, 95);
            this.txtForTask.TabIndex = 6;
            this.txtForTask.Text = "{task_description}";
            this.txtForTask.TextChanged += new System.EventHandler(this.txtForTask_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AllowParentOverrides = false;
            this.lblTime.AutoEllipsis = false;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(91, 185);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(81, 23);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "{task_time}";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblDate
            // 
            this.lblDate.AllowParentOverrides = false;
            this.lblDate.AutoEllipsis = false;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDate.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(91, 159);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(81, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "{task_date}";
            this.lblDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.BorderRadius = 12;
            this.bunifuCheckBox1.Checked = false;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(22, 168);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.Black;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.ForestGreen;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.Black;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(31, 31);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 3;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(50, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(96, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "{task_title}";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblTitle.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // UserTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "UserTask";
            this.Size = new System.Drawing.Size(270, 227);
            this.Load += new System.EventHandler(this.UserTask_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuLabel lblDate;
        private System.Windows.Forms.RichTextBox txtForTask;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}
