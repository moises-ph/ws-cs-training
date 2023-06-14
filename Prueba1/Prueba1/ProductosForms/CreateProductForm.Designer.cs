namespace Prueba1.ProductosForms
{
    partial class CreateProductForm
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
            this.InDescripcio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InUnitP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InExistencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboCat = new System.Windows.Forms.ComboBox();
            this.BtnAddCategoria = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InIdProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InDescripcio
            // 
            this.InDescripcio.Location = new System.Drawing.Point(145, 202);
            this.InDescripcio.Name = "InDescripcio";
            this.InDescripcio.Size = new System.Drawing.Size(100, 22);
            this.InDescripcio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // InUnitP
            // 
            this.InUnitP.Location = new System.Drawing.Point(145, 257);
            this.InUnitP.Name = "InUnitP";
            this.InUnitP.Size = new System.Drawing.Size(100, 22);
            this.InUnitP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio Unitario";
            // 
            // InExistencia
            // 
            this.InExistencia.Location = new System.Drawing.Point(145, 312);
            this.InExistencia.Name = "InExistencia";
            this.InExistencia.Size = new System.Drawing.Size(100, 22);
            this.InExistencia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Existencia";
            // 
            // ComboProveedor
            // 
            this.ComboProveedor.FormattingEnabled = true;
            this.ComboProveedor.Location = new System.Drawing.Point(145, 88);
            this.ComboProveedor.Name = "ComboProveedor";
            this.ComboProveedor.Size = new System.Drawing.Size(121, 24);
            this.ComboProveedor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // ComboCat
            // 
            this.ComboCat.FormattingEnabled = true;
            this.ComboCat.Location = new System.Drawing.Point(145, 136);
            this.ComboCat.Name = "ComboCat";
            this.ComboCat.Size = new System.Drawing.Size(121, 24);
            this.ComboCat.TabIndex = 8;
            // 
            // BtnAddCategoria
            // 
            this.BtnAddCategoria.Location = new System.Drawing.Point(273, 136);
            this.BtnAddCategoria.Name = "BtnAddCategoria";
            this.BtnAddCategoria.Size = new System.Drawing.Size(129, 24);
            this.BtnAddCategoria.TabIndex = 10;
            this.BtnAddCategoria.Text = "Añadir Categoria";
            this.BtnAddCategoria.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Crear Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id";
            // 
            // InIdProducto
            // 
            this.InIdProducto.Location = new System.Drawing.Point(145, 35);
            this.InIdProducto.Name = "InIdProducto";
            this.InIdProducto.Size = new System.Drawing.Size(100, 22);
            this.InIdProducto.TabIndex = 12;
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 443);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InIdProducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAddCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InExistencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InUnitP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InDescripcio);
            this.Name = "CreateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateProductForm";
            this.Load += new System.EventHandler(this.FormOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InDescripcio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InUnitP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InExistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboCat;
        private System.Windows.Forms.Button BtnAddCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InIdProducto;
    }
}