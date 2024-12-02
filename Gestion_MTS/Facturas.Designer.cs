﻿namespace Gestion_MTS
{
    partial class Facturas
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
            label1 = new Label();
            grpProducts = new GroupBox();
            btnDeleteRequestedProduct = new Button();
            btnUpdateRequestedProduct = new Button();
            btnAddProduct = new Button();
            lblAddedProducts = new Label();
            dgvProducts = new DataGridView();
            txtProductQuantity = new TextBox();
            lblQuantity = new Label();
            cmbProducts = new ComboBox();
            lblProduct = new Label();
            grpServices = new GroupBox();
            btnAddService = new Button();
            btnDeleteRequestedService = new Button();
            btnUpdateRequestedService = new Button();
            lblAddedServices = new Label();
            dgvServices = new DataGridView();
            lblAmount = new Label();
            cmbEmpleados = new ComboBox();
            lblEmployee = new Label();
            cmbServicios = new ComboBox();
            lblService = new Label();
            txtAmount = new TextBox();
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 45);
            label1.Name = "label1";
            label1.Size = new Size(238, 24);
            label1.TabIndex = 0;
            label1.Text = "Elaboracion de Facturas";
            // 
            // grpProducts
            // 
            grpProducts.Anchor = AnchorStyles.None;
            grpProducts.Controls.Add(btnDeleteRequestedProduct);
            grpProducts.Controls.Add(btnUpdateRequestedProduct);
            grpProducts.Controls.Add(btnAddProduct);
            grpProducts.Controls.Add(lblAddedProducts);
            grpProducts.Controls.Add(dgvProducts);
            grpProducts.Controls.Add(txtProductQuantity);
            grpProducts.Controls.Add(lblQuantity);
            grpProducts.Controls.Add(cmbProducts);
            grpProducts.Controls.Add(lblProduct);
            grpProducts.Location = new Point(47, 98);
            grpProducts.Name = "grpProducts";
            grpProducts.Size = new Size(815, 145);
            grpProducts.TabIndex = 1;
            grpProducts.TabStop = false;
            grpProducts.Text = "Productos";
            // 
            // btnDeleteRequestedProduct
            // 
            btnDeleteRequestedProduct.Location = new Point(277, 83);
            btnDeleteRequestedProduct.Name = "btnDeleteRequestedProduct";
            btnDeleteRequestedProduct.Size = new Size(108, 23);
            btnDeleteRequestedProduct.TabIndex = 8;
            btnDeleteRequestedProduct.Text = "Eliminar Pedido";
            btnDeleteRequestedProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRequestedProduct
            // 
            btnUpdateRequestedProduct.Location = new Point(277, 38);
            btnUpdateRequestedProduct.Name = "btnUpdateRequestedProduct";
            btnUpdateRequestedProduct.Size = new Size(108, 23);
            btnUpdateRequestedProduct.TabIndex = 7;
            btnUpdateRequestedProduct.Text = "Actualizar Pedido";
            btnUpdateRequestedProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(15, 116);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(187, 23);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Agregar Producto";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblAddedProducts
            // 
            lblAddedProducts.AutoSize = true;
            lblAddedProducts.Location = new Point(572, 19);
            lblAddedProducts.Name = "lblAddedProducts";
            lblAddedProducts.Size = new Size(121, 15);
            lblAddedProducts.TabIndex = 5;
            lblAddedProducts.Text = "Productos Agregados";
            lblAddedProducts.Click += lblAddedProducts_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(476, 39);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(333, 100);
            dgvProducts.TabIndex = 4;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(81, 80);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(100, 23);
            txtProductQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(19, 83);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(55, 15);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Cantidad";
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(81, 35);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(121, 23);
            cmbProducts.TabIndex = 1;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(19, 38);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(56, 15);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Producto";
            // 
            // grpServices
            // 
            grpServices.Anchor = AnchorStyles.None;
            grpServices.Controls.Add(btnAddService);
            grpServices.Controls.Add(btnDeleteRequestedService);
            grpServices.Controls.Add(btnUpdateRequestedService);
            grpServices.Controls.Add(lblAddedServices);
            grpServices.Controls.Add(dgvServices);
            grpServices.Controls.Add(txtAmount);
            grpServices.Controls.Add(lblAmount);
            grpServices.Controls.Add(cmbEmpleados);
            grpServices.Controls.Add(lblEmployee);
            grpServices.Controls.Add(cmbServicios);
            grpServices.Controls.Add(lblService);
            grpServices.Location = new Point(47, 278);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(815, 153);
            grpServices.TabIndex = 2;
            grpServices.TabStop = false;
            grpServices.Text = "Servicios";
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(19, 124);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(183, 23);
            btnAddService.TabIndex = 14;
            btnAddService.Text = "Agregar Servicio";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRequestedService
            // 
            btnDeleteRequestedService.Location = new Point(277, 81);
            btnDeleteRequestedService.Name = "btnDeleteRequestedService";
            btnDeleteRequestedService.Size = new Size(108, 23);
            btnDeleteRequestedService.TabIndex = 13;
            btnDeleteRequestedService.Text = "Eliminar Pedido";
            btnDeleteRequestedService.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRequestedService
            // 
            btnUpdateRequestedService.Location = new Point(277, 36);
            btnUpdateRequestedService.Name = "btnUpdateRequestedService";
            btnUpdateRequestedService.Size = new Size(108, 23);
            btnUpdateRequestedService.TabIndex = 12;
            btnUpdateRequestedService.Text = "ActualizarPedido";
            btnUpdateRequestedService.UseVisualStyleBackColor = true;
            // 
            // lblAddedServices
            // 
            lblAddedServices.AutoSize = true;
            lblAddedServices.Location = new Point(580, 19);
            lblAddedServices.Name = "lblAddedServices";
            lblAddedServices.Size = new Size(113, 15);
            lblAddedServices.TabIndex = 11;
            lblAddedServices.Text = "Servicios Agregados";
            // 
            // dgvServices
            // 
            dgvServices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(482, 39);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(327, 108);
            dgvServices.TabIndex = 10;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(19, 97);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(43, 15);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Monto";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(81, 65);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(121, 23);
            cmbEmpleados.TabIndex = 7;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(15, 68);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(60, 15);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "Empleado";
            // 
            // cmbServicios
            // 
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(81, 36);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(121, 23);
            cmbServicios.TabIndex = 5;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(19, 39);
            lblService.Name = "lblService";
            lblService.Size = new Size(48, 15);
            lblService.TabIndex = 4;
            lblService.Text = "Servicio";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(81, 94);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 9;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 572);
            Controls.Add(grpServices);
            Controls.Add(grpProducts);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Facturas";
            Text = "Gestión Facturas";
            Load += Facturas_Load;
            grpProducts.ResumeLayout(false);
            grpProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpProducts;
        private ComboBox cmbProducts;
        private Label lblProduct;
        private GroupBox grpServices;
        private TextBox txtProductQuantity;
        private Label lblQuantity;
        private Label lblEmployee;
        private ComboBox cmbServicios;
        private Label lblService;
        private Label lblAmount;
        private ComboBox cmbEmpleados;
        private DataGridView dgvProducts;
        private Label lblAddedProducts;
        private Label lblAddedServices;
        private DataGridView dgvServices;
        private Button btnDeleteRequestedProduct;
        private Button btnUpdateRequestedProduct;
        private Button btnAddProduct;
        private Button btnAddService;
        private Button btnDeleteRequestedService;
        private Button btnUpdateRequestedService;
        private TextBox txtAmount;
    }
}