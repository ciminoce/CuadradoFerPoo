using CuadradoFerPoo.Entidades;

namespace CuadradoFerPoo.Windows
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int cantidadAceptados = 0;
        int cantidadRechazados = 0;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtLado.Clear();
            txtLado.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Cuadrado c = new Cuadrado(int.Parse(txtLado.Text));
                MostrarDatosEnGrilla(c);
                InicializarControles();
            }
        }

        private void MostrarDatosEnGrilla(Cuadrado c)
        {
            var r = ConstruirFila();
            SetearFila(r, c);
            AgregarFila(r);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cuadrado c)
        {
            if (c.Validar())
            {
                cantidadAceptados++;
            }
            else
            {
                cantidadRechazados++;
            }

            r.Cells[colCuadrado.Index].Value = c.ToString();
            r.Cells[colValido.Index].Value = c.Validar();
            r.Cells[colPerimetro.Index].Value = c.Validar() ? c.GetPerimetro() : string.Empty;
            r.Cells[colSuperficie.Index].Value = c.Validar() ? c.GetSuperficie() : string.Empty;
            MostrarDatosFinales();
        }

        private void MostrarDatosFinales()
        {
            txtAceptados.Text = cantidadAceptados.ToString();
            txtRechazados.Text = cantidadRechazados.ToString();
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLado.Text, out int lado))
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Lado no válido");
            }
            return valido;
        }
    }
}