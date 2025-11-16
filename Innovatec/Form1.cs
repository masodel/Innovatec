using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatec
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        TreeNode UltimoNodo = null;

        public void AgregarRama(string nombreRama)
        {
            tvJerarquia.SelectedNode.Nodes.Add(nombreRama);
        }

        public Boolean BuscarRama(string texto)
        {
            TreeNode Buscar(TreeNodeCollection nodos, string t)
            {
                foreach (TreeNode n in nodos)
                {
                    if (n.Text.Equals(t, StringComparison.OrdinalIgnoreCase))
                        return n;

                    var encontrado = Buscar(n.Nodes, t);
                    if (encontrado != null)
                        return encontrado;
                }
                return null;
            }

            TreeNode nodo = Buscar(tvJerarquia.Nodes, texto);

            if (nodo == null)
            {
                MessageBox.Show("No encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (UltimoNodo != null && UltimoNodo != nodo) UltimoNodo.BackColor = Color.White;

            UltimoNodo = nodo;

            tvJerarquia.SelectedNode = nodo;
            nodo.BackColor = Color.Yellow;
            nodo.EnsureVisible();

            return true;
        }

        public void EliminarRama()
        {
            if (tvJerarquia.SelectedNode.Parent == null)
            {
                MessageBox.Show("No se puede eliminar la raíz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tvJerarquia.SelectedNode.Remove();
        }

        private void btnAgregarRama_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbJerarquia_AgregarRama.Text)) 
            { 
                MessageBox.Show("El nombre de la rama no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbJerarquia_AgregarRama.Focus();
                return;
            }

            if (tvJerarquia.SelectedNode == null) 
            { 
                MessageBox.Show("Seleccione una rama para agregar una subrama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AgregarRama(tbJerarquia_AgregarRama.Text);

            tvJerarquia.ExpandAll();
            tbJerarquia_AgregarRama.Clear();
            tbJerarquia_AgregarRama.Focus();
        }

        private void brnJerarquia_Buscar_Click(object sender, EventArgs e)
        {
            if (BuscarRama(tbJerarquia_BuscarRama.Text)) { btnJerarquia_Eliminar.Enabled = true; }
        }

        private void btnJerarquia_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarRama();
        }
    }
}
