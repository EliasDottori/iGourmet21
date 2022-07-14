namespace Seminario
{
    partial class Detalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle));
            this.formaPago = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pedido = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteDetalle = new System.Windows.Forms.Label();
            this.totalDetalle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeroDetalle = new System.Windows.Forms.Label();
            this.pagoDetalle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.descuentoDetalle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.formaPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // formaPago
            // 
            this.formaPago.Controls.Add(this.descuentoDetalle);
            this.formaPago.Controls.Add(this.label9);
            this.formaPago.Controls.Add(this.pagoDetalle);
            this.formaPago.Controls.Add(this.label7);
            this.formaPago.Controls.Add(this.numeroDetalle);
            this.formaPago.Controls.Add(this.label4);
            this.formaPago.Controls.Add(this.totalDetalle);
            this.formaPago.Controls.Add(this.clienteDetalle);
            this.formaPago.Controls.Add(this.label1);
            this.formaPago.Controls.Add(this.label2);
            this.formaPago.Controls.Add(this.pedido);
            this.formaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formaPago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(132)))), ((int)(((byte)(25)))));
            this.formaPago.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(93)))), ((int)(((byte)(23)))));
            this.formaPago.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.formaPago.Location = new System.Drawing.Point(0, 0);
            this.formaPago.Name = "formaPago";
            this.formaPago.Size = new System.Drawing.Size(1097, 596);
            this.formaPago.TabIndex = 11;
            this.formaPago.Paint += new System.Windows.Forms.PaintEventHandler(this.formaPago_Paint);
            // 
            // pedido
            // 
            this.pedido.AllowUserToAddRows = false;
            this.pedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.pedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.pedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.pedido.ColumnHeadersHeight = 30;
            this.pedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn19});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pedido.DefaultCellStyle = dataGridViewCellStyle3;
            this.pedido.EnableHeadersVisualStyles = false;
            this.pedido.GridColor = System.Drawing.Color.Black;
            this.pedido.Location = new System.Drawing.Point(25, 77);
            this.pedido.MultiSelect = false;
            this.pedido.Name = "pedido";
            this.pedido.ReadOnly = true;
            this.pedido.RowHeadersVisible = false;
            this.pedido.RowTemplate.Height = 28;
            this.pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pedido.Size = new System.Drawing.Size(1045, 411);
            this.pedido.TabIndex = 37;
            this.pedido.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.pedido.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.pedido.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.pedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.pedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.pedido.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(200)))));
            this.pedido.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.pedido.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pedido.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.pedido.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.pedido.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.pedido.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.pedido.ThemeStyle.HeaderStyle.Height = 30;
            this.pedido.ThemeStyle.ReadOnly = true;
            this.pedido.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.pedido.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pedido.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.pedido.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.pedido.ThemeStyle.RowsStyle.Height = 28;
            this.pedido.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.pedido.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn18.FillWeight = 78.33376F;
            this.dataGridViewTextBoxColumn18.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn20.FillWeight = 115.4839F;
            this.dataGridViewTextBoxColumn20.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn19.FillWeight = 76.14212F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(855, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 41;
            this.label2.Text = "Total $";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clienteDetalle
            // 
            this.clienteDetalle.AutoSize = true;
            this.clienteDetalle.BackColor = System.Drawing.Color.Transparent;
            this.clienteDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteDetalle.Location = new System.Drawing.Point(120, 19);
            this.clienteDetalle.Name = "clienteDetalle";
            this.clienteDetalle.Size = new System.Drawing.Size(53, 32);
            this.clienteDetalle.TabIndex = 43;
            this.clienteDetalle.Text = "aaa";
            this.clienteDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDetalle
            // 
            this.totalDetalle.AutoSize = true;
            this.totalDetalle.BackColor = System.Drawing.Color.Transparent;
            this.totalDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDetalle.Location = new System.Drawing.Point(948, 521);
            this.totalDetalle.Name = "totalDetalle";
            this.totalDetalle.Size = new System.Drawing.Size(53, 32);
            this.totalDetalle.TabIndex = 44;
            this.totalDetalle.Text = "aaa";
            this.totalDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(820, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 45;
            this.label4.Text = "N° Pedido";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeroDetalle
            // 
            this.numeroDetalle.AutoSize = true;
            this.numeroDetalle.BackColor = System.Drawing.Color.Transparent;
            this.numeroDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDetalle.Location = new System.Drawing.Point(948, 19);
            this.numeroDetalle.Name = "numeroDetalle";
            this.numeroDetalle.Size = new System.Drawing.Size(53, 32);
            this.numeroDetalle.TabIndex = 46;
            this.numeroDetalle.Text = "aaa";
            this.numeroDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagoDetalle
            // 
            this.pagoDetalle.AutoSize = true;
            this.pagoDetalle.BackColor = System.Drawing.Color.Transparent;
            this.pagoDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoDetalle.Location = new System.Drawing.Point(209, 521);
            this.pagoDetalle.Name = "pagoDetalle";
            this.pagoDetalle.Size = new System.Drawing.Size(53, 32);
            this.pagoDetalle.TabIndex = 48;
            this.pagoDetalle.Text = "aaa";
            this.pagoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 32);
            this.label7.TabIndex = 47;
            this.label7.Text = "Forma de pago";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descuentoDetalle
            // 
            this.descuentoDetalle.AutoSize = true;
            this.descuentoDetalle.BackColor = System.Drawing.Color.Transparent;
            this.descuentoDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentoDetalle.Location = new System.Drawing.Point(605, 521);
            this.descuentoDetalle.Name = "descuentoDetalle";
            this.descuentoDetalle.Size = new System.Drawing.Size(53, 32);
            this.descuentoDetalle.TabIndex = 50;
            this.descuentoDetalle.Text = "aaa";
            this.descuentoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 32);
            this.label9.TabIndex = 49;
            this.label9.Text = "Descuento $";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 596);
            this.Controls.Add(this.formaPago);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(248, 126);
            this.Name = "Detalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_Load);
            this.formaPago.ResumeLayout(false);
            this.formaPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel formaPago;
        private Guna.UI2.WinForms.Guna2DataGridView pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Label totalDetalle;
        private System.Windows.Forms.Label clienteDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label descuentoDetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pagoDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numeroDetalle;
        private System.Windows.Forms.Label label4;
    }
}