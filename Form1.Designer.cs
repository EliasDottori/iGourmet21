namespace Seminario
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAcept = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton19 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.Transparent;
            this.textUser.BorderRadius = 10;
            this.textUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUser.DefaultText = "";
            this.textUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(132)))), ((int)(((byte)(25)))));
            this.textUser.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(132)))), ((int)(((byte)(25)))));
            this.textUser.Location = new System.Drawing.Point(387, 231);
            this.textUser.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.textUser.Name = "textUser";
            this.textUser.PasswordChar = '\0';
            this.textUser.PlaceholderText = "";
            this.textUser.SelectedText = "";
            this.textUser.ShadowDecoration.Enabled = true;
            this.textUser.Size = new System.Drawing.Size(269, 45);
            this.textUser.TabIndex = 10;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged_1);
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.Transparent;
            this.textPass.BorderRadius = 10;
            this.textPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPass.DefaultText = "";
            this.textPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(132)))), ((int)(((byte)(25)))));
            this.textPass.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(132)))), ((int)(((byte)(25)))));
            this.textPass.Location = new System.Drawing.Point(387, 329);
            this.textPass.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '●';
            this.textPass.PlaceholderText = "";
            this.textPass.SelectedText = "";
            this.textPass.ShadowDecoration.Enabled = true;
            this.textPass.Size = new System.Drawing.Size(269, 45);
            this.textPass.TabIndex = 11;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // buttonAcept
            // 
            this.buttonAcept.BackColor = System.Drawing.Color.Transparent;
            this.buttonAcept.BorderRadius = 10;
            this.buttonAcept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAcept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAcept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAcept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAcept.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(132)))), ((int)(((byte)(25)))));
            this.buttonAcept.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcept.ForeColor = System.Drawing.Color.Black;
            this.buttonAcept.Location = new System.Drawing.Point(337, 456);
            this.buttonAcept.Name = "buttonAcept";
            this.buttonAcept.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAcept.Size = new System.Drawing.Size(225, 65);
            this.buttonAcept.TabIndex = 12;
            this.buttonAcept.Text = "Aceptar";
            this.buttonAcept.UseTransparentBackground = true;
            this.buttonAcept.Click += new System.EventHandler(this.buttonAcept_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Seminario.Properties.Resources.img;
            this.pictureBox2.Location = new System.Drawing.Point(337, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 122);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pictureBox2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(132)))), ((int)(((byte)(25)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(93)))), ((int)(((byte)(23)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(902, 161);
            this.guna2GradientPanel1.TabIndex = 14;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.guna2GradientButton1);
            this.guna2GradientPanel2.Controls.Add(this.guna2GradientButton19);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(132)))), ((int)(((byte)(25)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(93)))), ((int)(((byte)(23)))));
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 548);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(902, 91);
            this.guna2GradientPanel2.TabIndex = 15;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2GradientButton1.FillColor2 = System.Drawing.SystemColors.ButtonFace;
            this.guna2GradientButton1.FocusedColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.Location = new System.Drawing.Point(702, 13);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2GradientButton1.ShadowDecoration.Enabled = true;
            this.guna2GradientButton1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(6);
            this.guna2GradientButton1.Size = new System.Drawing.Size(188, 66);
            this.guna2GradientButton1.TabIndex = 33;
            this.guna2GradientButton1.Text = "Ayuda";
            // 
            // guna2GradientButton19
            // 
            this.guna2GradientButton19.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton19.BorderRadius = 5;
            this.guna2GradientButton19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton19.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton19.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton19.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton19.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2GradientButton19.FillColor2 = System.Drawing.SystemColors.ButtonFace;
            this.guna2GradientButton19.FocusedColor = System.Drawing.Color.Black;
            this.guna2GradientButton19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.guna2GradientButton19.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton19.Location = new System.Drawing.Point(12, 13);
            this.guna2GradientButton19.Name = "guna2GradientButton19";
            this.guna2GradientButton19.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2GradientButton19.ShadowDecoration.Enabled = true;
            this.guna2GradientButton19.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(6);
            this.guna2GradientButton19.Size = new System.Drawing.Size(188, 66);
            this.guna2GradientButton19.TabIndex = 32;
            this.guna2GradientButton19.Text = "Configuracion";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 639);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.buttonAcept);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Usuarios";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textUser;
        private Guna.UI2.WinForms.Guna2TextBox textPass;
        private Guna.UI2.WinForms.Guna2Button buttonAcept;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton19;
    }
}

