
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTask));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.textForTask = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.lblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
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
            this.bunifuCards1.Controls.Add(this.lblTime);
            this.bunifuCards1.Controls.Add(this.lblDate);
            this.bunifuCards1.Controls.Add(this.bunifuCheckBox1);
            this.bunifuCards1.Controls.Add(this.textForTask);
            this.bunifuCards1.Controls.Add(this.lblTitle);
            this.bunifuCards1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(33, 19);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(179, 241);
            this.bunifuCards1.TabIndex = 0;
            // 
            // textForTask
            // 
            this.textForTask.AcceptsReturn = false;
            this.textForTask.AcceptsTab = false;
            this.textForTask.AnimationSpeed = 200;
            this.textForTask.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textForTask.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textForTask.BackColor = System.Drawing.Color.Transparent;
            this.textForTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textForTask.BackgroundImage")));
            this.textForTask.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textForTask.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textForTask.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textForTask.BorderColorIdle = System.Drawing.Color.Silver;
            this.textForTask.BorderRadius = 1;
            this.textForTask.BorderThickness = 1;
            this.textForTask.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textForTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textForTask.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textForTask.DefaultText = "{task_description}";
            this.textForTask.FillColor = System.Drawing.Color.White;
            this.textForTask.HideSelection = true;
            this.textForTask.IconLeft = null;
            this.textForTask.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textForTask.IconPadding = 10;
            this.textForTask.IconRight = null;
            this.textForTask.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textForTask.Lines = new string[] {
        "{task_description}"};
            this.textForTask.Location = new System.Drawing.Point(12, 40);
            this.textForTask.MaxLength = 32767;
            this.textForTask.MinimumSize = new System.Drawing.Size(1, 1);
            this.textForTask.Modified = false;
            this.textForTask.Multiline = false;
            this.textForTask.Name = "textForTask";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textForTask.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textForTask.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textForTask.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textForTask.OnIdleState = stateProperties4;
            this.textForTask.Padding = new System.Windows.Forms.Padding(3);
            this.textForTask.PasswordChar = '\0';
            this.textForTask.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textForTask.PlaceholderText = "Enter text";
            this.textForTask.ReadOnly = false;
            this.textForTask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textForTask.SelectedText = "";
            this.textForTask.SelectionLength = 0;
            this.textForTask.SelectionStart = 18;
            this.textForTask.ShortcutsEnabled = true;
            this.textForTask.Size = new System.Drawing.Size(155, 128);
            this.textForTask.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textForTask.TabIndex = 2;
            this.textForTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textForTask.TextMarginBottom = 0;
            this.textForTask.TextMarginLeft = 3;
            this.textForTask.TextMarginTop = 0;
            this.textForTask.TextPlaceholder = "Enter text";
            this.textForTask.UseSystemPasswordChar = false;
            this.textForTask.WordWrap = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitle.Location = new System.Drawing.Point(56, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(68, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "{task_title}";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblTitle.Click += new System.EventHandler(this.bunifuLabel1_Click);
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
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(12, 188);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(31, 31);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 3;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // lblDate
            // 
            this.lblDate.AllowParentOverrides = false;
            this.lblDate.AutoEllipsis = false;
            this.lblDate.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Location = new System.Drawing.Point(70, 183);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(72, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "{task_date}";
            this.lblDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTime
            // 
            this.lblTime.AllowParentOverrides = false;
            this.lblTime.AutoEllipsis = false;
            this.lblTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTime.Location = new System.Drawing.Point(70, 209);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(72, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "{task_time}";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UserTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "UserTask";
            this.Size = new System.Drawing.Size(243, 280);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuTextBox textForTask;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuLabel lblDate;
    }
}
