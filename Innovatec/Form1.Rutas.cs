using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatec
{
    public partial class FrmPrincipal
    {
        class Nodo
        {
            public string Nombre { get; set; }
            public Dictionary<Nodo, int> Conexiones { get; set; }

            public Nodo(string nombre)
            {
                Nombre = nombre;
                Conexiones = new Dictionary<Nodo, int>();
            }

            public void AgregarConexion(Nodo destino, int distancia)
            {
                Conexiones[destino] = distancia;
            }
        }

        class Grafo
        {
            public List<Nodo> Nodos { get; set; } = new List<Nodo>();

            public void AgregarNodo(Nodo nodo)
            {
                Nodos.Add(nodo);
            }

            public bool EliminarNodo(string nombre)
            {
                if (string.IsNullOrWhiteSpace(nombre)) return false;

                Nodo nodo = Nodos.FirstOrDefault(n => string.Equals(n.Nombre, nombre.Trim(), StringComparison.OrdinalIgnoreCase));
                if (nodo == null) return false;

                // eliminar todas las conexiones hacia este nodo
                foreach (var n in Nodos)
                {
                    if (n.Conexiones.ContainsKey(nodo))
                        n.Conexiones.Remove(nodo);
                }

                Nodos.Remove(nodo);
                return true;
            }

            public bool EliminarConexion(string desdeNombre, string haciaNombre)
            {
                if (string.IsNullOrWhiteSpace(desdeNombre) || string.IsNullOrWhiteSpace(haciaNombre)) return false;

                Nodo desde = Nodos.FirstOrDefault(n => string.Equals(n.Nombre, desdeNombre.Trim(), StringComparison.OrdinalIgnoreCase));
                Nodo hacia = Nodos.FirstOrDefault(n => string.Equals(n.Nombre, haciaNombre.Trim(), StringComparison.OrdinalIgnoreCase));

                if (desde == null || hacia == null) return false;

                bool removed = false;

                // Intentamos eliminar en ambos sentidos (grafo no dirigido)
                if (desde.Conexiones.ContainsKey(hacia))
                {
                    desde.Conexiones.Remove(hacia);
                    removed = true;
                }

                if (hacia.Conexiones.ContainsKey(desde))
                {
                    hacia.Conexiones.Remove(desde);
                    removed = true;
                }

                return removed;
            }

            public List<string> BFS(string inicio, string destino)
            {
                var start = Nodos.FirstOrDefault(n => n.Nombre == inicio);
                var end = Nodos.FirstOrDefault(n => n.Nombre == destino);

                if (start == null || end == null)
                    return null;

                Queue<Nodo> cola = new Queue<Nodo>();
                HashSet<Nodo> visitados = new HashSet<Nodo>();
                Dictionary<Nodo, Nodo> padre = new Dictionary<Nodo, Nodo>();

                cola.Enqueue(start);
                visitados.Add(start);

                while (cola.Count > 0)
                {
                    Nodo actual = cola.Dequeue();

                    if (actual == end)
                        break;

                    foreach (var vecino in actual.Conexiones.Keys)
                    {
                        if (!visitados.Contains(vecino))
                        {
                            visitados.Add(vecino);
                            padre[vecino] = actual;
                            cola.Enqueue(vecino);
                        }
                    }
                }

                if (!padre.ContainsKey(end))
                    return null;

                List<string> ruta = new List<string>();
                Nodo temp = end;

                while (temp != start)
                {
                    ruta.Add(temp.Nombre);
                    temp = padre[temp];
                }

                ruta.Add(start.Nombre);
                ruta.Reverse();
                return ruta;
            }

            public List<string> Dijkstra(string inicio, string destino)
            {
                var start = Nodos.FirstOrDefault(n => n.Nombre == inicio);
                var end = Nodos.FirstOrDefault(n => n.Nombre == destino);

                if (start == null || end == null)
                    return null;

                Dictionary<Nodo, int> dist = new Dictionary<Nodo, int>();
                Dictionary<Nodo, Nodo> padre = new Dictionary<Nodo, Nodo>();
                HashSet<Nodo> visitados = new HashSet<Nodo>();

                foreach (var nodo in Nodos)
                    dist[nodo] = int.MaxValue;

                dist[start] = 0;

                while (visitados.Count < Nodos.Count)
                {
                    Nodo actual = null;
                    int menor = int.MaxValue;

                    foreach (var n in Nodos)
                    {
                        if (!visitados.Contains(n) && dist[n] < menor)
                        {
                            menor = dist[n];
                            actual = n;
                        }
                    }

                    if (actual == null)
                        break;

                    visitados.Add(actual);

                    foreach (var vecino in actual.Conexiones.Keys)
                    {
                        int peso = actual.Conexiones[vecino];
                        int nuevaDist = dist[actual] + peso;

                        if (nuevaDist < dist[vecino])
                        {
                            dist[vecino] = nuevaDist;
                            padre[vecino] = actual;
                        }
                    }
                }

                if (!padre.ContainsKey(end))
                    return null;

                List<string> ruta = new List<string>();
                Nodo temp = end;

                while (temp != start)
                {
                    ruta.Add(temp.Nombre);
                    temp = padre[temp];
                }

                ruta.Add(start.Nombre);
                ruta.Reverse();
                return ruta;
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

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbRutas_AgregarEdificio.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del edificio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nodo nuevoNodo = new Nodo(tbRutas_AgregarEdificio.Text);
            grafo.AgregarNodo(nuevoNodo);


            tbRutas_AgregarEdificio.Clear();
            tbRutas_AgregarEdificio.Focus();

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

            tbConexion_Edificio1.Clear();
            tbConexion_Edificio2.Clear();
            tbConexion_Distancia.Clear();
            tbConexion_Edificio1.Focus();

            CargarGrafo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Opcion = cbRutas_BuscarPor.SelectedIndex;

            switch (Opcion)
            {
                case 0:
                    {
                        string inicio = tbRuta_Edificio1.Text;
                        string destino = tbRuta_Edificio2.Text;

                        var ruta = grafo.Dijkstra(inicio, destino);

                        if (ruta == null) lblRutas_RutaRecomendada.Text = "No existe ruta.";
                        
                        else lblRutas_RutaRecomendada.Text = string.Join(" → ", ruta);

                        tbRuta_Edificio1.Clear();
                        tbRuta_Edificio2.Clear();
                        tbRuta_Edificio1.Focus();

                        break;
                    }

                case 1:
                    {
                        string inicio = tbRuta_Edificio1.Text;
                        string destino = tbRuta_Edificio2.Text;

                        var ruta = grafo.BFS(inicio, destino);

                        if (ruta == null) lblRutas_RutaRecomendada.Text = "No existe ruta.";

                        else lblRutas_RutaRecomendada.Text = string.Join(" → ", ruta);

                        tbRuta_Edificio1.Clear();
                        tbRuta_Edificio2.Clear();
                        tbRuta_Edificio1.Focus();

                        break;
                    }
            }
        }

        private void btnRutas_EliminarEdificio_Click(object sender, EventArgs e)
        {
            string nombre = tbRutas_AgregarEdificio.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Escriba el nombre del edificio a eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = grafo.EliminarNodo(nombre);
            if (ok)
                MessageBox.Show($"Nodo '{nombre}' eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"No se encontró el nodo '{nombre}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            tbRutas_AgregarEdificio.Clear();
            tbRutas_AgregarEdificio.Focus();

            CargarGrafo();
        }

        private void btnRutas_EliminarConexion_Click(object sender, EventArgs e)
        {
            string desde = tbConexion_Edificio1.Text;
            string hacia = tbConexion_Edificio2.Text;

            if (string.IsNullOrEmpty(desde) || string.IsNullOrEmpty(hacia))
            {
                MessageBox.Show("Ingrese el nombre de ambos edificios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.Equals(desde, hacia, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("No puede eliminar una conexión hacia sí mismo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = grafo.EliminarConexion(desde, hacia);

            if (ok)
                MessageBox.Show($"Conexión {desde} ↔ {hacia} eliminada.", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"No existe conexión entre '{desde}' y '{hacia}', o algún nodo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            tbConexion_Edificio1.Clear();
            tbConexion_Edificio2.Clear();
            tbConexion_Edificio1.Focus();

            CargarGrafo();
        }
    }
}
