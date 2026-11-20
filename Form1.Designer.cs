using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentaCar_Express_Frenlly
{
    partial class frmAlquileres : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            dtpSalida = new DateTimePicker();
            chkCorporativo = new CheckBox();
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            nudDias = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtCompleto = new RadioButton();
            rbtBasico = new RadioButton();
            chkGps = new CheckBox();
            groupBox2 = new GroupBox();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            lblEncabezado = new Label();
            lblSubtotal = new Label();
            lstAlquileres = new ListBox();
            lblDescuento = new Label();
            lblDomicilio = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            btnAgregar = new Button();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblCliente = new Label();
            lblSalida = new Label();
            lblVehiculo = new Label();
            lblTarifa = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(154, 22);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(306, 31);
            txtCliente.TabIndex = 0;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(154, 94);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(306, 31);
            dtpSalida.TabIndex = 1;
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(44, 59);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(191, 29);
            chkCorporativo.TabIndex = 2;
            chkCorporativo.Text = "Cliente Corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(154, 137);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(306, 31);
            txtVehiculo.TabIndex = 3;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(154, 189);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(306, 31);
            txtTarifa.TabIndex = 4;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(154, 236);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(232, 31);
            nudDias.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtCompleto);
            groupBox1.Controls.Add(rbtBasico);
            groupBox1.Location = new Point(44, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 150);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro";
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Location = new Point(20, 102);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(207, 29);
            rbtCompleto.TabIndex = 1;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo (+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(20, 48);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(87, 29);
            rbtBasico.TabIndex = 0;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(44, 517);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(222, 29);
            chkGps.TabIndex = 7;
            chkGps.Text = "Gps (+RD$100 por día)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtDomicilio);
            groupBox2.Controls.Add(rbtSucursal);
            groupBox2.Location = new Point(316, 312);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 150);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entrega";
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(21, 93);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(112, 29);
            rbtDomicilio.TabIndex = 1;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(20, 40);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(102, 29);
            rbtSucursal.TabIndex = 0;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "Sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(555, 94);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(107, 25);
            lblEncabezado.TabIndex = 9;
            lblEncabezado.Text = "Encabezado";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(566, 352);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(79, 25);
            lblSubtotal.TabIndex = 10;
            lblSubtotal.Text = "Subtotal";
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(555, 122);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(406, 179);
            lstAlquileres.TabIndex = 11;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(566, 389);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(96, 25);
            lblDescuento.TabIndex = 12;
            lblDescuento.Text = "Descuento";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(566, 437);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(87, 25);
            lblDomicilio.TabIndex = 13;
            lblDomicilio.Text = "Domicilio";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(567, 479);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(46, 25);
            lblItbis.TabIndex = 14;
            lblItbis.Text = "Itbis";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(567, 521);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(114, 25);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total a pagar";
            lblTotal.Click += LblTotal_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(555, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(406, 54);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar al cliente";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(44, 573);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(146, 63);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(225, 573);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(161, 63);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Nuevo alquiler";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(433, 573);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 63);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(44, 22);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(69, 25);
            lblCliente.TabIndex = 20;
            lblCliente.Text = "Cliente:";
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(44, 100);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(63, 25);
            lblSalida.TabIndex = 21;
            lblSalida.Text = "Salida:";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(44, 143);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(82, 25);
            lblVehiculo.TabIndex = 22;
            lblVehiculo.Text = "Vehiculo:";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(44, 189);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(57, 25);
            lblTarifa.TabIndex = 23;
            lblTarifa.Text = "Tarifa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 242);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 24;
            label1.Text = "Días:";
            // 
            // frmAlquileres
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(989, 658);
            Controls.Add(label1);
            Controls.Add(lblTarifa);
            Controls.Add(lblVehiculo);
            Controls.Add(lblSalida);
            Controls.Add(lblCliente);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lstAlquileres);
            Controls.Add(lblSubtotal);
            Controls.Add(lblEncabezado);
            Controls.Add(groupBox2);
            Controls.Add(chkGps);
            Controls.Add(groupBox1);
            Controls.Add(nudDias);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(chkCorporativo);
            Controls.Add(dtpSalida);
            Controls.Add(txtCliente);
            Name = "frmAlquileres";
            Text = "RentaCar Express - Alquileres";
            Load += frmAlquileres_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private DateTimePicker dtpSalida;
        private CheckBox chkCorporativo;
        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private NumericUpDown nudDias;
        private GroupBox groupBox1;
        private RadioButton rbtCompleto;
        private RadioButton rbtBasico;
        private CheckBox chkGps;
        private GroupBox groupBox2;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private Label lblEncabezado;
        private Label lblSubtotal;
        private ListBox lstAlquileres;
        private Label lblDescuento;
        private Label lblDomicilio;
        private Label lblItbis;
        private Label lblTotal;
        private Button btnAgregar;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblCliente;
        private Label lblSalida;
        private Label lblVehiculo;
        private Label lblTarifa;
        private Label label1;
    }
}