using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialDeJohnDoe.Entidades;

namespace ParcialDeJohnDoe.Windows
{
    public partial class frmEsferaAE : Form
    {
        public frmEsferaAE()
        {
            InitializeComponent();
        }

        private Esfera esfera;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboColores();
            if (esfera!=null)
            {
                RadioTextBox.Text = esfera.Radio.ToString();
                RellenoComboBox.SelectedItem =(Relleno) esfera.Relleno;
                switch (esfera.Trazo)
                {
                    case Trazo.Continuo:
                        ContinuoRadioButton.Checked = true;
                        break;
                    case Trazo.Rayas:
                        RayasRadioButton.Checked = true;
                        break;
                    case Trazo.Puntos:
                        PuntosRadioButton.Checked = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void CargarComboColores()
        {
            RellenoComboBox.DataSource = Enum.GetValues(typeof(Relleno));
            RellenoComboBox.SelectedIndex = 0;
        }

        public Esfera GetEsfera()
        {
            return esfera;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esfera==null)
                {
                    esfera = new Esfera();
                }

                esfera.Radio = int.Parse(RadioTextBox.Text);
                esfera.Relleno =(Relleno) RellenoComboBox.SelectedItem;
                if (ContinuoRadioButton.Checked)
                {
                    esfera.Trazo = Trazo.Continuo;
                }else if (RayasRadioButton.Checked)
                {
                    esfera.Trazo = Trazo.Rayas;
                }
                else
                {
                    esfera.Trazo = Trazo.Puntos;
                }

                if (esfera.Validar())
                {
                    DialogResult = DialogResult.OK;
                }
                errorProvider1.SetError(RadioTextBox, "El radio debe ser positivo");

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(RadioTextBox.Text,out int radio))
            {
                valido = false;
                errorProvider1.SetError(RadioTextBox,"Radio mal ingresado");
            }

            return valido;
            
        }

        public void SetEsfera(Esfera esfera)
        {
            this.esfera = esfera;
        }
    }
}
