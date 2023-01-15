namespace SimplisticInjector
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.ModifyForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SelectDll = new Guna.UI2.WinForms.Guna2Button();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.FilePathLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Credit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifyForm
            // 
            this.ModifyForm.AnimateWindow = true;
            this.ModifyForm.BorderRadius = 12;
            this.ModifyForm.ContainerControl = this;
            this.ModifyForm.DockIndicatorTransparencyValue = 0.6D;
            this.ModifyForm.TransparentWhileDrag = true;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BorderRadius = 6;
            this.Exit.FillColor = System.Drawing.Color.Transparent;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(529, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 0;
            this.Exit.UseTransparentBackground = true;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BorderRadius = 6;
            this.Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(494, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(29, 29);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseTransparentBackground = true;
            // 
            // SelectDll
            // 
            this.SelectDll.Animated = true;
            this.SelectDll.BackColor = System.Drawing.Color.Transparent;
            this.SelectDll.BorderRadius = 12;
            this.SelectDll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectDll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectDll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectDll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectDll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDll.ForeColor = System.Drawing.Color.White;
            this.SelectDll.Location = new System.Drawing.Point(110, 117);
            this.SelectDll.Name = "SelectDll";
            this.SelectDll.Size = new System.Drawing.Size(172, 47);
            this.SelectDll.TabIndex = 2;
            this.SelectDll.Text = "Select DLL";
            this.SelectDll.UseTransparentBackground = true;
            this.SelectDll.Click += new System.EventHandler(this.SelectDll_Click);
            // 
            // Inject
            // 
            this.Inject.Animated = true;
            this.Inject.BackColor = System.Drawing.Color.Transparent;
            this.Inject.BorderRadius = 12;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.Location = new System.Drawing.Point(288, 117);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(172, 47);
            this.Inject.TabIndex = 3;
            this.Inject.Text = "Inject";
            this.Inject.UseTransparentBackground = true;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilePathLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathLabel.ForeColor = System.Drawing.Color.White;
            this.FilePathLabel.Location = new System.Drawing.Point(12, 252);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(145, 17);
            this.FilePathLabel.TabIndex = 4;
            this.FilePathLabel.Text = "File Path: <b>No File Selected</b>";
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.ForeColor = System.Drawing.Color.Gray;
            this.Credit.Location = new System.Drawing.Point(12, 9);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(147, 15);
            this.Credit.TabIndex = 5;
            this.Credit.Text = "Created by Founder#2998";
            this.Credit.Click += new System.EventHandler(this.Credit_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(570, 281);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.SelectDll);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simplistic Injector";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm ModifyForm;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2Button Inject;
        private Guna.UI2.WinForms.Guna2Button SelectDll;
        private Guna.UI2.WinForms.Guna2HtmlLabel FilePathLabel;
        private System.Windows.Forms.Label Credit;
    }
}

