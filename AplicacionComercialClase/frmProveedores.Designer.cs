namespace AplicacionComercialClase
{
    partial class frmProveedores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDProveedorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            System.Windows.Forms.Label iDTipoDocumentoLabel;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombresContactoLabel;
            System.Windows.Forms.Label apellidosContactoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label telefono1Label;
            System.Windows.Forms.Label telefono2Label;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label nombreLabel;
            this.dSAplicacionComercial = new AplicacionComercialClase.DSAplicacionComercial();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new AplicacionComercialClase.DSAplicacionComercialTableAdapters.ProveedorTableAdapter();
            this.tableAdapterManager = new AplicacionComercialClase.DSAplicacionComercialTableAdapters.TableAdapterManager();
            this.proveedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.proveedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.proveedorDataGridView = new System.Windows.Forms.DataGridView();
            this.iDProveedorTextBox = new System.Windows.Forms.TextBox();
            this.iDTipoDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.nombresContactoTextBox = new System.Windows.Forms.TextBox();
            this.apellidosContactoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.telefono1TextBox = new System.Windows.Forms.TextBox();
            this.telefono2TextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDocumentoTableAdapter = new AplicacionComercialClase.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter();
            iDProveedorLabel = new System.Windows.Forms.Label();
            iDTipoDocumentoLabel = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombresContactoLabel = new System.Windows.Forms.Label();
            apellidosContactoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            telefono1Label = new System.Windows.Forms.Label();
            telefono2Label = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingNavigator)).BeginInit();
            this.proveedorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDProveedorLabel
            // 
            iDProveedorLabel.AutoSize = true;
            iDProveedorLabel.Location = new System.Drawing.Point(48, 59);
            iDProveedorLabel.Name = "iDProveedorLabel";
            iDProveedorLabel.Size = new System.Drawing.Size(91, 17);
            iDProveedorLabel.TabIndex = 1;
            iDProveedorLabel.Text = "IDProveedor:";
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarraTableAdapter = null;
            this.tableAdapterManager.BodegaProductoTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraDetalleTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.ConceptoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.DevolucionClienteDetalleTableAdapter = null;
            this.tableAdapterManager.DevolucionClienteTableAdapter = null;
            this.tableAdapterManager.DevolucionProveedorDetalleTableAdapter = null;
            this.tableAdapterManager.DevolucionProveedorTableAdapter = null;
            this.tableAdapterManager.InventarioDetalleTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.KardexTableAdapter = null;
            this.tableAdapterManager.MedidaTableAdapter = null;
            this.tableAdapterManager.MembershipsTableAdapter = null;
            this.tableAdapterManager.PermisoRolTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProfilesTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SalidaDetalleTableAdapter = null;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.TrasladoDetalleTableAdapter = null;
            this.tableAdapterManager.TrasladoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacionComercialClase.DSAplicacionComercialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersInRolesTableAdapter = null;
            this.tableAdapterManager.UsersOpenAuthAccountsTableAdapter = null;
            this.tableAdapterManager.UsersOpenAuthDataTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VentaDetalleTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // proveedorBindingNavigator
            // 
            this.proveedorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proveedorBindingNavigator.BindingSource = this.proveedorBindingSource;
            this.proveedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proveedorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proveedorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.proveedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.proveedorBindingNavigatorSaveItem});
            this.proveedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proveedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proveedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proveedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proveedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proveedorBindingNavigator.Name = "proveedorBindingNavigator";
            this.proveedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proveedorBindingNavigator.Size = new System.Drawing.Size(828, 27);
            this.proveedorBindingNavigator.TabIndex = 0;
            this.proveedorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // proveedorBindingNavigatorSaveItem
            // 
            this.proveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proveedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedorBindingNavigatorSaveItem.Image")));
            this.proveedorBindingNavigatorSaveItem.Name = "proveedorBindingNavigatorSaveItem";
            this.proveedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.proveedorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.proveedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.proveedorBindingNavigatorSaveItem_Click);
            // 
            // proveedorDataGridView
            // 
            this.proveedorDataGridView.AllowUserToAddRows = false;
            this.proveedorDataGridView.AllowUserToDeleteRows = false;
            this.proveedorDataGridView.AllowUserToOrderColumns = true;
            this.proveedorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proveedorDataGridView.AutoGenerateColumns = false;
            this.proveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.proveedorDataGridView.DataSource = this.proveedorBindingSource;
            this.proveedorDataGridView.Location = new System.Drawing.Point(0, 354);
            this.proveedorDataGridView.Name = "proveedorDataGridView";
            this.proveedorDataGridView.ReadOnly = true;
            this.proveedorDataGridView.RowTemplate.Height = 24;
            this.proveedorDataGridView.Size = new System.Drawing.Size(797, 220);
            this.proveedorDataGridView.TabIndex = 23;
            // 
            // iDProveedorTextBox
            // 
            this.iDProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "IDProveedor", true));
            this.iDProveedorTextBox.Location = new System.Drawing.Point(145, 56);
            this.iDProveedorTextBox.Name = "iDProveedorTextBox";
            this.iDProveedorTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDProveedorTextBox.TabIndex = 2;
            // 
            // iDTipoDocumentoLabel
            // 
            iDTipoDocumentoLabel.AutoSize = true;
            iDTipoDocumentoLabel.Location = new System.Drawing.Point(292, 59);
            iDTipoDocumentoLabel.Name = "iDTipoDocumentoLabel";
            iDTipoDocumentoLabel.Size = new System.Drawing.Size(116, 17);
            iDTipoDocumentoLabel.TabIndex = 3;
            iDTipoDocumentoLabel.Text = "Tipo Documento:";
            // 
            // iDTipoDocumentoComboBox
            // 
            this.iDTipoDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proveedorBindingSource, "IDTipoDocumento", true));
            this.iDTipoDocumentoComboBox.DataSource = this.tipoDocumentoBindingSource;
            this.iDTipoDocumentoComboBox.DisplayMember = "Descripcion";
            this.iDTipoDocumentoComboBox.FormattingEnabled = true;
            this.iDTipoDocumentoComboBox.Location = new System.Drawing.Point(414, 56);
            this.iDTipoDocumentoComboBox.Name = "iDTipoDocumentoComboBox";
            this.iDTipoDocumentoComboBox.Size = new System.Drawing.Size(85, 24);
            this.iDTipoDocumentoComboBox.TabIndex = 4;
            this.iDTipoDocumentoComboBox.ValueMember = "IDTipoDocumento";
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new System.Drawing.Point(547, 62);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(84, 17);
            documentoLabel.TabIndex = 5;
            documentoLabel.Text = "Documento:";
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Documento", true));
            this.documentoTextBox.Location = new System.Drawing.Point(637, 59);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(160, 22);
            this.documentoTextBox.TabIndex = 6;
            // 
            // nombresContactoLabel
            // 
            nombresContactoLabel.AutoSize = true;
            nombresContactoLabel.Location = new System.Drawing.Point(70, 103);
            nombresContactoLabel.Name = "nombresContactoLabel";
            nombresContactoLabel.Size = new System.Drawing.Size(69, 17);
            nombresContactoLabel.TabIndex = 7;
            nombresContactoLabel.Text = "Nombres:";
            // 
            // nombresContactoTextBox
            // 
            this.nombresContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "NombresContacto", true));
            this.nombresContactoTextBox.Location = new System.Drawing.Point(145, 100);
            this.nombresContactoTextBox.Name = "nombresContactoTextBox";
            this.nombresContactoTextBox.Size = new System.Drawing.Size(247, 22);
            this.nombresContactoTextBox.TabIndex = 8;
            // 
            // apellidosContactoLabel
            // 
            apellidosContactoLabel.AutoSize = true;
            apellidosContactoLabel.Location = new System.Drawing.Point(475, 103);
            apellidosContactoLabel.Name = "apellidosContactoLabel";
            apellidosContactoLabel.Size = new System.Drawing.Size(69, 17);
            apellidosContactoLabel.TabIndex = 9;
            apellidosContactoLabel.Text = "Apellidos:";
            // 
            // apellidosContactoTextBox
            // 
            this.apellidosContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "ApellidosContacto", true));
            this.apellidosContactoTextBox.Location = new System.Drawing.Point(550, 100);
            this.apellidosContactoTextBox.Name = "apellidosContactoTextBox";
            this.apellidosContactoTextBox.Size = new System.Drawing.Size(247, 22);
            this.apellidosContactoTextBox.TabIndex = 10;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(68, 177);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(71, 17);
            direccionLabel.TabIndex = 13;
            direccionLabel.Text = "Dirección:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(145, 174);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(354, 22);
            this.direccionTextBox.TabIndex = 14;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(84, 211);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(55, 17);
            correoLabel.TabIndex = 15;
            correoLabel.Text = "Correo:";
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(145, 208);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(354, 22);
            this.correoTextBox.TabIndex = 16;
            // 
            // telefono1Label
            // 
            telefono1Label.AutoSize = true;
            telefono1Label.Location = new System.Drawing.Point(560, 175);
            telefono1Label.Name = "telefono1Label";
            telefono1Label.Size = new System.Drawing.Size(76, 17);
            telefono1Label.TabIndex = 17;
            telefono1Label.Text = "Teléfono1:";
            // 
            // telefono1TextBox
            // 
            this.telefono1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Telefono1", true));
            this.telefono1TextBox.Location = new System.Drawing.Point(642, 172);
            this.telefono1TextBox.Name = "telefono1TextBox";
            this.telefono1TextBox.Size = new System.Drawing.Size(155, 22);
            this.telefono1TextBox.TabIndex = 18;
            // 
            // telefono2Label
            // 
            telefono2Label.AutoSize = true;
            telefono2Label.Location = new System.Drawing.Point(560, 209);
            telefono2Label.Name = "telefono2Label";
            telefono2Label.Size = new System.Drawing.Size(76, 17);
            telefono2Label.TabIndex = 19;
            telefono2Label.Text = "Teléfono2:";
            // 
            // telefono2TextBox
            // 
            this.telefono2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Telefono2", true));
            this.telefono2TextBox.Location = new System.Drawing.Point(642, 206);
            this.telefono2TextBox.Name = "telefono2TextBox";
            this.telefono2TextBox.Size = new System.Drawing.Size(155, 22);
            this.telefono2TextBox.TabIndex = 20;
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(90, 247);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(49, 17);
            notasLabel.TabIndex = 21;
            notasLabel.Text = "Notas:";
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(145, 242);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(652, 93);
            this.notasTextBox.TabIndex = 22;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(61, 140);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(78, 17);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Proveedor:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(145, 137);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(652, 22);
            this.nombreTextBox.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Proveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDTipoDocumento";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID TipoDocumento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Documento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombresContacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombres Contacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ApellidosContacto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Apellidos Contacto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono1";
            this.dataGridViewTextBoxColumn8.HeaderText = "Teléfono1";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Telefono2";
            this.dataGridViewTextBoxColumn9.HeaderText = "Teléfono2";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn11.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSAplicacionComercial;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 577);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(telefono2Label);
            this.Controls.Add(this.telefono2TextBox);
            this.Controls.Add(telefono1Label);
            this.Controls.Add(this.telefono1TextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(apellidosContactoLabel);
            this.Controls.Add(this.apellidosContactoTextBox);
            this.Controls.Add(nombresContactoLabel);
            this.Controls.Add(this.nombresContactoTextBox);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(iDTipoDocumentoLabel);
            this.Controls.Add(this.iDTipoDocumentoComboBox);
            this.Controls.Add(iDProveedorLabel);
            this.Controls.Add(this.iDProveedorTextBox);
            this.Controls.Add(this.proveedorDataGridView);
            this.Controls.Add(this.proveedorBindingNavigator);
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingNavigator)).EndInit();
            this.proveedorBindingNavigator.ResumeLayout(false);
            this.proveedorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DSAplicacionComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private DSAplicacionComercialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proveedorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton proveedorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView proveedorDataGridView;
        private System.Windows.Forms.TextBox iDProveedorTextBox;
        private System.Windows.Forms.ComboBox iDTipoDocumentoComboBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox nombresContactoTextBox;
        private System.Windows.Forms.TextBox apellidosContactoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox telefono1TextBox;
        private System.Windows.Forms.TextBox telefono2TextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
    }
}