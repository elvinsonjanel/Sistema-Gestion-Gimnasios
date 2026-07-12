namespace GoFitnessGym
{
    partial class modulo_de_usuarios
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_subtitulo = new System.Windows.Forms.Label();

            this.pnl_filtros = new System.Windows.Forms.Panel();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_filtro_rol = new System.Windows.Forms.Label();
            this.cbo_filtro_rol = new System.Windows.Forms.ComboBox();
            this.lbl_filtro_estado = new System.Windows.Forms.Label();
            this.cbo_filtro_estado = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();

            this.pnl_tabla = new System.Windows.Forms.Panel();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();

            this.col_codigo =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_nombre_completo =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_nombre_usuario =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_rol =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_estado =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.col_ultimo_acceso =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.lbl_total_registros =
                new System.Windows.Forms.Label();

            this.pnl_acciones =
                new System.Windows.Forms.Panel();

            this.btn_nuevo_usuario =
                new System.Windows.Forms.Button();

            this.btn_ver_detalle =
                new System.Windows.Forms.Button();

            this.btn_editar =
                new System.Windows.Forms.Button();

            this.btn_cambiar_clave =
                new System.Windows.Forms.Button();

            this.btn_cambiar_estado =
                new System.Windows.Forms.Button();

            this.btn_cerrar =
                new System.Windows.Forms.Button();

            this.pnl_filtros.SuspendLayout();
            this.pnl_tabla.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgv_usuarios)).BeginInit();

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

            this.lbl_titulo.Name = "lbl_titulo";

            this.lbl_titulo.Size =
                new System.Drawing.Size(299, 42);

            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Gestionar Usuarios";

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

            this.lbl_subtitulo.Name = "lbl_subtitulo";

            this.lbl_subtitulo.Size =
                new System.Drawing.Size(575, 27);

            this.lbl_subtitulo.TabIndex = 1;

            this.lbl_subtitulo.Text =
                "Administre las cuentas y los roles de acceso al sistema";

            // 
            // pnl_filtros
            // 
            this.pnl_filtros.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_filtros.BackColor =
                System.Drawing.Color.White;

            this.pnl_filtros.Controls.Add(
                this.lbl_busqueda);

            this.pnl_filtros.Controls.Add(
                this.txt_busqueda);

            this.pnl_filtros.Controls.Add(
                this.lbl_filtro_rol);

            this.pnl_filtros.Controls.Add(
                this.cbo_filtro_rol);

            this.pnl_filtros.Controls.Add(
                this.lbl_filtro_estado);

            this.pnl_filtros.Controls.Add(
                this.cbo_filtro_estado);

            this.pnl_filtros.Controls.Add(
                this.btn_buscar);

            this.pnl_filtros.Controls.Add(
                this.btn_limpiar);

            this.pnl_filtros.Location =
                new System.Drawing.Point(30, 98);

            this.pnl_filtros.Name =
                "pnl_filtros";

            this.pnl_filtros.Padding =
                new System.Windows.Forms.Padding(18);

            this.pnl_filtros.Size =
                new System.Drawing.Size(940, 92);

            this.pnl_filtros.TabIndex = 2;

            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.AutoSize = true;

            this.lbl_busqueda.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_busqueda.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_busqueda.Location =
                new System.Drawing.Point(18, 12);

            this.lbl_busqueda.Name =
                "lbl_busqueda";

            this.lbl_busqueda.Size =
                new System.Drawing.Size(117, 24);

            this.lbl_busqueda.TabIndex = 0;
            this.lbl_busqueda.Text =
                "Buscar usuario:";

            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txt_busqueda.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.txt_busqueda.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.txt_busqueda.Location =
                new System.Drawing.Point(18, 39);

            this.txt_busqueda.Name =
                "txt_busqueda";

            this.txt_busqueda.Size =
                new System.Drawing.Size(270, 28);

            this.txt_busqueda.TabIndex = 1;

            // 
            // lbl_filtro_rol
            // 
            this.lbl_filtro_rol.AutoSize = true;

            this.lbl_filtro_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_filtro_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_filtro_rol.Location =
                new System.Drawing.Point(310, 12);

            this.lbl_filtro_rol.Name =
                "lbl_filtro_rol";

            this.lbl_filtro_rol.Size =
                new System.Drawing.Size(36, 24);

            this.lbl_filtro_rol.TabIndex = 2;
            this.lbl_filtro_rol.Text = "Rol:";

            // 
            // cbo_filtro_rol
            // 
            this.cbo_filtro_rol.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbo_filtro_rol.FlatStyle =
                System.Windows.Forms.FlatStyle.Standard;

            this.cbo_filtro_rol.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.cbo_filtro_rol.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.cbo_filtro_rol.FormattingEnabled = true;

            this.cbo_filtro_rol.Items.AddRange(
                new object[]
                {
                    "Todos",
                    "Administrador",
                    "Recepcionista"
                });

            this.cbo_filtro_rol.Location =
                new System.Drawing.Point(310, 36);

            this.cbo_filtro_rol.Name =
                "cbo_filtro_rol";

            this.cbo_filtro_rol.Size =
                new System.Drawing.Size(175, 35);

            this.cbo_filtro_rol.TabIndex = 3;
            this.cbo_filtro_rol.SelectedIndex = 0;

            // 
            // lbl_filtro_estado
            // 
            this.lbl_filtro_estado.AutoSize = true;

            this.lbl_filtro_estado.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_filtro_estado.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.lbl_filtro_estado.Location =
                new System.Drawing.Point(505, 12);

            this.lbl_filtro_estado.Name =
                "lbl_filtro_estado";

            this.lbl_filtro_estado.Size =
                new System.Drawing.Size(67, 24);

            this.lbl_filtro_estado.TabIndex = 4;
            this.lbl_filtro_estado.Text =
                "Estado:";

            // 
            // cbo_filtro_estado
            // 
            this.cbo_filtro_estado.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cbo_filtro_estado.FlatStyle =
                System.Windows.Forms.FlatStyle.Standard;

            this.cbo_filtro_estado.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.cbo_filtro_estado.ForeColor =
                System.Drawing.Color.FromArgb(45, 55, 72);

            this.cbo_filtro_estado.FormattingEnabled = true;

            this.cbo_filtro_estado.Items.AddRange(
                new object[]
                {
                    "Todos",
                    "Activo",
                    "Inactivo"
                });

            this.cbo_filtro_estado.Location =
                new System.Drawing.Point(505, 36);

            this.cbo_filtro_estado.Name =
                "cbo_filtro_estado";

            this.cbo_filtro_estado.Size =
                new System.Drawing.Size(145, 35);

            this.cbo_filtro_estado.TabIndex = 5;
            this.cbo_filtro_estado.SelectedIndex = 0;

            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_buscar.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.btn_buscar.FlatAppearance.BorderSize = 0;

            this.btn_buscar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_buscar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_buscar.ForeColor =
                System.Drawing.Color.White;

            this.btn_buscar.Location =
                new System.Drawing.Point(686, 31);

            this.btn_buscar.Name =
                "btn_buscar";

            this.btn_buscar.Size =
                new System.Drawing.Size(110, 40);

            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";

            this.btn_buscar.UseVisualStyleBackColor = false;

            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                (System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right));

            this.btn_limpiar.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_limpiar.FlatAppearance.BorderSize = 0;

            this.btn_limpiar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_limpiar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_limpiar.ForeColor =
                System.Drawing.Color.White;

            this.btn_limpiar.Location =
                new System.Drawing.Point(807, 31);

            this.btn_limpiar.Name =
                "btn_limpiar";

            this.btn_limpiar.Size =
                new System.Drawing.Size(110, 40);

            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";

            this.btn_limpiar.UseVisualStyleBackColor = false;

            // 
            // pnl_tabla
            // 
            this.pnl_tabla.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom) |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));

            this.pnl_tabla.BackColor =
                System.Drawing.Color.White;

            this.pnl_tabla.Controls.Add(
                this.dgv_usuarios);

            this.pnl_tabla.Controls.Add(
                this.lbl_total_registros);

            this.pnl_tabla.Location =
                new System.Drawing.Point(30, 202);

            this.pnl_tabla.Name =
                "pnl_tabla";

            this.pnl_tabla.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_tabla.Size =
                new System.Drawing.Size(940, 370);

            this.pnl_tabla.TabIndex = 3;

            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AllowUserToResizeRows = false;

            this.dgv_usuarios.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgv_usuarios.BackgroundColor =
                System.Drawing.Color.White;

            this.dgv_usuarios.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgv_usuarios.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle
                .SingleHorizontal;

            this.dgv_usuarios.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgv_usuarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms
                .DataGridViewColumnHeadersHeightSizeMode
                .AutoSize;

            this.dgv_usuarios.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.col_codigo,
                    this.col_nombre_completo,
                    this.col_nombre_usuario,
                    this.col_rol,
                    this.col_estado,
                    this.col_ultimo_acceso
                });

            this.dgv_usuarios.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgv_usuarios.EnableHeadersVisualStyles = false;

            this.dgv_usuarios.GridColor =
                System.Drawing.Color.FromArgb(226, 232, 240);

            this.dgv_usuarios.Location =
                new System.Drawing.Point(15, 15);

            this.dgv_usuarios.MultiSelect = false;

            this.dgv_usuarios.Name =
                "dgv_usuarios";

            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.RowHeadersWidth = 51;
            this.dgv_usuarios.RowTemplate.Height = 35;

            this.dgv_usuarios.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode
                .FullRowSelect;

            this.dgv_usuarios.Size =
                new System.Drawing.Size(910, 310);

            this.dgv_usuarios.TabIndex = 0;

            // 
            // col_codigo
            // 
            this.col_codigo.FillWeight = 55F;
            this.col_codigo.HeaderText = "Código";
            this.col_codigo.MinimumWidth = 60;
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;

            // 
            // col_nombre_completo
            // 
            this.col_nombre_completo.FillWeight = 135F;

            this.col_nombre_completo.HeaderText =
                "Nombre completo";

            this.col_nombre_completo.MinimumWidth = 150;

            this.col_nombre_completo.Name =
                "col_nombre_completo";

            this.col_nombre_completo.ReadOnly = true;

            // 
            // col_nombre_usuario
            // 
            this.col_nombre_usuario.FillWeight = 90F;
            this.col_nombre_usuario.HeaderText = "Usuario";
            this.col_nombre_usuario.MinimumWidth = 100;

            this.col_nombre_usuario.Name =
                "col_nombre_usuario";

            this.col_nombre_usuario.ReadOnly = true;

            // 
            // col_rol
            // 
            this.col_rol.FillWeight = 85F;
            this.col_rol.HeaderText = "Rol";
            this.col_rol.MinimumWidth = 100;
            this.col_rol.Name = "col_rol";
            this.col_rol.ReadOnly = true;

            // 
            // col_estado
            // 
            this.col_estado.FillWeight = 70F;
            this.col_estado.HeaderText = "Estado";
            this.col_estado.MinimumWidth = 80;
            this.col_estado.Name = "col_estado";
            this.col_estado.ReadOnly = true;

            // 
            // col_ultimo_acceso
            // 
            this.col_ultimo_acceso.FillWeight = 105F;

            this.col_ultimo_acceso.HeaderText =
                "Último acceso";

            this.col_ultimo_acceso.MinimumWidth = 120;

            this.col_ultimo_acceso.Name =
                "col_ultimo_acceso";

            this.col_ultimo_acceso.ReadOnly = true;

            // 
            // lbl_total_registros
            // 
            this.lbl_total_registros.Dock =
                System.Windows.Forms.DockStyle.Bottom;

            this.lbl_total_registros.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lbl_total_registros.ForeColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.lbl_total_registros.Location =
                new System.Drawing.Point(15, 325);

            this.lbl_total_registros.Name =
                "lbl_total_registros";

            this.lbl_total_registros.Size =
                new System.Drawing.Size(910, 30);

            this.lbl_total_registros.TabIndex = 1;

            this.lbl_total_registros.Text =
                "Total de usuarios: 0";

            this.lbl_total_registros.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

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
                this.btn_nuevo_usuario);

            this.pnl_acciones.Controls.Add(
                this.btn_ver_detalle);

            this.pnl_acciones.Controls.Add(
                this.btn_editar);

            this.pnl_acciones.Controls.Add(
                this.btn_cambiar_clave);

            this.pnl_acciones.Controls.Add(
                this.btn_cambiar_estado);

            this.pnl_acciones.Controls.Add(
                this.btn_cerrar);

            this.pnl_acciones.Location =
                new System.Drawing.Point(30, 584);

            this.pnl_acciones.Name =
                "pnl_acciones";

            this.pnl_acciones.Padding =
                new System.Windows.Forms.Padding(15);

            this.pnl_acciones.Size =
                new System.Drawing.Size(940, 70);

            this.pnl_acciones.TabIndex = 4;

            // 
            // btn_nuevo_usuario
            // 
            this.btn_nuevo_usuario.BackColor =
                System.Drawing.Color.FromArgb(30, 58, 139);

            this.btn_nuevo_usuario.FlatAppearance.BorderSize = 0;

            this.btn_nuevo_usuario.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_nuevo_usuario.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_nuevo_usuario.ForeColor =
                System.Drawing.Color.White;

            this.btn_nuevo_usuario.Location =
                new System.Drawing.Point(18, 15);

            this.btn_nuevo_usuario.Name =
                "btn_nuevo_usuario";

            this.btn_nuevo_usuario.Size =
                new System.Drawing.Size(105, 40);

            this.btn_nuevo_usuario.TabIndex = 0;
            this.btn_nuevo_usuario.Text = "Nuevo";

            this.btn_nuevo_usuario.UseVisualStyleBackColor = false;

            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_ver_detalle.FlatAppearance.BorderSize = 0;

            this.btn_ver_detalle.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_ver_detalle.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_ver_detalle.ForeColor =
                System.Drawing.Color.White;

            this.btn_ver_detalle.Location =
                new System.Drawing.Point(133, 15);

            this.btn_ver_detalle.Name =
                "btn_ver_detalle";

            this.btn_ver_detalle.Size =
                new System.Drawing.Size(125, 40);

            this.btn_ver_detalle.TabIndex = 1;
            this.btn_ver_detalle.Text = "Ver detalle";

            this.btn_ver_detalle.UseVisualStyleBackColor = false;

            // 
            // btn_editar
            // 
            this.btn_editar.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_editar.FlatAppearance.BorderSize = 0;

            this.btn_editar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_editar.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_editar.ForeColor =
                System.Drawing.Color.White;

            this.btn_editar.Location =
                new System.Drawing.Point(268, 15);

            this.btn_editar.Name =
                "btn_editar";

            this.btn_editar.Size =
                new System.Drawing.Size(100, 40);

            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";

            this.btn_editar.UseVisualStyleBackColor = false;

            // 
            // btn_cambiar_clave
            // 
            this.btn_cambiar_clave.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_cambiar_clave.FlatAppearance.BorderSize = 0;

            this.btn_cambiar_clave.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_cambiar_clave.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_cambiar_clave.ForeColor =
                System.Drawing.Color.White;

            this.btn_cambiar_clave.Location =
                new System.Drawing.Point(378, 15);

            this.btn_cambiar_clave.Name =
                "btn_cambiar_clave";

            this.btn_cambiar_clave.Size =
                new System.Drawing.Size(135, 40);

            this.btn_cambiar_clave.TabIndex = 3;
            this.btn_cambiar_clave.Text = "Cambiar clave";

            this.btn_cambiar_clave.UseVisualStyleBackColor = false;

            // 
            // btn_cambiar_estado
            // 
            this.btn_cambiar_estado.BackColor =
                System.Drawing.Color.FromArgb(113, 128, 150);

            this.btn_cambiar_estado.FlatAppearance.BorderSize = 0;

            this.btn_cambiar_estado.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btn_cambiar_estado.Font =
                new System.Drawing.Font(
                    "Lexend",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_cambiar_estado.ForeColor =
                System.Drawing.Color.White;

            this.btn_cambiar_estado.Location =
                new System.Drawing.Point(523, 15);

            this.btn_cambiar_estado.Name =
                "btn_cambiar_estado";

            this.btn_cambiar_estado.Size =
                new System.Drawing.Size(155, 40);

            this.btn_cambiar_estado.TabIndex = 4;
            this.btn_cambiar_estado.Text = "Cambiar estado";

            this.btn_cambiar_estado.UseVisualStyleBackColor = false;

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
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.btn_cerrar.ForeColor =
                System.Drawing.Color.White;

            this.btn_cerrar.Location =
                new System.Drawing.Point(795, 15);

            this.btn_cerrar.Name =
                "btn_cerrar";

            this.btn_cerrar.Size =
                new System.Drawing.Size(125, 40);

            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.Text = "Cerrar";

            this.btn_cerrar.UseVisualStyleBackColor = false;

            // 
            // modulo_de_usuarios
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(240, 240, 240);

            this.ClientSize =
                new System.Drawing.Size(1000, 680);

            this.Controls.Add(
                this.pnl_acciones);

            this.Controls.Add(
                this.pnl_tabla);

            this.Controls.Add(
                this.pnl_filtros);

            this.Controls.Add(
                this.lbl_subtitulo);

            this.Controls.Add(
                this.lbl_titulo);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.Sizable;

            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.MinimumSize =
                new System.Drawing.Size(900, 700);

            this.Name =
                "modulo_de_usuarios";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Gestionar Usuarios - Go Fitness Gym";

            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();

            this.pnl_tabla.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgv_usuarios)).EndInit();

            this.pnl_acciones.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label
            lbl_titulo;

        private System.Windows.Forms.Label
            lbl_subtitulo;

        private System.Windows.Forms.Panel
            pnl_filtros;

        private System.Windows.Forms.Label
            lbl_busqueda;

        private System.Windows.Forms.TextBox
            txt_busqueda;

        private System.Windows.Forms.Label
            lbl_filtro_rol;

        private System.Windows.Forms.ComboBox
            cbo_filtro_rol;

        private System.Windows.Forms.Label
            lbl_filtro_estado;

        private System.Windows.Forms.ComboBox
            cbo_filtro_estado;

        private System.Windows.Forms.Button
            btn_buscar;

        private System.Windows.Forms.Button
            btn_limpiar;

        private System.Windows.Forms.Panel
            pnl_tabla;

        private System.Windows.Forms.DataGridView
            dgv_usuarios;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_codigo;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_nombre_completo;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_nombre_usuario;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_rol;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_estado;

        private System.Windows.Forms.DataGridViewTextBoxColumn
            col_ultimo_acceso;

        private System.Windows.Forms.Label
            lbl_total_registros;

        private System.Windows.Forms.Panel
            pnl_acciones;

        private System.Windows.Forms.Button
            btn_nuevo_usuario;

        private System.Windows.Forms.Button
            btn_ver_detalle;

        private System.Windows.Forms.Button
            btn_editar;

        private System.Windows.Forms.Button
            btn_cambiar_clave;

        private System.Windows.Forms.Button
            btn_cambiar_estado;

        private System.Windows.Forms.Button
            btn_cerrar;
    }
}