
namespace GoFitnessGym
{
    partial class modulo_de_roles_y_permisos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle estilo_encabezado_roles =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle estilo_celdas_roles =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle estilo_encabezado_permisos =
                new System.Windows.Forms.DataGridViewCellStyle();

            System.Windows.Forms.DataGridViewCellStyle estilo_celdas_permisos =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();

            this.tab_roles_y_permisos =
                new System.Windows.Forms.TabControl();

            this.tab_roles =
                new System.Windows.Forms.TabPage();

            this.tab_permisos =
                new System.Windows.Forms.TabPage();

            this.pnl_busqueda_roles =
                new System.Windows.Forms.Panel();

            this.lbl_buscar_rol =
                new System.Windows.Forms.Label();

            this.txt_buscar_rol =
                new System.Windows.Forms.TextBox();

            this.btn_buscar_rol =
                new System.Windows.Forms.Button();

            this.btn_limpiar_roles =
                new System.Windows.Forms.Button();

            this.pnl_tabla_roles =
                new System.Windows.Forms.Panel();

            this.dgv_roles =
                new System.Windows.Forms.DataGridView();

            this.col_codigo_rol =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_nombre_rol =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_total_usuarios =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_estado_rol =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnl_acciones_roles =
                new System.Windows.Forms.Panel();

            this.btn_nuevo_rol =
                new System.Windows.Forms.Button();

            this.btn_editar_rol =
                new System.Windows.Forms.Button();

            this.btn_cambiar_estado_rol =
                new System.Windows.Forms.Button();

            this.pnl_seleccion_rol =
                new System.Windows.Forms.Panel();

            this.lbl_seleccionar_rol =
                new System.Windows.Forms.Label();

            this.cbo_seleccionar_rol =
                new System.Windows.Forms.ComboBox();

            this.lbl_rol_en_configuracion =
                new System.Windows.Forms.Label();

            this.pnl_filtro_permisos =
                new System.Windows.Forms.Panel();

            this.lbl_categoria =
                new System.Windows.Forms.Label();

            this.cbo_categoria =
                new System.Windows.Forms.ComboBox();

            this.pnl_tabla_permisos =
                new System.Windows.Forms.Panel();

            this.dgv_permisos =
                new System.Windows.Forms.DataGridView();

            this.col_programa =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_acceder =
                new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.col_registrar =
                new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.col_editar =
                new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.col_cambiar_estado =
                new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.col_imprimir =
                new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.col_exportar =
                new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.lbl_advertencia =
                new System.Windows.Forms.Label();

            this.pnl_acciones_permisos =
                new System.Windows.Forms.Panel();

            this.btn_marcar_todos =
                new System.Windows.Forms.Button();

            this.btn_desmarcar_todos =
                new System.Windows.Forms.Button();

            this.btn_guardar_permisos =
                new System.Windows.Forms.Button();

            this.pnl_acciones =
                new System.Windows.Forms.Panel();

            this.btn_cerrar =
                new System.Windows.Forms.Button();

