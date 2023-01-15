namespace NetheriteInjector
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
            this.FunniAnimation = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.LabelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FunniAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyForm
            // 
            this.ModifyForm.AnimateWindow = true;
            this.ModifyForm.BorderRadius = 12;
            this.ModifyForm.ContainerControl = this;
            this.ModifyForm.DockIndicatorTransparencyValue = 0.6D;
            this.ModifyForm.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ModifyForm.TransparentWhileDrag = true;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Animated = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BorderRadius = 12;
            this.Exit.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.Exit.CustomIconSize = 14F;
            this.Exit.FillColor = System.Drawing.Color.Transparent;
            this.Exit.ForeColor = System.Drawing.Color.Silver;
            this.Exit.HoverState.IconColor = System.Drawing.Color.LightCoral;
            this.Exit.IconColor = System.Drawing.Color.Silver;
            this.Exit.Location = new System.Drawing.Point(528, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 0;
            this.Exit.UseTransparentBackground = true;
            this.Exit.Visible = false;
            // 
            // FunniAnimation
            // 
            this.FunniAnimation.BackColor = System.Drawing.Color.Transparent;
            this.FunniAnimation.FillColor = System.Drawing.Color.Transparent;
            this.FunniAnimation.Image = global::NetheriteInjector.Properties.Resources.dance;
            this.FunniAnimation.ImageRotate = 0F;
            this.FunniAnimation.Location = new System.Drawing.Point(233, 71);
            this.FunniAnimation.Name = "FunniAnimation";
            this.FunniAnimation.Size = new System.Drawing.Size(103, 90);
            this.FunniAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FunniAnimation.TabIndex = 1;
            this.FunniAnimation.TabStop = false;
            this.FunniAnimation.UseTransparentBackground = true;
            this.FunniAnimation.Visible = false;
            // 
            // Inject
            // 
            this.Inject.Animated = true;
            this.Inject.BackColor = System.Drawing.Color.Transparent;
            this.Inject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Inject.BorderRadius = 12;
            this.Inject.BorderThickness = 1;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.FillColor = System.Drawing.Color.Green;
            this.Inject.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.Location = new System.Drawing.Point(163, 183);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(242, 74);
            this.Inject.TabIndex = 2;
            this.Inject.Text = "Inject";
            this.Inject.UseTransparentBackground = true;
            this.Inject.Visible = false;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.ForeColor = System.Drawing.Color.Silver;
            this.LabelVersion.Location = new System.Drawing.Point(12, 305);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(128, 14);
            this.LabelVersion.TabIndex = 3;
            this.LabelVersion.Text = "Netherite Injector - 1.0";
            this.LabelVersion.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(569, 328);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.FunniAnimation);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netherite Injector";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FunniAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm ModifyForm;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2PictureBox FunniAnimation;
        private Guna.UI2.WinForms.Guna2Button Inject;
        private System.Windows.Forms.Label LabelVersion;
    }
}

