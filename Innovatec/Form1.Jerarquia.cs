using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatec
{
    public partial class FrmPrincipal
    {
        TreeNode UltimoNodo = null;

        public void AgregarRama(string nombreRama)
        {
            tvJerarquia.SelectedNode.Nodes.Add(nombreRama);
        }

        public void BuscarRama(string texto)
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
                return;
            }

            if (UltimoNodo != null && UltimoNodo != nodo) UltimoNodo.BackColor = Color.White;

            UltimoNodo = nodo;

            tvJerarquia.SelectedNode = nodo;
            nodo.BackColor = Color.Yellow;
            nodo.EnsureVisible();

            return;
        }

        public void EliminarRama()
        {
            if (tvJerarquia.SelectedNode == null)
            {
                MessageBox.Show("Seleccione una raíz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tvJerarquia.SelectedNode.Parent == null)
            {
                MessageBox.Show("No se puede eliminar la raíz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tvJerarquia.SelectedNode.Remove();
        }

        public int ContarRamas(TreeNodeCollection nodos)
        {
            int contador = 0;

            foreach (TreeNode nodo in nodos)
            {
                contador++;
                contador += ContarRamas(nodo.Nodes);
            }

            return contador;
        }

        public void RecorrerPreOrden(TreeNode nodo)
        {
            lbJerarquia_Recorrer.Items.Add(nodo.Text);

            foreach (TreeNode hijo in nodo.Nodes)
            {
                RecorrerPreOrden(hijo);
            }
        }

        public void RecorrerPostOrden(TreeNode nodo)
        {
            foreach (TreeNode hijo in nodo.Nodes)
            {
                RecorrerPostOrden(hijo);
            }

            lbJerarquia_Recorrer.Items.Add(nodo.Text);
        }

        public void RecorrerPorNiveles(TreeNode nodo)
        {
            Queue<TreeNode> cola = new Queue<TreeNode>();
            cola.Enqueue(nodo);

            while (cola.Count > 0)
            {
                TreeNode actual = cola.Dequeue();
                lbJerarquia_Recorrer.Items.Add(actual.Text);

                foreach (TreeNode hijo in actual.Nodes)
                {
                    cola.Enqueue(hijo);
                }
            }
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

            lblJerarquia_ContarRamas.Text = $"Número de Ramas: {ContarRamas(tvJerarquia.Nodes)}";
        }

        private void brnJerarquia_Buscar_Click(object sender, EventArgs e)
        {
            BuscarRama(tbJerarquia_BuscarRama.Text);
        }

        private void btnJerarquia_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarRama();

            lblJerarquia_ContarRamas.Text = $"Número de Ramas: {ContarRamas(tvJerarquia.Nodes)}";
        }

        private void btnJerarquia_Recorrer_Click(object sender, EventArgs e)
        {
            int Opcion = cbJerarquia_FormaRecorrer.SelectedIndex;

            switch (Opcion)
            {
                case 0:
                    {
                        lbJerarquia_Recorrer.Items.Clear();
                        RecorrerPreOrden(tvJerarquia.TopNode);
                        break;
                    }

                case 1:
                    {
                        lbJerarquia_Recorrer.Items.Clear();
                        RecorrerPostOrden(tvJerarquia.TopNode);
                        break;
                    }

                case 2:
                    {
                        lbJerarquia_Recorrer.Items.Clear();
                        RecorrerPorNiveles(tvJerarquia.TopNode);
                        break;
                    }
            }
        }
    }
}