            this.tab_roles_y_permisos.SuspendLayout();
            this.tab_roles.SuspendLayout();
            this.tab_permisos.SuspendLayout();
            this.pnl_busqueda_roles.SuspendLayout();
            this.pnl_tabla_roles.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgv_roles)).BeginInit();

            this.pnl_acciones_roles.SuspendLayout();
            this.pnl_seleccion_rol.SuspendLayout();
            this.pnl_filtro_permisos.SuspendLayout();
            this.pnl_tabla_permisos.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgv_permisos)).BeginInit();

            this.pnl_acciones_permisos.SuspendLayout();
            this.pnl_acciones.SuspendLayout();
            this.SuspendLayout();

            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;

            this.lbl_titulo.Font = new System.Drawing.Font(
                "Lexend",
                16F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lbl_titulo.ForeColor =
                System.Drawing.Color.FromArgb(26, 32, 44);

            this.lbl_titulo.Location =
                new System.Drawing.Point(30, 18);

            this.lbl_titulo.Name =
                "lbl_titulo";

            this.lbl_titulo.Size =
                new System.Drawing.Size(267, 43);

            this.lbl_titulo.TabIndex = 0;

            this.lbl_titulo.Text =
                "Roles y Permisos";

            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;

            this.lbl_subtitulo.Font = new System.Drawing.Font(
                "Lexend",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0)));

            this.lbl_subtitulo.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.lbl_subtitulo.Location =
                new System.Drawing.Point(32, 59);

            this.lbl_subtitulo.Name =
                "lbl_subtitulo";

            this.lbl_subtitulo.Size =
                new System.Drawing.Size(584, 27);

            this.lbl_subtitulo.TabIndex = 1;

            this.lbl_subtitulo.Text =
                "Administre los roles y defina el acceso a las funciones del sistema";

            // 
            // tab_roles_y_permisos
            // 
            this.tab_roles_y_permisos.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom) |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.tab_roles_y_permisos.Controls.Add(
                this.tab_roles);

            this.tab_roles_y_permisos.Controls.Add(
                this.tab_permisos);

            this.tab_roles_y_permisos.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.tab_roles_y_permisos.Location =
                new System.Drawing.Point(30, 101);

            this.tab_roles_y_permisos.Name =
                "tab_roles_y_permisos";

            this.tab_roles_y_permisos.SelectedIndex = 0;

            this.tab_roles_y_permisos.Size =
                new System.Drawing.Size(1140, 535);

            this.tab_roles_y_permisos.TabIndex = 2;

            // 
            // tab_roles
            // 
            this.tab_roles.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            this.tab_roles.Controls.Add(
                this.pnl_busqueda_roles);

            this.tab_roles.Controls.Add(
                this.pnl_tabla_roles);

            this.tab_roles.Controls.Add(
                this.pnl_acciones_roles);

            this.tab_roles.Location =
                new System.Drawing.Point(4, 36);

            this.tab_roles.Name =
                "tab_roles";

            this.tab_roles.Padding =
                new System.Windows.Forms.Padding(18);

            this.tab_roles.Size =
                new System.Drawing.Size(1132, 495);

            this.tab_roles.TabIndex = 0;

            this.tab_roles.Text =
                "Roles";

            // 
            // pnl_busqueda_roles
            // 
            this.pnl_busqueda_roles.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_busqueda_roles.BackColor =
                System.Drawing.Color.White;

            this.pnl_busqueda_roles.Controls.Add(
                this.lbl_buscar_rol);

            this.pnl_busqueda_roles.Controls.Add(
                this.txt_buscar_rol);

            this.pnl_busqueda_roles.Controls.Add(
                this.btn_buscar_rol);

            this.pnl_busqueda_roles.Controls.Add(
                this.btn_limpiar_roles);

            this.pnl_busqueda_roles.Location =
                new System.Drawing.Point(21, 18);

            this.pnl_busqueda_roles.Name =
                "pnl_busqueda_roles";

            this.pnl_busqueda_roles.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_busqueda_roles.Size =
                new System.Drawing.Size(1070, 80);

            this.pnl_busqueda_roles.TabIndex = 0;

            // 
            // lbl_buscar_rol
            // 
            this.lbl_buscar_rol.AutoSize = true;

            this.lbl_buscar_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_buscar_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_buscar_rol.Location =
                new System.Drawing.Point(15, 10);

            this.lbl_buscar_rol.Name =
                "lbl_buscar_rol";

            this.lbl_buscar_rol.Size =
                new System.Drawing.Size(88, 24);

            this.lbl_buscar_rol.TabIndex = 0;

            this.lbl_buscar_rol.Text =
                "Buscar rol:";

            // 
            // txt_buscar_rol
            // 
            this.txt_buscar_rol.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.txt_buscar_rol.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_buscar_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_buscar_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_buscar_rol.Location =
                new System.Drawing.Point(15, 37);

            this.txt_buscar_rol.Name =
                "txt_buscar_rol";

            this.txt_buscar_rol.Size =
                new System.Drawing.Size(765, 28);

            this.txt_buscar_rol.TabIndex = 1;

            // 
            // btn_buscar_rol
            // 
            this.btn_buscar_rol.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_buscar_rol.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.btn_buscar_rol.FlatAppearance.BorderSize = 0;

            this.btn_buscar_rol.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_buscar_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_buscar_rol.ForeColor =
                System.Drawing.Color.White;

            this.btn_buscar_rol.Location =
                new System.Drawing.Point(795, 25);

            this.btn_buscar_rol.Name =
                "btn_buscar_rol";

            this.btn_buscar_rol.Size =
                new System.Drawing.Size(120, 40);

            this.btn_buscar_rol.TabIndex = 2;

            this.btn_buscar_rol.Text =
                "Buscar";

            this.btn_buscar_rol.UseVisualStyleBackColor = false;

            // 
            // btn_limpiar_roles
            // 
            this.btn_limpiar_roles.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_limpiar_roles.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_limpiar_roles.FlatAppearance.BorderSize = 0;

            this.btn_limpiar_roles.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_limpiar_roles.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_limpiar_roles.ForeColor =
                System.Drawing.Color.White;

            this.btn_limpiar_roles.Location =
                new System.Drawing.Point(925, 25);

            this.btn_limpiar_roles.Name =
                "btn_limpiar_roles";

            this.btn_limpiar_roles.Size =
                new System.Drawing.Size(127, 40);

            this.btn_limpiar_roles.TabIndex = 3;

            this.btn_limpiar_roles.Text =
                "Limpiar";

            this.btn_limpiar_roles.UseVisualStyleBackColor = false;

            // 
            // pnl_tabla_roles
            // 
            this.pnl_tabla_roles.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom) |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_tabla_roles.BackColor =
                System.Drawing.Color.White;

            this.pnl_tabla_roles.Controls.Add(
                this.dgv_roles);

            this.pnl_tabla_roles.Location =
                new System.Drawing.Point(21, 110);

            this.pnl_tabla_roles.Name =
                "pnl_tabla_roles";

            this.pnl_tabla_roles.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_tabla_roles.Size =
                new System.Drawing.Size(1070, 297);

            this.pnl_tabla_roles.TabIndex = 1;

            // 
            // dgv_roles
            // 
            this.dgv_roles.AllowUserToAddRows = false;
            this.dgv_roles.AllowUserToDeleteRows = false;
            this.dgv_roles.AllowUserToResizeRows = false;

            this.dgv_roles.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgv_roles.BackgroundColor =
                System.Drawing.Color.White;

            this.dgv_roles.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgv_roles.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle
                .SingleHorizontal;

            this.dgv_roles.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            estilo_encabezado_roles.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            estilo_encabezado_roles.BackColor =
                System.Drawing.Color.FromArgb(243, 244, 246);

            estilo_encabezado_roles.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            estilo_encabezado_roles.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            estilo_encabezado_roles.SelectionBackColor =
                System.Drawing.Color.FromArgb(243, 244, 246);

            estilo_encabezado_roles.SelectionForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            estilo_encabezado_roles.WrapMode =
                System.Windows.Forms.DataGridViewTriState.True;

            this.dgv_roles.ColumnHeadersDefaultCellStyle =
                estilo_encabezado_roles;

            this.dgv_roles.ColumnHeadersHeight = 42;

            this.dgv_roles.ColumnHeadersHeightSizeMode =
                System.Windows.Forms
                .DataGridViewColumnHeadersHeightSizeMode
                .DisableResizing;

            this.dgv_roles.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.col_codigo_rol,
                    this.col_nombre_rol,
                    this.col_total_usuarios,
                    this.col_estado_rol
                });

            estilo_celdas_roles.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            estilo_celdas_roles.BackColor =
                System.Drawing.Color.White;

            estilo_celdas_roles.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            estilo_celdas_roles.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            estilo_celdas_roles.SelectionBackColor =
                System.Drawing.Color.FromArgb(219, 234, 254);

            estilo_celdas_roles.SelectionForeColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            estilo_celdas_roles.WrapMode =
                System.Windows.Forms.DataGridViewTriState.False;

            this.dgv_roles.DefaultCellStyle =
                estilo_celdas_roles;

            this.dgv_roles.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgv_roles.EnableHeadersVisualStyles = false;

            this.dgv_roles.GridColor =
                System.Drawing.Color.FromArgb(226, 232, 240);

            this.dgv_roles.Location =
                new System.Drawing.Point(15, 15);

            this.dgv_roles.MultiSelect = false;

            this.dgv_roles.Name =
                "dgv_roles";

            this.dgv_roles.ReadOnly = true;
            this.dgv_roles.RowHeadersVisible = false;
            this.dgv_roles.RowHeadersWidth = 51;
            this.dgv_roles.RowTemplate.Height = 35;

            this.dgv_roles.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgv_roles.Size =
                new System.Drawing.Size(1040, 267);

            this.dgv_roles.TabIndex = 0;

            // 
            // col_codigo_rol
            // 
            this.col_codigo_rol.FillWeight = 55F;
            this.col_codigo_rol.HeaderText = "Código";
            this.col_codigo_rol.MinimumWidth = 80;
            this.col_codigo_rol.Name = "col_codigo_rol";
            this.col_codigo_rol.ReadOnly = true;

            // 
            // col_nombre_rol
            // 
            this.col_nombre_rol.FillWeight = 130F;
            this.col_nombre_rol.HeaderText = "Nombre del rol";
            this.col_nombre_rol.MinimumWidth = 200;
            this.col_nombre_rol.Name = "col_nombre_rol";
            this.col_nombre_rol.ReadOnly = true;

            // 
            // col_total_usuarios
            // 
            this.col_total_usuarios.FillWeight = 70F;
            this.col_total_usuarios.HeaderText = "Usuarios";
            this.col_total_usuarios.MinimumWidth = 100;
            this.col_total_usuarios.Name = "col_total_usuarios";
            this.col_total_usuarios.ReadOnly = true;

            // 
            // col_estado_rol
            // 
            this.col_estado_rol.FillWeight = 75F;
            this.col_estado_rol.HeaderText = "Estado";
            this.col_estado_rol.MinimumWidth = 110;
            this.col_estado_rol.Name = "col_estado_rol";
            this.col_estado_rol.ReadOnly = true;

            // 
            // pnl_acciones_roles
            // 
            this.pnl_acciones_roles.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_acciones_roles.BackColor =
                System.Drawing.Color.White;

            this.pnl_acciones_roles.Controls.Add(
                this.btn_nuevo_rol);

            this.pnl_acciones_roles.Controls.Add(
                this.btn_editar_rol);

            this.pnl_acciones_roles.Controls.Add(
                this.btn_cambiar_estado_rol);

            this.pnl_acciones_roles.Location =
                new System.Drawing.Point(21, 419);

            this.pnl_acciones_roles.Name =
                "pnl_acciones_roles";

            this.pnl_acciones_roles.Size =
                new System.Drawing.Size(1070, 58);

            this.pnl_acciones_roles.TabIndex = 2;

            // 
            // btn_nuevo_rol
            // 
            this.btn_nuevo_rol.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.btn_nuevo_rol.FlatAppearance.BorderSize = 0;

            this.btn_nuevo_rol.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_nuevo_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btn_nuevo_rol.ForeColor =
                System.Drawing.Color.White;

            this.btn_nuevo_rol.Location =
                new System.Drawing.Point(15, 9);

            this.btn_nuevo_rol.Name =
                "btn_nuevo_rol";

            this.btn_nuevo_rol.Size =
                new System.Drawing.Size(135, 40);

            this.btn_nuevo_rol.TabIndex = 0;

            this.btn_nuevo_rol.Text =
                "Nuevo rol";

            this.btn_nuevo_rol.UseVisualStyleBackColor = false;

            // 
            // btn_editar_rol
            // 
            this.btn_editar_rol.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_editar_rol.FlatAppearance.BorderSize = 0;

            this.btn_editar_rol.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_editar_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btn_editar_rol.ForeColor =
                System.Drawing.Color.White;

            this.btn_editar_rol.Location =
                new System.Drawing.Point(160, 9);

            this.btn_editar_rol.Name =
                "btn_editar_rol";

            this.btn_editar_rol.Size =
                new System.Drawing.Size(135, 40);

            this.btn_editar_rol.TabIndex = 1;

            this.btn_editar_rol.Text =
                "Editar rol";

            this.btn_editar_rol.UseVisualStyleBackColor = false;

            // 
            // btn_cambiar_estado_rol
            // 
            this.btn_cambiar_estado_rol.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_cambiar_estado_rol.FlatAppearance.BorderSize = 0;

            this.btn_cambiar_estado_rol.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_cambiar_estado_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btn_cambiar_estado_rol.ForeColor =
                System.Drawing.Color.White;

            this.btn_cambiar_estado_rol.Location =
                new System.Drawing.Point(305, 9);

            this.btn_cambiar_estado_rol.Name =
                "btn_cambiar_estado_rol";

            this.btn_cambiar_estado_rol.Size =
                new System.Drawing.Size(175, 40);

            this.btn_cambiar_estado_rol.TabIndex = 2;

            this.btn_cambiar_estado_rol.Text =
                "Cambiar estado";

            this.btn_cambiar_estado_rol.UseVisualStyleBackColor = false;

            // 
            // tab_permisos
            // 
            this.tab_permisos.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            this.tab_permisos.Controls.Add(
                this.pnl_seleccion_rol);

            this.tab_permisos.Controls.Add(
                this.pnl_filtro_permisos);

            this.tab_permisos.Controls.Add(
                this.pnl_tabla_permisos);

            this.tab_permisos.Controls.Add(
                this.lbl_advertencia);

            this.tab_permisos.Controls.Add(
                this.pnl_acciones_permisos);

            this.tab_permisos.Location =
                new System.Drawing.Point(4, 36);

            this.tab_permisos.Name =
                "tab_permisos";

            this.tab_permisos.Padding =
                new System.Windows.Forms.Padding(18);

            this.tab_permisos.Size =
                new System.Drawing.Size(1132, 495);

            this.tab_permisos.TabIndex = 1;

            this.tab_permisos.Text =
                "Permisos";

            // 
            // pnl_seleccion_rol
            // 
            this.pnl_seleccion_rol.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_seleccion_rol.BackColor =
                System.Drawing.Color.White;

            this.pnl_seleccion_rol.Controls.Add(
                this.lbl_seleccionar_rol);

            this.pnl_seleccion_rol.Controls.Add(
                this.cbo_seleccionar_rol);

            this.pnl_seleccion_rol.Controls.Add(
                this.lbl_rol_en_configuracion);

            this.pnl_seleccion_rol.Location =
                new System.Drawing.Point(21, 18);

            this.pnl_seleccion_rol.Name =
                "pnl_seleccion_rol";

            this.pnl_seleccion_rol.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_seleccion_rol.Size =
                new System.Drawing.Size(1070, 78);

            this.pnl_seleccion_rol.TabIndex = 0;

            // 
            // lbl_seleccionar_rol
            // 
            this.lbl_seleccionar_rol.AutoSize = true;

            this.lbl_seleccionar_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lbl_seleccionar_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_seleccionar_rol.Location =
                new System.Drawing.Point(15, 10);

            this.lbl_seleccionar_rol.Name =
                "lbl_seleccionar_rol";

            this.lbl_seleccionar_rol.Size =
                new System.Drawing.Size(137, 24);

            this.lbl_seleccionar_rol.TabIndex = 0;

            this.lbl_seleccionar_rol.Text =
                "Seleccione el rol:";

            // 
            // cbo_seleccionar_rol
            // 
            this.cbo_seleccionar_rol.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbo_seleccionar_rol.Font =
                new System.Drawing.Font("Lexend", 10F);

            this.cbo_seleccionar_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.cbo_seleccionar_rol.FormattingEnabled = true;

            this.cbo_seleccionar_rol.Location =
                new System.Drawing.Point(15, 35);

            this.cbo_seleccionar_rol.Name =
                "cbo_seleccionar_rol";

            this.cbo_seleccionar_rol.Size =
                new System.Drawing.Size(330, 35);

            this.cbo_seleccionar_rol.TabIndex = 1;

            // 
            // lbl_rol_en_configuracion
            // 
            this.lbl_rol_en_configuracion.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.lbl_rol_en_configuracion.BackColor =
                System.Drawing.Color.FromArgb(239, 246, 255);

            this.lbl_rol_en_configuracion.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.lbl_rol_en_configuracion.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lbl_rol_en_configuracion.ForeColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.lbl_rol_en_configuracion.Location =
                new System.Drawing.Point(370, 15);

            this.lbl_rol_en_configuracion.Name =
                "lbl_rol_en_configuracion";

            this.lbl_rol_en_configuracion.Padding =
                new System.Windows.Forms.Padding(12, 0, 12, 0);

            this.lbl_rol_en_configuracion.Size =
                new System.Drawing.Size(682, 48);

            this.lbl_rol_en_configuracion.TabIndex = 2;

            this.lbl_rol_en_configuracion.Text =
                "Seleccione un rol para configurar sus permisos.";

            this.lbl_rol_en_configuracion.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnl_filtro_permisos
            // 
            this.pnl_filtro_permisos.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_filtro_permisos.BackColor =
                System.Drawing.Color.White;

            this.pnl_filtro_permisos.Controls.Add(
                this.lbl_categoria);

            this.pnl_filtro_permisos.Controls.Add(
                this.cbo_categoria);

            this.pnl_filtro_permisos.Location =
                new System.Drawing.Point(21, 108);

            this.pnl_filtro_permisos.Name =
                "pnl_filtro_permisos";

            this.pnl_filtro_permisos.Size =
                new System.Drawing.Size(1070, 61);

            this.pnl_filtro_permisos.TabIndex = 1;

            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;

            this.lbl_categoria.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.lbl_categoria.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_categoria.Location =
                new System.Drawing.Point(15, 5);

            this.lbl_categoria.Name =
                "lbl_categoria";

            this.lbl_categoria.Size =
                new System.Drawing.Size(88, 24);

            this.lbl_categoria.TabIndex = 0;

            this.lbl_categoria.Text =
                "Categoría:";

            // 
            // cbo_categoria
            // 
            this.cbo_categoria.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbo_categoria.Font =
                new System.Drawing.Font("Lexend", 10F);

            this.cbo_categoria.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.cbo_categoria.FormattingEnabled = true;

            this.cbo_categoria.Items.AddRange(
                new object[]
                {
                    "Todas",
                    "Operaciones",
                    "Administración",
                    "Consultas y reportes"
                });

            this.cbo_categoria.Location =
                new System.Drawing.Point(15, 27);

            this.cbo_categoria.Name =
                "cbo_categoria";

            this.cbo_categoria.Size =
                new System.Drawing.Size(275, 35);

            this.cbo_categoria.TabIndex = 1;

            this.cbo_categoria.SelectedIndex = 0;

            // 
            // pnl_tabla_permisos
            // 
            this.pnl_tabla_permisos.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom) |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_tabla_permisos.BackColor =
                System.Drawing.Color.White;

            this.pnl_tabla_permisos.Controls.Add(
                this.dgv_permisos);

            this.pnl_tabla_permisos.Location =
                new System.Drawing.Point(21, 181);

            this.pnl_tabla_permisos.Name =
                "pnl_tabla_permisos";

            this.pnl_tabla_permisos.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_tabla_permisos.Size =
                new System.Drawing.Size(1070, 202);

            this.pnl_tabla_permisos.TabIndex = 2;

            // 
            // dgv_permisos
            // 
            this.dgv_permisos.AllowUserToAddRows = false;
            this.dgv_permisos.AllowUserToDeleteRows = false;
            this.dgv_permisos.AllowUserToResizeRows = false;

            this.dgv_permisos.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgv_permisos.BackgroundColor =
                System.Drawing.Color.White;

            this.dgv_permisos.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgv_permisos.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle
                .SingleHorizontal;

            this.dgv_permisos.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            estilo_encabezado_permisos.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            estilo_encabezado_permisos.BackColor =
                System.Drawing.Color.FromArgb(243, 244, 246);

            estilo_encabezado_permisos.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8F,
                    System.Drawing.FontStyle.Bold);

            estilo_encabezado_permisos.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            estilo_encabezado_permisos.SelectionBackColor =
                System.Drawing.Color.FromArgb(243, 244, 246);

            estilo_encabezado_permisos.SelectionForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            estilo_encabezado_permisos.WrapMode =
                System.Windows.Forms.DataGridViewTriState.True;

            this.dgv_permisos.ColumnHeadersDefaultCellStyle =
                estilo_encabezado_permisos;

            this.dgv_permisos.ColumnHeadersHeight = 48;

            this.dgv_permisos.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.col_programa,
                    this.col_acceder,
                    this.col_registrar,
                    this.col_editar,
                    this.col_cambiar_estado,
                    this.col_imprimir,
                    this.col_exportar
                });

            estilo_celdas_permisos.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            estilo_celdas_permisos.BackColor =
                System.Drawing.Color.White;

            estilo_celdas_permisos.Font =
                new System.Drawing.Font("Lexend", 8F);

            estilo_celdas_permisos.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            estilo_celdas_permisos.SelectionBackColor =
                System.Drawing.Color.FromArgb(219, 234, 254);

            estilo_celdas_permisos.SelectionForeColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.dgv_permisos.DefaultCellStyle =
                estilo_celdas_permisos;

            this.dgv_permisos.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgv_permisos.EnableHeadersVisualStyles = false;

            this.dgv_permisos.GridColor =
                System.Drawing.Color.FromArgb(226, 232, 240);

            this.dgv_permisos.Location =
                new System.Drawing.Point(15, 15);

            this.dgv_permisos.MultiSelect = false;

            this.dgv_permisos.Name =
                "dgv_permisos";

            this.dgv_permisos.RowHeadersVisible = false;
            this.dgv_permisos.RowHeadersWidth = 51;
            this.dgv_permisos.RowTemplate.Height = 35;

            this.dgv_permisos.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgv_permisos.Size =
                new System.Drawing.Size(1040, 172);

            this.dgv_permisos.TabIndex = 0;

            // 
            // col_programa
            // 
            this.col_programa.DefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            this.col_programa.FillWeight = 180F;
            this.col_programa.HeaderText = "Programa";
            this.col_programa.MinimumWidth = 260;
            this.col_programa.Name = "col_programa";
            this.col_programa.ReadOnly = true;

            // 
            // col_acceder
            // 
            this.col_acceder.FillWeight = 65F;
            this.col_acceder.HeaderText = "Acceder";
            this.col_acceder.MinimumWidth = 80;
            this.col_acceder.Name = "col_acceder";

            // 
            // col_registrar
            // 
            this.col_registrar.FillWeight = 70F;
            this.col_registrar.HeaderText = "Registrar";
            this.col_registrar.MinimumWidth = 85;
            this.col_registrar.Name = "col_registrar";

            // 
            // col_editar
            // 
            this.col_editar.FillWeight = 60F;
            this.col_editar.HeaderText = "Editar";
            this.col_editar.MinimumWidth = 75;
            this.col_editar.Name = "col_editar";

            // 
            // col_cambiar_estado
            // 
            this.col_cambiar_estado.FillWeight = 90F;
            this.col_cambiar_estado.HeaderText = "Cambiar estado";
            this.col_cambiar_estado.MinimumWidth = 105;
            this.col_cambiar_estado.Name = "col_cambiar_estado";

            // 
            // col_imprimir
            // 
            this.col_imprimir.FillWeight = 65F;
            this.col_imprimir.HeaderText = "Imprimir";
            this.col_imprimir.MinimumWidth = 80;
            this.col_imprimir.Name = "col_imprimir";

            // 
            // col_exportar
            // 
            this.col_exportar.FillWeight = 65F;
            this.col_exportar.HeaderText = "Exportar";
            this.col_exportar.MinimumWidth = 80;
            this.col_exportar.Name = "col_exportar";

            // 
            // lbl_advertencia
            // 
            this.lbl_advertencia.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.lbl_advertencia.BackColor =
                System.Drawing.Color.FromArgb(255, 251, 235);

            this.lbl_advertencia.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.lbl_advertencia.Font =
                new System.Drawing.Font("Lexend", 8F);

            this.lbl_advertencia.ForeColor =
                System.Drawing.Color.FromArgb(180, 83, 9);

            this.lbl_advertencia.Location =
                new System.Drawing.Point(21, 391);

            this.lbl_advertencia.Name =
                "lbl_advertencia";

            this.lbl_advertencia.Padding =
                new System.Windows.Forms.Padding(10, 0, 10, 0);

            this.lbl_advertencia.Size =
                new System.Drawing.Size(1070, 32);

            this.lbl_advertencia.TabIndex = 3;

            this.lbl_advertencia.Text =
                "Los cambios afectarán a todos los usuarios asignados al rol seleccionado.";

            this.lbl_advertencia.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnl_acciones_permisos
            // 
            this.pnl_acciones_permisos.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_acciones_permisos.BackColor =
                System.Drawing.Color.White;

            this.pnl_acciones_permisos.Controls.Add(
                this.btn_marcar_todos);

            this.pnl_acciones_permisos.Controls.Add(
                this.btn_desmarcar_todos);

            this.pnl_acciones_permisos.Controls.Add(
                this.btn_guardar_permisos);

            this.pnl_acciones_permisos.Location =
                new System.Drawing.Point(21, 431);

            this.pnl_acciones_permisos.Name =
                "pnl_acciones_permisos";

            this.pnl_acciones_permisos.Size =
                new System.Drawing.Size(1070, 46);

            this.pnl_acciones_permisos.TabIndex = 4;

            // 
            // btn_marcar_todos
            // 
            this.btn_marcar_todos.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_marcar_todos.FlatAppearance.BorderSize = 0;

            this.btn_marcar_todos.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_marcar_todos.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8F,
                    System.Drawing.FontStyle.Bold);

            this.btn_marcar_todos.ForeColor =
                System.Drawing.Color.White;

            this.btn_marcar_todos.Location =
                new System.Drawing.Point(0, 3);

            this.btn_marcar_todos.Name =
                "btn_marcar_todos";

            this.btn_marcar_todos.Size =
                new System.Drawing.Size(145, 40);

            this.btn_marcar_todos.TabIndex = 0;

            this.btn_marcar_todos.Text =
                "Marcar todos";

            this.btn_marcar_todos.UseVisualStyleBackColor = false;

            // 
            // btn_desmarcar_todos
            // 
            this.btn_desmarcar_todos.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_desmarcar_todos.FlatAppearance.BorderSize = 0;

            this.btn_desmarcar_todos.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_desmarcar_todos.Font =
                new System.Drawing.Font(
                    "Lexend",
                    8F,
                    System.Drawing.FontStyle.Bold);

            this.btn_desmarcar_todos.ForeColor =
                System.Drawing.Color.White;

            this.btn_desmarcar_todos.Location =
                new System.Drawing.Point(155, 3);

            this.btn_desmarcar_todos.Name =
                "btn_desmarcar_todos";

            this.btn_desmarcar_todos.Size =
                new System.Drawing.Size(165, 40);

            this.btn_desmarcar_todos.TabIndex = 1;

            this.btn_desmarcar_todos.Text =
                "Desmarcar todos";

            this.btn_desmarcar_todos.UseVisualStyleBackColor = false;

            // 
            // btn_guardar_permisos
            // 
            this.btn_guardar_permisos.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_guardar_permisos.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.btn_guardar_permisos.FlatAppearance.BorderSize = 0;

            this.btn_guardar_permisos.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_guardar_permisos.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold);

            this.btn_guardar_permisos.ForeColor =
                System.Drawing.Color.White;

            this.btn_guardar_permisos.Location =
                new System.Drawing.Point(877, 3);

            this.btn_guardar_permisos.Name =
                "btn_guardar_permisos";

            this.btn_guardar_permisos.Size =
                new System.Drawing.Size(193, 40);

            this.btn_guardar_permisos.TabIndex = 2;

            this.btn_guardar_permisos.Text =
                "Guardar permisos";

            this.btn_guardar_permisos.UseVisualStyleBackColor = false;

            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_acciones.BackColor =
                System.Drawing.Color.White;

            this.pnl_acciones.Controls.Add(
                this.btn_cerrar);

            this.pnl_acciones.Location =
                new System.Drawing.Point(30, 648);

            this.pnl_acciones.Name =
                "pnl_acciones";

            this.pnl_acciones.Size =
                new System.Drawing.Size(1140, 70);

            this.pnl_acciones.TabIndex = 3;

            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_cerrar.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_cerrar.FlatAppearance.BorderSize = 0;

            this.btn_cerrar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_cerrar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.btn_cerrar.ForeColor =
                System.Drawing.Color.White;

            this.btn_cerrar.Location =
                new System.Drawing.Point(995, 15);

            this.btn_cerrar.Name =
                "btn_cerrar";

            this.btn_cerrar.Size =
                new System.Drawing.Size(125, 40);

            this.btn_cerrar.TabIndex = 0;

            this.btn_cerrar.Text =
                "Cerrar";

            this.btn_cerrar.UseVisualStyleBackColor = false;

            // 
            // modulo_de_roles_y_permisos
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            this.ClientSize =
                new System.Drawing.Size(1200, 740);

            this.Controls.Add(
                this.pnl_acciones);

            this.Controls.Add(
                this.tab_roles_y_permisos);

            this.Controls.Add(
                this.lbl_subtitulo);

            this.Controls.Add(
                this.lbl_titulo);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.Sizable;

            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.MinimumSize =
                new System.Drawing.Size(1080, 720);

            this.Name =
                "modulo_de_roles_y_permisos";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Roles y Permisos - Go Fitness Gym";

            this.tab_roles_y_permisos.ResumeLayout(false);

            this.tab_roles.ResumeLayout(false);

            this.pnl_busqueda_roles.ResumeLayout(false);
            this.pnl_busqueda_roles.PerformLayout();

            this.pnl_tabla_roles.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgv_roles)).EndInit();

            this.pnl_acciones_roles.ResumeLayout(false);

            this.tab_permisos.ResumeLayout(false);

            this.pnl_seleccion_rol.ResumeLayout(false);
            this.pnl_seleccion_rol.PerformLayout();

            this.pnl_filtro_permisos.ResumeLayout(false);
            this.pnl_filtro_permisos.PerformLayout();

            this.pnl_tabla_permisos.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgv_permisos)).EndInit();

            this.pnl_acciones_permisos.ResumeLayout(false);
            this.pnl_acciones.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;

        private System.Windows.Forms.TabControl
            tab_roles_y_permisos;

        private System.Windows.Forms.TabPage tab_roles;
        private System.Windows.Forms.TabPage tab_permisos;

        private System.Windows.Forms.Panel
            pnl_busqueda_roles;

        private System.Windows.Forms.Label
            lbl_buscar_rol;

        private System.Windows.Forms.TextBox
            txt_buscar_rol;

        private System.Windows.Forms.Button
            btn_buscar_rol;

        private System.Windows.Forms.Button
            btn_limpiar_roles;

        private System.Windows.Forms.Panel
            pnl_tabla_roles;

        private System.Windows.Forms.DataGridView
            dgv_roles;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_codigo_rol;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_nombre_rol;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_total_usuarios;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_estado_rol;

        private System.Windows.Forms.Panel
            pnl_acciones_roles;

        private System.Windows.Forms.Button
            btn_nuevo_rol;

        private System.Windows.Forms.Button
            btn_editar_rol;

        private System.Windows.Forms.Button
            btn_cambiar_estado_rol;

        private System.Windows.Forms.Panel
            pnl_seleccion_rol;

        private System.Windows.Forms.Label
            lbl_seleccionar_rol;

        private System.Windows.Forms.ComboBox
            cbo_seleccionar_rol;

        private System.Windows.Forms.Label
            lbl_rol_en_configuracion;

        private System.Windows.Forms.Panel
            pnl_filtro_permisos;

        private System.Windows.Forms.Label
            lbl_categoria;

        private System.Windows.Forms.ComboBox
            cbo_categoria;

        private System.Windows.Forms.Panel
            pnl_tabla_permisos;

        private System.Windows.Forms.DataGridView
            dgv_permisos;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_programa;

        private System.Windows.Forms.DataGridViewCheckBoxColumn
            col_acceder;

        private System.Windows.Forms.DataGridViewCheckBoxColumn
            col_registrar;

        private System.Windows.Forms.DataGridViewCheckBoxColumn
            col_editar;

        private System.Windows.Forms.DataGridViewCheckBoxColumn
            col_cambiar_estado;

        private System.Windows.Forms.DataGridViewCheckBoxColumn
            col_imprimir;

        private System.Windows.Forms.DataGridViewCheckBoxColumn
            col_exportar;

        private System.Windows.Forms.Label
            lbl_advertencia;

        private System.Windows.Forms.Panel
            pnl_acciones_permisos;

        private System.Windows.Forms.Button
            btn_marcar_todos;

        private System.Windows.Forms.Button
            btn_desmarcar_todos;

        private System.Windows.Forms.Button
            btn_guardar_permisos;

        private System.Windows.Forms.Panel
            pnl_acciones;

        private System.Windows.Forms.Button
            btn_cerrar;
    }
}