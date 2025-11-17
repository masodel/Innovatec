using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Innovatec
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            cbJerarquia_FormaRecorrer.SelectedIndex = 0;
            cbRutas_BuscarPor.SelectedIndex = 0;
        }

        class Nodo
        {
            public string Nombre { get; set; }
            public Dictionary<Nodo, int> Conexiones { get; set; }

            public Nodo(string nombre)
            {
                Nombre = nombre;
                Conexiones = new Dictionary<Nodo, int>();
            }

            public void AgregarConexion(Nodo nodo, int peso)
            {
                Conexiones[nodo] = peso;
            }
        }

        class Grafo
        {
            public List<Nodo> Nodos { get; set; } = new List<Nodo>();

            public void AgregarNodo(Nodo nodo)
            {
                Nodos.Add(nodo);
            }
        }

        Grafo grafo = new Grafo();

        private void CargarGrafo()
        {
            lblRutas.Visible = true;

            lblRutas.Text = "";
            foreach (var nodo in grafo.Nodos)
            {
                lblRutas.Text += (nodo.Nombre);

                foreach (var conexion in nodo.Conexiones)
                {
                    lblRutas.Text += ($"  -> {conexion.Key.Nombre} (Distancia: {conexion.Value})");
                }
                lblRutas.Text += Environment.NewLine;
            }
        }

        private void BFS()
        {
        }

        private void Dijkstra()
        {
        }

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            if (tbRutas_AgregarEdificio.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el nombre del edificio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Nodo nuevoNodo = new Nodo(tbRutas_AgregarEdificio.Text);
            grafo.AgregarNodo(nuevoNodo);

            CargarGrafo();
        }

        private void btnAgregarConexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbConexion_Edificio1.Text) ||
                string.IsNullOrWhiteSpace(tbConexion_Edificio2.Text) ||
                string.IsNullOrWhiteSpace(tbConexion_Distancia.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de conexión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbConexion_Distancia.Text, out int distancia) || distancia <= 0)
            {
                MessageBox.Show("La distancia debe ser un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbConexion_Distancia.Focus();
                return;
            }

            Nodo nodo1 = grafo.Nodos.FirstOrDefault(n => n.Nombre == tbConexion_Edificio1.Text);
            Nodo nodo2 = grafo.Nodos.FirstOrDefault(n => n.Nombre == tbConexion_Edificio2.Text);

            if (nodo1 == null)
            {
                MessageBox.Show("El edificio 1 no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nodo2 == null)
            {
                MessageBox.Show("El edificio 2 no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nodo1.AgregarConexion(nodo2, distancia);
            nodo2.AgregarConexion(nodo1, distancia);
                
            CargarGrafo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Opcion = cbRutas_BuscarPor.SelectedIndex;

            switch (Opcion)
            {
                case 0:
                    {
                        break;
                    }

                case 1:
                    {
                        break;
                    }
            }
        }
    }
}
