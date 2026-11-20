using System;
using System.Windows.Forms;

namespace RentaCar_Express_Frenlly
{
    public partial class frmAlquileres : Form
    {
        // Variable para ir acumulando
        double suma = 0;

        public frmAlquileres()
        {
            InitializeComponent();
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            // Puse los nombres pero no usé PadRight (error del estudiante)
            lblEncabezado.Text = "Días    Vehículo    Tarifa    Total";

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validación sencilla
            if (txtVehiculo.Text == "")
            {
                MessageBox.Show("Falta el vehiculo");
                return; // Esto hace que se salga
            }

            // ERROR 1: Si dejan la tarifa vacía, el programa va a explotar (crash)
            // porque Convert.ToDouble no puede convertir texto vacío.
            double tarifa = Convert.ToDouble(txtTarifa.Text);

            if (rbtCompleto.Checked == true) { tarifa = tarifa + 300; }
            if (chkGps.Checked == true) { tarifa = tarifa + 100; }

            // ERROR 2: Estoy sumando los días en vez de multiplicarlos
            double totalLinea = tarifa + Convert.ToDouble(nudDias.Value);

            // ERROR 3: Formato feo, sin PadRight ni PadLeft
            string linea = nudDias.Value.ToString() + " - " + txtVehiculo.Text + " - " + tarifa.ToString() + " - " + totalLinea.ToString();

            lstAlquileres.Items.Add(linea);
            suma = suma + totalLinea;

            // Limpio algunas cosas pero no todas (ej. no limpio el check de GPS)
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("No hay nada en la lista");
                return;
            }

            // ERROR 4: Multiplico por 15 en vez de 0.15 (darán millones)
            double desc = 0;
            if (chkCorporativo.Checked == true)
            {
                desc = suma * 15;
            }

            double domi = 0;
            if (rbtDomicilio.Checked == true)
            {
                domi = 500;
            }

            // ERROR 5: Me olvidé de sumar el domicilio a la base imponible
            double baseImp = suma - desc;

            // ERROR 6: Multiplico por 18 en vez de 0.18
            double itbis = baseImp * 18;

            double total = baseImp + itbis + domi;

            lblSubtotal.Text = "RD$ " + suma.ToString("N2");
            lblDescuento.Text = "RD$ " + desc.ToString("N2");
            lblDomicilio.Text = "RD$ " + domi.ToString("N2");
            lblItbis.Text = "RD$ " + itbis.ToString("N2");
            lblTotal.Text = "RD$ " + total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Esto sí funciona bien
            suma = 0;
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
            // Esto también funciona perfecto
            if (MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}