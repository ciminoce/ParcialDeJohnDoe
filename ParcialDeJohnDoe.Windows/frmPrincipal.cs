using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialDeJohnDoe.Datos;
using ParcialDeJohnDoe.Entidades;

namespace ParcialDeJohnDoe.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmEsferaAE frm = new frmEsferaAE() { Text = "Agregar nueva esfera" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Esfera esfera = frm.GetEsfera();
            repositorio.Agregar(esfera);
            DataGridViewRow r = ConstuirFila();
            SetearFila(r, esfera);
            AgregarFila(r);
            MostrarCantidad(repositorio.GetCantidad());

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Esfera esfera)
        {
            r.Cells[colRadio.Index].Value = esfera.Radio;
            r.Cells[colRelleno.Index].Value = esfera.Relleno.ToString();
            r.Cells[colTrazo.Index].Value = esfera.Trazo.ToString();
            r.Cells[colVolumen.Index].Value = esfera.GetVolumen();
            r.Cells[colArea.Index].Value = esfera.GetArea();

            r.Tag = esfera;
        }

        private DataGridViewRow ConstuirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private RepositorioDeEsferas repositorio;
        private List<Esfera> lista;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosEnComboTrazos();
            repositorio = new RepositorioDeEsferas();
            var cantidad = repositorio.GetCantidad();
            MostrarCantidad(cantidad);
            if (cantidad>0)
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
            }

        }

        private void CargarDatosEnComboTrazos()
        {
            var listaTrazos = Enum.GetValues(typeof(Trazo)).Cast<Trazo>().ToList();
            foreach (var trazo in listaTrazos)
            {
                TrazosToolStripComboBox.Items.Add(trazo);
            }
        }

        private void MostrarCantidad(int cantidad)
        {
            CantidadTextBox.Text = cantidad.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var esfera in lista)
            {
                var r = ConstuirFila();
                SetearFila(r,esfera);
                AgregarFila(r);
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repositorio.GuardarEnArchivo();
            Application.Exit();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Esfera esfera = (Esfera)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar la esfera de radio {esfera.Radio}?",
                "Confirmar Operación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            repositorio.Borrar(esfera);
            dgvDatos.Rows.Remove(r);

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Esfera esfera = (Esfera)r.Tag;
            frmEsferaAE frm = new frmEsferaAE() { Text = "Editar Esfera" };
            frm.SetEsfera(esfera);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {

                return;
            }

            esfera = frm.GetEsfera();
            repositorio.Editar(esfera);
            SetearFila(r,esfera);

        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaAsc();
            MostrarDatosEnGrilla();
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaDesc();
            MostrarDatosEnGrilla();
        }

        private void TrazosToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trazoFiltrar = (Trazo)TrazosToolStripComboBox.ComboBox.SelectedItem;
            lista = repositorio.FiltrarPorTrazo(trazoFiltrar);
            MostrarDatosEnGrilla();

        }
    }
}
