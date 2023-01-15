namespace KekKinjector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ModifyForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Titlebar = new Guna.UI2.WinForms.Guna2Panel();
            this.Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.DragTitlebar = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Logo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.CreditLabel = new System.Windows.Forms.Label();
            this.Titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifyForm
            // 
            this.ModifyForm.AnimateWindow = true;
            this.ModifyForm.BorderRadius = 12;
            this.ModifyForm.ContainerControl = this;
            this.ModifyForm.DockIndicatorTransparencyValue = 0.6D;
            this.ModifyForm.ShadowColor = System.Drawing.Color.Green;
            this.ModifyForm.TransparentWhileDrag = true;
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Titlebar.BorderColor = System.Drawing.Color.Transparent;
            this.Titlebar.BorderRadius = 6;
            this.Titlebar.Controls.Add(this.Minimize);
            this.Titlebar.Controls.Add(this.Exit);
            this.Titlebar.CustomBorderColor = System.Drawing.Color.Green;
            this.Titlebar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(0, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(888, 23);
            this.Titlebar.TabIndex = 0;
            // 
            // Minimize
            // 
            this.Minimize.Animated = true;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Image = global::KekKinjector.Properties.Resources.mc_green;
            this.Minimize.Location = new System.Drawing.Point(842, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize.Size = new System.Drawing.Size(23, 23);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseTransparentBackground = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Animated = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FillColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.HoverState.Image = global::KekKinjector.Properties.Resources.sign_error_icon;
            this.Exit.Image = global::KekKinjector.Properties.Resources.mc_red;
            this.Exit.Location = new System.Drawing.Point(865, 0);
            this.Exit.Name = "Exit";
            this.Exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit.Size = new System.Drawing.Size(23, 23);
            this.Exit.TabIndex = 0;
            this.Exit.UseTransparentBackground = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DragTitlebar
            // 
            this.DragTitlebar.DockIndicatorTransparencyValue = 0.6D;
            this.DragTitlebar.TargetControl = this.Titlebar;
            this.DragTitlebar.UseTransparentDrag = true;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Logo.HoverState.ImageSize = new System.Drawing.Size(256, 256);
            this.Logo.Image = global::KekKinjector.Properties.Resources.kekwnobackground;
            this.Logo.ImageOffset = new System.Drawing.Point(0, 0);
            this.Logo.ImageRotate = 0F;
            this.Logo.ImageSize = new System.Drawing.Size(256, 256);
            this.Logo.Location = new System.Drawing.Point(348, 79);
            this.Logo.Name = "Logo";
            this.Logo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Logo.Size = new System.Drawing.Size(192, 192);
            this.Logo.TabIndex = 1;
            this.Logo.UseTransparentBackground = true;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Inject
            // 
            this.Inject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Inject.Animated = true;
            this.Inject.BackColor = System.Drawing.Color.Transparent;
            this.Inject.BorderColor = System.Drawing.Color.Green;
            this.Inject.BorderRadius = 12;
            this.Inject.BorderThickness = 2;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Inject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.Location = new System.Drawing.Point(335, 310);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(219, 56);
            this.Inject.TabIndex = 2;
            this.Inject.Text = "Inject";
            this.Inject.UseTransparentBackground = true;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // CreditLabel
            // 
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.CreditLabel.Location = new System.Drawing.Point(12, 419);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(189, 14);
            this.CreditLabel.TabIndex = 3;
            this.CreditLabel.Text = "Injector created by Founder#2998";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(888, 442);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Titlebar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(300, 425);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kek Injector";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Titlebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm ModifyForm;
        private Guna.UI2.WinForms.Guna2Panel Titlebar;
        private Guna.UI2.WinForms.Guna2DragControl DragTitlebar;
        private Guna.UI2.WinForms.Guna2CircleButton Exit;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize;
        private Guna.UI2.WinForms.Guna2ImageButton Logo;
        private Guna.UI2.WinForms.Guna2Button Inject;
        private System.Windows.Forms.Label CreditLabel;
    }
}

