using System;
using System.Windows.Forms;

namespace RentaCar_Express_Frenlly
{
    public partial class frmAlquileres : Form
    {
        double totalAcumulado = 0;

        public frmAlquileres()
        {
            InitializeComponent();
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {
            dtpSalida.Value = DateTime.Now;
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            // Texto del encabezado alineado
            lblEncabezado.Text = "Días".PadRight(6) + "Vehículo".PadRight(24) + "Tarifa".PadLeft(10) + "Total".PadLeft(12);

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtVehiculo.Text == "" || txtTarifa.Text == "")
            {
                MessageBox.Show("Llene los datos del vehiculo y la tarifa");
                return;
            }

            // Tarifa base
            double tarifa = Convert.ToDouble(txtTarifa.Text);

            // Reglas: +300 si es completo, +100 si es GPS
            if (rbtCompleto.Checked == true) { tarifa = tarifa + 300; }
            if (chkGps.Checked == true) { tarifa = tarifa + 100; }

            // Total de linea: Multiplicamos tarifa por los dias
            double totalLinea = tarifa * Convert.ToDouble(nudDias.Value);

            // Nombre del vehiculo con su seguro
            string nombreVehiculo = txtVehiculo.Text;
            if (rbtCompleto.Checked == true) { nombreVehiculo = nombreVehiculo + " (Completo)"; }
            if (rbtBasico.Checked == true) { nombreVehiculo = nombreVehiculo + " (Básico)"; }

            // Creamos el string alineado con PadRight y PadLeft
            string linea = nudDias.Value.ToString().PadRight(6) +
                           nombreVehiculo.PadRight(24) +
                           tarifa.ToString("N2").PadLeft(10) +
                           totalLinea.ToString("N2").PadLeft(12);

            lstAlquileres.Items.Add(linea);
            totalAcumulado = totalAcumulado + totalLinea;

            // Limpiar controles
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            chkGps.Checked = false;
            rbtBasico.Checked = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("No hay vehiculos en la lista");
                return;
            }

            // Descuento: 15% (0.15)
            double desc = 0;
            if (chkCorporativo.Checked == true) { desc = totalAcumulado * 0.15; }

            // Domicilio: 500
            double domi = 0;
            if (rbtDomicilio.Checked == true) { domi = 500; }

            // Base imponible = subtotal - descuento + domicilio
            double baseImp = totalAcumulado - desc + domi;

            // ITBIS: 18% (0.18)
            double itbis = baseImp * 0.18;

            // Total final
            double total = baseImp + itbis;

            // Mostrar resultados
            lblSubtotal.Text = "RD$ " + totalAcumulado.ToString("N2");
            lblDescuento.Text = "RD$ " + desc.ToString("N2");
            lblDomicilio.Text = "RD$ " + domi.ToString("N2");
            lblItbis.Text = "RD$ " + itbis.ToString("N2");
            lblTotal.Text = "RD$ " + total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            totalAcumulado = 0;
            lstAlquileres.Items.Clear();
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            chkCorporativo.Checked = false;
            chkGps.Checked = false;
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;
            dtpSalida.Value = DateTime.Now;

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";

            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}