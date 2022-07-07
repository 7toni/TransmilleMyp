namespace TemplateFormMyp
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.guna2GradientButton_config = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton_home = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton_viewtransmille = new Guna.UI2.WinForms.Guna2GradientButton();
            this.listView_datadevices = new System.Windows.Forms.ListView();
            this.viewTransmille2 = new VisaMyp.ViewTransmille();
            this.viewUno2 = new TemplateFormMyp.ViewUno();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            this.gunaGradient2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaImageButton1);
            this.gunaGradient2Panel1.Controls.Add(this.guna2GradientButton_config);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaControlBox2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaControlBox1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(123, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1242, 44);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(49, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 21);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "MyP Digital";
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1145, 1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Gray;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 40);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1194, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 37);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.guna2GradientButton_home);
            this.gunaGradient2Panel2.Controls.Add(this.guna2GradientButton_viewtransmille);
            this.gunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(123, 768);
            this.gunaGradient2Panel2.TabIndex = 2;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaGradient2Panel1;
            // 
            // gunaGradient2Panel3
            // 
            this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel3.Controls.Add(this.listView_datadevices);
            this.gunaGradient2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.gunaGradient2Panel3.Location = new System.Drawing.Point(1206, 44);
            this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
            this.gunaGradient2Panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaGradient2Panel3.Size = new System.Drawing.Size(159, 724);
            this.gunaGradient2Panel3.TabIndex = 3;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::VisaMyp.Properties.Resources.icons8_toaster_oven_material_filled_32;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaImageButton1.Location = new System.Drawing.Point(3, 4);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(40, 30);
            this.gunaImageButton1.TabIndex = 8;
            // 
            // guna2GradientButton_config
            // 
            this.guna2GradientButton_config.BorderRadius = 7;
            this.guna2GradientButton_config.CheckedState.Parent = this.guna2GradientButton_config;
            this.guna2GradientButton_config.CustomImages.Parent = this.guna2GradientButton_config;
            this.guna2GradientButton_config.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton_config.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton_config.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton_config.ForeColor = System.Drawing.Color.Gray;
            this.guna2GradientButton_config.HoverState.Parent = this.guna2GradientButton_config;
            this.guna2GradientButton_config.Image = global::VisaMyp.Properties.Resources.icons8_automatic_48;
            this.guna2GradientButton_config.Location = new System.Drawing.Point(1001, 7);
            this.guna2GradientButton_config.Name = "guna2GradientButton_config";
            this.guna2GradientButton_config.ShadowDecoration.Parent = this.guna2GradientButton_config;
            this.guna2GradientButton_config.Size = new System.Drawing.Size(138, 29);
            this.guna2GradientButton_config.TabIndex = 7;
            this.guna2GradientButton_config.Text = "Configuración";
            this.guna2GradientButton_config.Click += new System.EventHandler(this.guna2GradientButton_config_Click);
            // 
            // guna2GradientButton_home
            // 
            this.guna2GradientButton_home.BorderRadius = 7;
            this.guna2GradientButton_home.CheckedState.Parent = this.guna2GradientButton_home;
            this.guna2GradientButton_home.CustomImages.Parent = this.guna2GradientButton_home;
            this.guna2GradientButton_home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.guna2GradientButton_home.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.guna2GradientButton_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton_home.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton_home.HoverState.Parent = this.guna2GradientButton_home;
            this.guna2GradientButton_home.Image = global::VisaMyp.Properties.Resources.icons8_home_481;
            this.guna2GradientButton_home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton_home.Location = new System.Drawing.Point(4, 33);
            this.guna2GradientButton_home.Name = "guna2GradientButton_home";
            this.guna2GradientButton_home.ShadowDecoration.Parent = this.guna2GradientButton_home;
            this.guna2GradientButton_home.Size = new System.Drawing.Size(119, 45);
            this.guna2GradientButton_home.TabIndex = 6;
            this.guna2GradientButton_home.Text = "Inicio";
            this.guna2GradientButton_home.Click += new System.EventHandler(this.guna2GradientButton_home_Click);
            // 
            // guna2GradientButton_viewtransmille
            // 
            this.guna2GradientButton_viewtransmille.BorderRadius = 7;
            this.guna2GradientButton_viewtransmille.CheckedState.Parent = this.guna2GradientButton_viewtransmille;
            this.guna2GradientButton_viewtransmille.CustomImages.Parent = this.guna2GradientButton_viewtransmille;
            this.guna2GradientButton_viewtransmille.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.guna2GradientButton_viewtransmille.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.guna2GradientButton_viewtransmille.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton_viewtransmille.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton_viewtransmille.HoverState.Parent = this.guna2GradientButton_viewtransmille;
            this.guna2GradientButton_viewtransmille.Image = global::VisaMyp.Properties.Resources.icons8_toaster_oven_48;
            this.guna2GradientButton_viewtransmille.Location = new System.Drawing.Point(3, 84);
            this.guna2GradientButton_viewtransmille.Name = "guna2GradientButton_viewtransmille";
            this.guna2GradientButton_viewtransmille.ShadowDecoration.Parent = this.guna2GradientButton_viewtransmille;
            this.guna2GradientButton_viewtransmille.Size = new System.Drawing.Size(114, 52);
            this.guna2GradientButton_viewtransmille.TabIndex = 5;
            this.guna2GradientButton_viewtransmille.Text = "Transmille";
            this.guna2GradientButton_viewtransmille.Click += new System.EventHandler(this.guna2GradientButton_viewtransmille_Click);
            // 
            // listView_datadevices
            // 
            this.listView_datadevices.HideSelection = false;
            this.listView_datadevices.Location = new System.Drawing.Point(0, 3);
            this.listView_datadevices.Name = "listView_datadevices";
            this.listView_datadevices.Size = new System.Drawing.Size(156, 245);
            this.listView_datadevices.TabIndex = 0;
            this.listView_datadevices.UseCompatibleStateImageBehavior = false;
            this.listView_datadevices.View = System.Windows.Forms.View.Tile;
            // 
            // viewTransmille2
            // 
            this.viewTransmille2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.viewTransmille2.device = null;
            this.viewTransmille2.ForeColor = System.Drawing.Color.White;
            this.viewTransmille2.Location = new System.Drawing.Point(123, 45);
            this.viewTransmille2.Name = "viewTransmille2";
            this.viewTransmille2.rangomax = 0D;
            this.viewTransmille2.Size = new System.Drawing.Size(985, 702);
            this.viewTransmille2.TabIndex = 5;
            this.viewTransmille2.unidad = null;
            // 
            // viewUno2
            // 
            this.viewUno2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.viewUno2.Location = new System.Drawing.Point(126, 44);
            this.viewUno2.Name = "viewUno2";
            this.viewUno2.Size = new System.Drawing.Size(1029, 718);
            this.viewUno2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1365, 768);
            this.Controls.Add(this.viewTransmille2);
            this.Controls.Add(this.gunaGradient2Panel3);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Controls.Add(this.viewUno2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
        private ViewUno viewUno1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton_viewtransmille;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton_home;
        private VisaMyp.ViewTransmille viewTransmille1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton_config;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private ViewUno viewUno2;
        private VisaMyp.ViewTransmille viewTransmille2;
        public System.Windows.Forms.ListView listView_datadevices;
    }
}

