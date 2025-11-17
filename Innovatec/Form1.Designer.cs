namespace Innovatec
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Innovatec");
            this.Principal = new System.Windows.Forms.TabControl();
            this.PáginaPrincipal = new System.Windows.Forms.TabPage();
            this.Jerarquia = new System.Windows.Forms.TabPage();
            this.gbJerarquia_Contar = new System.Windows.Forms.GroupBox();
            this.lblJerarquia_ContarRamas = new System.Windows.Forms.Label();
            this.gbJerarquia_Recorrer = new System.Windows.Forms.GroupBox();
            this.btnJerarquia_Recorrer = new System.Windows.Forms.Button();
            this.lblJerarquia_Recorrer = new System.Windows.Forms.Label();
            this.cbJerarquia_FormaRecorrer = new System.Windows.Forms.ComboBox();
            this.lbJerarquia_Recorrer = new System.Windows.Forms.ListBox();
            this.gbJerarquia_Buscar = new System.Windows.Forms.GroupBox();
            this.btnJerarquia_Eliminar = new System.Windows.Forms.Button();
            this.brnJerarquia_Buscar = new System.Windows.Forms.Button();
            this.tbJerarquia_BuscarRama = new System.Windows.Forms.TextBox();
            this.lblJerarquia_Buscar = new System.Windows.Forms.Label();
            this.gbJerarquia_AgregarRama = new System.Windows.Forms.GroupBox();
            this.btnAgregarRama = new System.Windows.Forms.Button();
            this.tvJerarquia = new System.Windows.Forms.TreeView();
            this.tbJerarquia_AgregarRama = new System.Windows.Forms.TextBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbEdificios_Rutas = new System.Windows.Forms.GroupBox();
            this.gbRuta = new System.Windows.Forms.GroupBox();
            this.gbGrafo = new System.Windows.Forms.GroupBox();
            this.lblRutas = new System.Windows.Forms.Label();
            this.gbBuscarRuta = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbRutas_BuscarPor = new System.Windows.Forms.ComboBox();
            this.tbRuta_Edificio2 = new System.Windows.Forms.TextBox();
            this.tbRuta_Edificio1 = new System.Windows.Forms.TextBox();
            this.lblRuta_Edificio2 = new System.Windows.Forms.Label();
            this.lblRuta_Edificio1 = new System.Windows.Forms.Label();
            this.gbAgregar_Conexion = new System.Windows.Forms.GroupBox();
            this.btnAgregarConexion = new System.Windows.Forms.Button();
            this.tbConexion_Distancia = new System.Windows.Forms.TextBox();
            this.lblConexionDistancia = new System.Windows.Forms.Label();
            this.tbConexion_Edificio2 = new System.Windows.Forms.TextBox();
            this.lblConexionEdificio2 = new System.Windows.Forms.Label();
            this.tbConexion_Edificio1 = new System.Windows.Forms.TextBox();
            this.lblConexionEdificio1 = new System.Windows.Forms.Label();
            this.gbAgregarEdificio = new System.Windows.Forms.GroupBox();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.tbRutas_AgregarEdificio = new System.Windows.Forms.TextBox();
            this.lblNombreEdificioAgregar = new System.Windows.Forms.Label();
            this.Principal.SuspendLayout();
            this.Jerarquia.SuspendLayout();
            this.gbJerarquia_Contar.SuspendLayout();
            this.gbJerarquia_Recorrer.SuspendLayout();
            this.gbJerarquia_Buscar.SuspendLayout();
            this.gbJerarquia_AgregarRama.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbEdificios_Rutas.SuspendLayout();
            this.gbGrafo.SuspendLayout();
            this.gbBuscarRuta.SuspendLayout();
            this.gbAgregar_Conexion.SuspendLayout();
            this.gbAgregarEdificio.SuspendLayout();
            this.SuspendLayout();
            // 
            // Principal
            // 
            this.Principal.Controls.Add(this.PáginaPrincipal);
            this.Principal.Controls.Add(this.Jerarquia);
            this.Principal.Controls.Add(this.tabPage3);
            this.Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Principal.Location = new System.Drawing.Point(12, 12);
            this.Principal.Name = "Principal";
            this.Principal.SelectedIndex = 0;
            this.Principal.Size = new System.Drawing.Size(1240, 657);
            this.Principal.TabIndex = 0;
            // 
            // PáginaPrincipal
            // 
            this.PáginaPrincipal.BackgroundImage = global::Innovatec.Properties.Resources.innovatec;
            this.PáginaPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PáginaPrincipal.Location = new System.Drawing.Point(4, 29);
            this.PáginaPrincipal.Name = "PáginaPrincipal";
            this.PáginaPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.PáginaPrincipal.Size = new System.Drawing.Size(1232, 624);
            this.PáginaPrincipal.TabIndex = 0;
            this.PáginaPrincipal.Text = "Página Principal";
            this.PáginaPrincipal.UseVisualStyleBackColor = true;
            // 
            // Jerarquia
            // 
            this.Jerarquia.Controls.Add(this.gbJerarquia_Contar);
            this.Jerarquia.Controls.Add(this.gbJerarquia_Recorrer);
            this.Jerarquia.Controls.Add(this.gbJerarquia_Buscar);
            this.Jerarquia.Controls.Add(this.gbJerarquia_AgregarRama);
            this.Jerarquia.Location = new System.Drawing.Point(4, 29);
            this.Jerarquia.Name = "Jerarquia";
            this.Jerarquia.Padding = new System.Windows.Forms.Padding(3);
            this.Jerarquia.Size = new System.Drawing.Size(1232, 624);
            this.Jerarquia.TabIndex = 1;
            this.Jerarquia.Text = "Jerarquía Organizativa";
            this.Jerarquia.UseVisualStyleBackColor = true;
            // 
            // gbJerarquia_Contar
            // 
            this.gbJerarquia_Contar.Controls.Add(this.lblJerarquia_ContarRamas);
            this.gbJerarquia_Contar.Location = new System.Drawing.Point(595, 134);
            this.gbJerarquia_Contar.Name = "gbJerarquia_Contar";
            this.gbJerarquia_Contar.Size = new System.Drawing.Size(631, 75);
            this.gbJerarquia_Contar.TabIndex = 3;
            this.gbJerarquia_Contar.TabStop = false;
            this.gbJerarquia_Contar.Text = "Contar";
            // 
            // lblJerarquia_ContarRamas
            // 
            this.lblJerarquia_ContarRamas.AutoSize = true;
            this.lblJerarquia_ContarRamas.Location = new System.Drawing.Point(33, 32);
            this.lblJerarquia_ContarRamas.Name = "lblJerarquia_ContarRamas";
            this.lblJerarquia_ContarRamas.Size = new System.Drawing.Size(152, 20);
            this.lblJerarquia_ContarRamas.TabIndex = 8;
            this.lblJerarquia_ContarRamas.Text = "Número de ramas: 1";
            // 
            // gbJerarquia_Recorrer
            // 
            this.gbJerarquia_Recorrer.Controls.Add(this.btnJerarquia_Recorrer);
            this.gbJerarquia_Recorrer.Controls.Add(this.lblJerarquia_Recorrer);
            this.gbJerarquia_Recorrer.Controls.Add(this.cbJerarquia_FormaRecorrer);
            this.gbJerarquia_Recorrer.Controls.Add(this.lbJerarquia_Recorrer);
            this.gbJerarquia_Recorrer.Location = new System.Drawing.Point(595, 215);
            this.gbJerarquia_Recorrer.Name = "gbJerarquia_Recorrer";
            this.gbJerarquia_Recorrer.Size = new System.Drawing.Size(631, 403);
            this.gbJerarquia_Recorrer.TabIndex = 2;
            this.gbJerarquia_Recorrer.TabStop = false;
            this.gbJerarquia_Recorrer.Text = "Recorrer";
            // 
            // btnJerarquia_Recorrer
            // 
            this.btnJerarquia_Recorrer.Location = new System.Drawing.Point(485, 30);
            this.btnJerarquia_Recorrer.Name = "btnJerarquia_Recorrer";
            this.btnJerarquia_Recorrer.Size = new System.Drawing.Size(122, 39);
            this.btnJerarquia_Recorrer.TabIndex = 8;
            this.btnJerarquia_Recorrer.Text = "Recorrer";
            this.btnJerarquia_Recorrer.UseVisualStyleBackColor = true;
            this.btnJerarquia_Recorrer.Click += new System.EventHandler(this.btnJerarquia_Recorrer_Click);
            // 
            // lblJerarquia_Recorrer
            // 
            this.lblJerarquia_Recorrer.AutoSize = true;
            this.lblJerarquia_Recorrer.Location = new System.Drawing.Point(33, 39);
            this.lblJerarquia_Recorrer.Name = "lblJerarquia_Recorrer";
            this.lblJerarquia_Recorrer.Size = new System.Drawing.Size(225, 20);
            this.lblJerarquia_Recorrer.TabIndex = 8;
            this.lblJerarquia_Recorrer.Text = "Selecione la forma de recorrer:";
            // 
            // cbJerarquia_FormaRecorrer
            // 
            this.cbJerarquia_FormaRecorrer.FormattingEnabled = true;
            this.cbJerarquia_FormaRecorrer.Items.AddRange(new object[] {
            "Pre-Orden",
            "Post-Orden",
            "Por Niveles"});
            this.cbJerarquia_FormaRecorrer.Location = new System.Drawing.Point(264, 36);
            this.cbJerarquia_FormaRecorrer.Name = "cbJerarquia_FormaRecorrer";
            this.cbJerarquia_FormaRecorrer.Size = new System.Drawing.Size(215, 28);
            this.cbJerarquia_FormaRecorrer.TabIndex = 1;
            // 
            // lbJerarquia_Recorrer
            // 
            this.lbJerarquia_Recorrer.FormattingEnabled = true;
            this.lbJerarquia_Recorrer.ItemHeight = 20;
            this.lbJerarquia_Recorrer.Location = new System.Drawing.Point(6, 89);
            this.lbJerarquia_Recorrer.Name = "lbJerarquia_Recorrer";
            this.lbJerarquia_Recorrer.Size = new System.Drawing.Size(619, 304);
            this.lbJerarquia_Recorrer.TabIndex = 0;
            // 
            // gbJerarquia_Buscar
            // 
            this.gbJerarquia_Buscar.Controls.Add(this.btnJerarquia_Eliminar);
            this.gbJerarquia_Buscar.Controls.Add(this.brnJerarquia_Buscar);
            this.gbJerarquia_Buscar.Controls.Add(this.tbJerarquia_BuscarRama);
            this.gbJerarquia_Buscar.Controls.Add(this.lblJerarquia_Buscar);
            this.gbJerarquia_Buscar.Location = new System.Drawing.Point(595, 6);
            this.gbJerarquia_Buscar.Name = "gbJerarquia_Buscar";
            this.gbJerarquia_Buscar.Size = new System.Drawing.Size(631, 122);
            this.gbJerarquia_Buscar.TabIndex = 1;
            this.gbJerarquia_Buscar.TabStop = false;
            this.gbJerarquia_Buscar.Text = "Buscar";
            // 
            // btnJerarquia_Eliminar
            // 
            this.btnJerarquia_Eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJerarquia_Eliminar.Location = new System.Drawing.Point(522, 71);
            this.btnJerarquia_Eliminar.Name = "btnJerarquia_Eliminar";
            this.btnJerarquia_Eliminar.Size = new System.Drawing.Size(85, 39);
            this.btnJerarquia_Eliminar.TabIndex = 7;
            this.btnJerarquia_Eliminar.Text = "Eliminar";
            this.btnJerarquia_Eliminar.UseVisualStyleBackColor = true;
            this.btnJerarquia_Eliminar.Click += new System.EventHandler(this.btnJerarquia_Eliminar_Click);
            // 
            // brnJerarquia_Buscar
            // 
            this.brnJerarquia_Buscar.Location = new System.Drawing.Point(522, 26);
            this.brnJerarquia_Buscar.Name = "brnJerarquia_Buscar";
            this.brnJerarquia_Buscar.Size = new System.Drawing.Size(85, 39);
            this.brnJerarquia_Buscar.TabIndex = 6;
            this.brnJerarquia_Buscar.Text = "Buscar";
            this.brnJerarquia_Buscar.UseVisualStyleBackColor = true;
            this.brnJerarquia_Buscar.Click += new System.EventHandler(this.brnJerarquia_Buscar_Click);
            // 
            // tbJerarquia_BuscarRama
            // 
            this.tbJerarquia_BuscarRama.Location = new System.Drawing.Point(149, 32);
            this.tbJerarquia_BuscarRama.Name = "tbJerarquia_BuscarRama";
            this.tbJerarquia_BuscarRama.Size = new System.Drawing.Size(367, 26);
            this.tbJerarquia_BuscarRama.TabIndex = 5;
            // 
            // lblJerarquia_Buscar
            // 
            this.lblJerarquia_Buscar.AutoSize = true;
            this.lblJerarquia_Buscar.Location = new System.Drawing.Point(33, 35);
            this.lblJerarquia_Buscar.Name = "lblJerarquia_Buscar";
            this.lblJerarquia_Buscar.Size = new System.Drawing.Size(110, 20);
            this.lblJerarquia_Buscar.TabIndex = 4;
            this.lblJerarquia_Buscar.Text = "Buscar Rama:";
            // 
            // gbJerarquia_AgregarRama
            // 
            this.gbJerarquia_AgregarRama.Controls.Add(this.btnAgregarRama);
            this.gbJerarquia_AgregarRama.Controls.Add(this.tvJerarquia);
            this.gbJerarquia_AgregarRama.Controls.Add(this.tbJerarquia_AgregarRama);
            this.gbJerarquia_AgregarRama.Controls.Add(this.lblAgregar);
            this.gbJerarquia_AgregarRama.Location = new System.Drawing.Point(6, 6);
            this.gbJerarquia_AgregarRama.Name = "gbJerarquia_AgregarRama";
            this.gbJerarquia_AgregarRama.Size = new System.Drawing.Size(583, 612);
            this.gbJerarquia_AgregarRama.TabIndex = 0;
            this.gbJerarquia_AgregarRama.TabStop = false;
            this.gbJerarquia_AgregarRama.Text = "Jerarquía";
            // 
            // btnAgregarRama
            // 
            this.btnAgregarRama.Location = new System.Drawing.Point(455, 32);
            this.btnAgregarRama.Name = "btnAgregarRama";
            this.btnAgregarRama.Size = new System.Drawing.Size(85, 39);
            this.btnAgregarRama.TabIndex = 3;
            this.btnAgregarRama.Text = "Agregar";
            this.btnAgregarRama.UseVisualStyleBackColor = true;
            this.btnAgregarRama.Click += new System.EventHandler(this.btnAgregarRama_Click);
            // 
            // tvJerarquia
            // 
            this.tvJerarquia.Location = new System.Drawing.Point(34, 91);
            this.tvJerarquia.Name = "tvJerarquia";
            treeNode1.Name = "Innovatec";
            treeNode1.Text = "Innovatec";
            this.tvJerarquia.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvJerarquia.Size = new System.Drawing.Size(506, 515);
            this.tvJerarquia.TabIndex = 2;
            // 
            // tbJerarquia_AgregarRama
            // 
            this.tbJerarquia_AgregarRama.Location = new System.Drawing.Point(153, 38);
            this.tbJerarquia_AgregarRama.Name = "tbJerarquia_AgregarRama";
            this.tbJerarquia_AgregarRama.Size = new System.Drawing.Size(296, 26);
            this.tbJerarquia_AgregarRama.TabIndex = 1;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(30, 41);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(117, 20);
            this.lblAgregar.TabIndex = 0;
            this.lblAgregar.Text = "Agregar Rama:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbEdificios_Rutas);
            this.tabPage3.Controls.Add(this.gbBuscarRuta);
            this.tabPage3.Controls.Add(this.gbAgregar_Conexion);
            this.tabPage3.Controls.Add(this.gbAgregarEdificio);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1232, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sistema de Rutas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbEdificios_Rutas
            // 
            this.gbEdificios_Rutas.Controls.Add(this.gbRuta);
            this.gbEdificios_Rutas.Controls.Add(this.gbGrafo);
            this.gbEdificios_Rutas.Location = new System.Drawing.Point(482, 6);
            this.gbEdificios_Rutas.Name = "gbEdificios_Rutas";
            this.gbEdificios_Rutas.Size = new System.Drawing.Size(747, 612);
            this.gbEdificios_Rutas.TabIndex = 3;
            this.gbEdificios_Rutas.TabStop = false;
            // 
            // gbRuta
            // 
            this.gbRuta.Location = new System.Drawing.Point(6, 492);
            this.gbRuta.Name = "gbRuta";
            this.gbRuta.Size = new System.Drawing.Size(735, 114);
            this.gbRuta.TabIndex = 2;
            this.gbRuta.TabStop = false;
            this.gbRuta.Text = "Ruta Recomendada";
            // 
            // gbGrafo
            // 
            this.gbGrafo.Controls.Add(this.lblRutas);
            this.gbGrafo.Location = new System.Drawing.Point(6, 25);
            this.gbGrafo.Name = "gbGrafo";
            this.gbGrafo.Size = new System.Drawing.Size(738, 461);
            this.gbGrafo.TabIndex = 1;
            this.gbGrafo.TabStop = false;
            this.gbGrafo.Text = "Grafo";
            // 
            // lblRutas
            // 
            this.lblRutas.AutoSize = true;
            this.lblRutas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRutas.Location = new System.Drawing.Point(20, 29);
            this.lblRutas.Name = "lblRutas";
            this.lblRutas.Size = new System.Drawing.Size(2, 22);
            this.lblRutas.TabIndex = 0;
            this.lblRutas.Visible = false;
            // 
            // gbBuscarRuta
            // 
            this.gbBuscarRuta.Controls.Add(this.btnBuscar);
            this.gbBuscarRuta.Controls.Add(this.cbRutas_BuscarPor);
            this.gbBuscarRuta.Controls.Add(this.tbRuta_Edificio2);
            this.gbBuscarRuta.Controls.Add(this.tbRuta_Edificio1);
            this.gbBuscarRuta.Controls.Add(this.lblRuta_Edificio2);
            this.gbBuscarRuta.Controls.Add(this.lblRuta_Edificio1);
            this.gbBuscarRuta.Location = new System.Drawing.Point(7, 439);
            this.gbBuscarRuta.Name = "gbBuscarRuta";
            this.gbBuscarRuta.Size = new System.Drawing.Size(443, 179);
            this.gbBuscarRuta.TabIndex = 2;
            this.gbBuscarRuta.TabStop = false;
            this.gbBuscarRuta.Text = "Buscar Ruta";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(325, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar por:";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbRutas_BuscarPor
            // 
            this.cbRutas_BuscarPor.AllowDrop = true;
            this.cbRutas_BuscarPor.FormattingEnabled = true;
            this.cbRutas_BuscarPor.Items.AddRange(new object[] {
            "Distancia",
            "Paradas"});
            this.cbRutas_BuscarPor.Location = new System.Drawing.Point(325, 121);
            this.cbRutas_BuscarPor.Name = "cbRutas_BuscarPor";
            this.cbRutas_BuscarPor.Size = new System.Drawing.Size(103, 28);
            this.cbRutas_BuscarPor.TabIndex = 3;
            // 
            // tbRuta_Edificio2
            // 
            this.tbRuta_Edificio2.Location = new System.Drawing.Point(16, 123);
            this.tbRuta_Edificio2.Name = "tbRuta_Edificio2";
            this.tbRuta_Edificio2.Size = new System.Drawing.Size(303, 26);
            this.tbRuta_Edificio2.TabIndex = 12;
            // 
            // tbRuta_Edificio1
            // 
            this.tbRuta_Edificio1.Location = new System.Drawing.Point(16, 56);
            this.tbRuta_Edificio1.Name = "tbRuta_Edificio1";
            this.tbRuta_Edificio1.Size = new System.Drawing.Size(303, 26);
            this.tbRuta_Edificio1.TabIndex = 10;
            // 
            // lblRuta_Edificio2
            // 
            this.lblRuta_Edificio2.AutoSize = true;
            this.lblRuta_Edificio2.Location = new System.Drawing.Point(12, 100);
            this.lblRuta_Edificio2.Name = "lblRuta_Edificio2";
            this.lblRuta_Edificio2.Size = new System.Drawing.Size(158, 20);
            this.lblRuta_Edificio2.TabIndex = 11;
            this.lblRuta_Edificio2.Text = "Nombre del Edificio 2";
            // 
            // lblRuta_Edificio1
            // 
            this.lblRuta_Edificio1.AutoSize = true;
            this.lblRuta_Edificio1.Location = new System.Drawing.Point(12, 33);
            this.lblRuta_Edificio1.Name = "lblRuta_Edificio1";
            this.lblRuta_Edificio1.Size = new System.Drawing.Size(158, 20);
            this.lblRuta_Edificio1.TabIndex = 9;
            this.lblRuta_Edificio1.Text = "Nombre del Edificio 1";
            // 
            // gbAgregar_Conexion
            // 
            this.gbAgregar_Conexion.Controls.Add(this.btnAgregarConexion);
            this.gbAgregar_Conexion.Controls.Add(this.tbConexion_Distancia);
            this.gbAgregar_Conexion.Controls.Add(this.lblConexionDistancia);
            this.gbAgregar_Conexion.Controls.Add(this.tbConexion_Edificio2);
            this.gbAgregar_Conexion.Controls.Add(this.lblConexionEdificio2);
            this.gbAgregar_Conexion.Controls.Add(this.tbConexion_Edificio1);
            this.gbAgregar_Conexion.Controls.Add(this.lblConexionEdificio1);
            this.gbAgregar_Conexion.Location = new System.Drawing.Point(7, 132);
            this.gbAgregar_Conexion.Name = "gbAgregar_Conexion";
            this.gbAgregar_Conexion.Size = new System.Drawing.Size(443, 300);
            this.gbAgregar_Conexion.TabIndex = 1;
            this.gbAgregar_Conexion.TabStop = false;
            this.gbAgregar_Conexion.Text = "Agregar Conexión";
            // 
            // btnAgregarConexion
            // 
            this.btnAgregarConexion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarConexion.Location = new System.Drawing.Point(155, 242);
            this.btnAgregarConexion.Name = "btnAgregarConexion";
            this.btnAgregarConexion.Size = new System.Drawing.Size(164, 31);
            this.btnAgregarConexion.TabIndex = 3;
            this.btnAgregarConexion.Text = "Agregar Conexión";
            this.btnAgregarConexion.UseVisualStyleBackColor = true;
            this.btnAgregarConexion.Click += new System.EventHandler(this.btnAgregarConexion_Click);
            // 
            // tbConexion_Distancia
            // 
            this.tbConexion_Distancia.Location = new System.Drawing.Point(16, 196);
            this.tbConexion_Distancia.Name = "tbConexion_Distancia";
            this.tbConexion_Distancia.Size = new System.Drawing.Size(303, 26);
            this.tbConexion_Distancia.TabIndex = 8;
            // 
            // lblConexionDistancia
            // 
            this.lblConexionDistancia.AutoSize = true;
            this.lblConexionDistancia.Location = new System.Drawing.Point(12, 173);
            this.lblConexionDistancia.Name = "lblConexionDistancia";
            this.lblConexionDistancia.Size = new System.Drawing.Size(179, 20);
            this.lblConexionDistancia.TabIndex = 7;
            this.lblConexionDistancia.Text = "Distancia entre Edificios";
            // 
            // tbConexion_Edificio2
            // 
            this.tbConexion_Edificio2.Location = new System.Drawing.Point(16, 127);
            this.tbConexion_Edificio2.Name = "tbConexion_Edificio2";
            this.tbConexion_Edificio2.Size = new System.Drawing.Size(303, 26);
            this.tbConexion_Edificio2.TabIndex = 6;
            // 
            // lblConexionEdificio2
            // 
            this.lblConexionEdificio2.AutoSize = true;
            this.lblConexionEdificio2.Location = new System.Drawing.Point(12, 104);
            this.lblConexionEdificio2.Name = "lblConexionEdificio2";
            this.lblConexionEdificio2.Size = new System.Drawing.Size(158, 20);
            this.lblConexionEdificio2.TabIndex = 5;
            this.lblConexionEdificio2.Text = "Nombre del Edificio 2";
            // 
            // tbConexion_Edificio1
            // 
            this.tbConexion_Edificio1.Location = new System.Drawing.Point(16, 60);
            this.tbConexion_Edificio1.Name = "tbConexion_Edificio1";
            this.tbConexion_Edificio1.Size = new System.Drawing.Size(303, 26);
            this.tbConexion_Edificio1.TabIndex = 4;
            // 
            // lblConexionEdificio1
            // 
            this.lblConexionEdificio1.AutoSize = true;
            this.lblConexionEdificio1.Location = new System.Drawing.Point(12, 37);
            this.lblConexionEdificio1.Name = "lblConexionEdificio1";
            this.lblConexionEdificio1.Size = new System.Drawing.Size(158, 20);
            this.lblConexionEdificio1.TabIndex = 3;
            this.lblConexionEdificio1.Text = "Nombre del Edificio 1";
            // 
            // gbAgregarEdificio
            // 
            this.gbAgregarEdificio.Controls.Add(this.btnAgregarEdificio);
            this.gbAgregarEdificio.Controls.Add(this.tbRutas_AgregarEdificio);
            this.gbAgregarEdificio.Controls.Add(this.lblNombreEdificioAgregar);
            this.gbAgregarEdificio.Location = new System.Drawing.Point(3, 6);
            this.gbAgregarEdificio.Name = "gbAgregarEdificio";
            this.gbAgregarEdificio.Size = new System.Drawing.Size(447, 120);
            this.gbAgregarEdificio.TabIndex = 0;
            this.gbAgregarEdificio.TabStop = false;
            this.gbAgregarEdificio.Text = "Agregar Edificio";
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Location = new System.Drawing.Point(329, 31);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(103, 48);
            this.btnAgregarEdificio.TabIndex = 2;
            this.btnAgregarEdificio.Text = "Agregar";
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            this.btnAgregarEdificio.Click += new System.EventHandler(this.btnAgregarEdificio_Click);
            // 
            // tbRutas_AgregarEdificio
            // 
            this.tbRutas_AgregarEdificio.Location = new System.Drawing.Point(20, 54);
            this.tbRutas_AgregarEdificio.Name = "tbRutas_AgregarEdificio";
            this.tbRutas_AgregarEdificio.Size = new System.Drawing.Size(303, 26);
            this.tbRutas_AgregarEdificio.TabIndex = 1;
            // 
            // lblNombreEdificioAgregar
            // 
            this.lblNombreEdificioAgregar.AutoSize = true;
            this.lblNombreEdificioAgregar.Location = new System.Drawing.Point(16, 31);
            this.lblNombreEdificioAgregar.Name = "lblNombreEdificioAgregar";
            this.lblNombreEdificioAgregar.Size = new System.Drawing.Size(145, 20);
            this.lblNombreEdificioAgregar.TabIndex = 0;
            this.lblNombreEdificioAgregar.Text = "Nombre del Edificio";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Principal);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Innovatec";
            this.Principal.ResumeLayout(false);
            this.Jerarquia.ResumeLayout(false);
            this.gbJerarquia_Contar.ResumeLayout(false);
            this.gbJerarquia_Contar.PerformLayout();
            this.gbJerarquia_Recorrer.ResumeLayout(false);
            this.gbJerarquia_Recorrer.PerformLayout();
            this.gbJerarquia_Buscar.ResumeLayout(false);
            this.gbJerarquia_Buscar.PerformLayout();
            this.gbJerarquia_AgregarRama.ResumeLayout(false);
            this.gbJerarquia_AgregarRama.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbEdificios_Rutas.ResumeLayout(false);
            this.gbGrafo.ResumeLayout(false);
            this.gbGrafo.PerformLayout();
            this.gbBuscarRuta.ResumeLayout(false);
            this.gbBuscarRuta.PerformLayout();
            this.gbAgregar_Conexion.ResumeLayout(false);
            this.gbAgregar_Conexion.PerformLayout();
            this.gbAgregarEdificio.ResumeLayout(false);
            this.gbAgregarEdificio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Principal;
        private System.Windows.Forms.TabPage PáginaPrincipal;
        private System.Windows.Forms.TabPage Jerarquia;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbJerarquia_AgregarRama;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.TextBox tbJerarquia_AgregarRama;
        private System.Windows.Forms.TreeView tvJerarquia;
        private System.Windows.Forms.GroupBox gbAgregarEdificio;
        private System.Windows.Forms.Label lblNombreEdificioAgregar;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.TextBox tbRutas_AgregarEdificio;
        private System.Windows.Forms.GroupBox gbAgregar_Conexion;
        private System.Windows.Forms.TextBox tbConexion_Edificio1;
        private System.Windows.Forms.Label lblConexionEdificio1;
        private System.Windows.Forms.Button btnAgregarConexion;
        private System.Windows.Forms.TextBox tbConexion_Distancia;
        private System.Windows.Forms.Label lblConexionDistancia;
        private System.Windows.Forms.TextBox tbConexion_Edificio2;
        private System.Windows.Forms.Label lblConexionEdificio2;
        private System.Windows.Forms.GroupBox gbBuscarRuta;
        private System.Windows.Forms.TextBox tbRuta_Edificio2;
        private System.Windows.Forms.TextBox tbRuta_Edificio1;
        private System.Windows.Forms.Label lblRuta_Edificio2;
        private System.Windows.Forms.Label lblRuta_Edificio1;
        private System.Windows.Forms.ComboBox cbRutas_BuscarPor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbEdificios_Rutas;
        private System.Windows.Forms.Label lblRutas;
        private System.Windows.Forms.GroupBox gbRuta;
        private System.Windows.Forms.GroupBox gbGrafo;
        private System.Windows.Forms.Button btnAgregarRama;
        private System.Windows.Forms.GroupBox gbJerarquia_Buscar;
        private System.Windows.Forms.GroupBox gbJerarquia_Contar;
        private System.Windows.Forms.GroupBox gbJerarquia_Recorrer;
        private System.Windows.Forms.Button brnJerarquia_Buscar;
        private System.Windows.Forms.TextBox tbJerarquia_BuscarRama;
        private System.Windows.Forms.Label lblJerarquia_Buscar;
        private System.Windows.Forms.Button btnJerarquia_Eliminar;
        private System.Windows.Forms.Label lblJerarquia_ContarRamas;
        private System.Windows.Forms.ComboBox cbJerarquia_FormaRecorrer;
        private System.Windows.Forms.ListBox lbJerarquia_Recorrer;
        private System.Windows.Forms.Button btnJerarquia_Recorrer;
        private System.Windows.Forms.Label lblJerarquia_Recorrer;
    }
}

