namespace Firma {
  partial class Form1 {
    /// <summary>
    /// Wymagana zmienna projektanta.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Wyczyść wszystkie używane zasoby.
    /// </summary>
    /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
        }
      base.Dispose(disposing);
      }

    #region Kod generowany przez Projektanta formularzy systemu Windows

    /// <summary>
    /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
    /// jej zawartości w edytorze kodu.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      this.klienciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.firmaDataSet = new Firma.FirmaDataSet();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.klienciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.klienciDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnUsun = new System.Windows.Forms.Button();
      this.txtSzukaj = new System.Windows.Forms.TextBox();
      this.btnSzukaj = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.pracownicyDataGridView = new System.Windows.Forms.DataGridView();
      this.idPracownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.stanowiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pensjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.klienciTableAdapter = new Firma.FirmaDataSetTableAdapters.KlienciTableAdapter();
      this.tableAdapterManager = new Firma.FirmaDataSetTableAdapters.TableAdapterManager();
      this.pracownicyTableAdapter = new Firma.FirmaDataSetTableAdapters.PracownicyTableAdapter();
      this.kontrahenciDataGridView = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.kontrahenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.firmaDataSet1 = new Firma.FirmaDataSet1();
      this.kontrahenciTableAdapter = new Firma.FirmaDataSet1TableAdapters.KontrahenciTableAdapter();
      this.fakturyBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.fakturySprzedazyTableAdapter = new Firma.FirmaDataSetTableAdapters.FakturySprzedazyTableAdapter();
      this.fakturyDataGridView = new System.Windows.Forms.DataGridView();
      this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.numerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.zaplaconoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.kontrahentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pracownikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnNiezaplacone = new System.Windows.Forms.Button();
      this.btnFakturyDostawcy = new System.Windows.Forms.Button();
      this.btnWszystkieFaktury = new System.Windows.Forms.Button();
      this.labelKlienci = new System.Windows.Forms.Label();
      this.labelPracownicy = new System.Windows.Forms.Label();
      this.labelKontrahenci = new System.Windows.Forms.Label();
      this.labelFaktury = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).BeginInit();
      this.klienciBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.klienciDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pracownicyDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.kontrahenciDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fakturyBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.fakturyDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // klienciBindingNavigator
      // 
      this.klienciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.klienciBindingNavigator.BindingSource = this.klienciBindingSource;
      this.klienciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.klienciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.klienciBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.klienciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.klienciBindingNavigatorSaveItem});
      this.klienciBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.klienciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.klienciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.klienciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.klienciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.klienciBindingNavigator.Name = "klienciBindingNavigator";
      this.klienciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.klienciBindingNavigator.Size = new System.Drawing.Size(1182, 31);
      this.klienciBindingNavigator.TabIndex = 0;
      this.klienciBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
      this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
      // 
      // klienciBindingSource
      // 
      this.klienciBindingSource.DataMember = "Klienci";
      this.klienciBindingSource.DataSource = this.firmaDataSet;
      // 
      // firmaDataSet
      // 
      this.firmaDataSet.DataSetName = "FirmaDataSet";
      this.firmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
      this.bindingNavigatorCountItem.Text = "z {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
      this.bindingNavigatorDeleteItem.Text = "Usuń";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
      this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
      this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
      this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
      this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
      // 
      // klienciBindingNavigatorSaveItem
      // 
      this.klienciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.klienciBindingNavigatorSaveItem.Name = "klienciBindingNavigatorSaveItem";
      this.klienciBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
      this.klienciBindingNavigatorSaveItem.Text = "Zapisz dane";
      this.klienciBindingNavigatorSaveItem.Click += new System.EventHandler(this.klienciBindingNavigatorSaveItem_Click);
      // 
      // klienciDataGridView
      // 
      this.klienciDataGridView.AllowUserToDeleteRows = false;
      this.klienciDataGridView.AllowUserToResizeColumns = false;
      this.klienciDataGridView.AllowUserToResizeRows = false;
      this.klienciDataGridView.AutoGenerateColumns = false;
      this.klienciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.klienciDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.klienciDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
      this.klienciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.klienciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.klienciDataGridView.DataSource = this.klienciBindingSource;
      this.klienciDataGridView.EnableHeadersVisualStyles = false;
      this.klienciDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
      this.klienciDataGridView.Location = new System.Drawing.Point(0, 61);
      this.klienciDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.klienciDataGridView.MultiSelect = false;
      this.klienciDataGridView.Name = "klienciDataGridView";
      this.klienciDataGridView.RowHeadersVisible = false;
      this.klienciDataGridView.RowHeadersWidth = 51;
      this.klienciDataGridView.RowTemplate.Height = 24;
      this.klienciDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.klienciDataGridView.Size = new System.Drawing.Size(1182, 110);
      this.klienciDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "IdKlienta";
      this.dataGridViewTextBoxColumn1.HeaderText = "IdKlienta";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Visible = false;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Imie";
      this.dataGridViewTextBoxColumn2.HeaderText = "Imie";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Nazwisko";
      this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "Miasto";
      this.dataGridViewTextBoxColumn4.HeaderText = "Miasto";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon";
      this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
      this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // btnUsun
      // 
      this.btnUsun.BackColor = System.Drawing.SystemColors.Window;
      this.btnUsun.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnUsun.ForeColor = System.Drawing.SystemColors.WindowText;
      this.btnUsun.Location = new System.Drawing.Point(567, 695);
      this.btnUsun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnUsun.Name = "btnUsun";
      this.btnUsun.Size = new System.Drawing.Size(90, 45);
      this.btnUsun.TabIndex = 2;
      this.btnUsun.Text = "Usuń";
      this.btnUsun.UseMnemonic = false;
      this.btnUsun.UseVisualStyleBackColor = false;
      this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
      // 
      // txtSzukaj
      // 
      this.txtSzukaj.BackColor = System.Drawing.SystemColors.Window;
      this.txtSzukaj.Cursor = System.Windows.Forms.Cursors.Hand;
      this.txtSzukaj.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtSzukaj.Location = new System.Drawing.Point(667, 695);
      this.txtSzukaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtSzukaj.Name = "txtSzukaj";
      this.txtSzukaj.Size = new System.Drawing.Size(130, 27);
      this.txtSzukaj.TabIndex = 3;
      this.txtSzukaj.TextChanged += new System.EventHandler(this.txtSzukaj_TextChanged);
      // 
      // btnSzukaj
      // 
      this.btnSzukaj.BackColor = System.Drawing.SystemColors.Window;
      this.btnSzukaj.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSzukaj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnSzukaj.ForeColor = System.Drawing.SystemColors.WindowText;
      this.btnSzukaj.Location = new System.Drawing.Point(807, 695);
      this.btnSzukaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnSzukaj.Name = "btnSzukaj";
      this.btnSzukaj.Size = new System.Drawing.Size(90, 45);
      this.btnSzukaj.TabIndex = 4;
      this.btnSzukaj.Text = "Szukaj";
      this.btnSzukaj.UseMnemonic = false;
      this.btnSzukaj.UseVisualStyleBackColor = false;
      this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
      this.btnSzukaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSzukaj_KeyDown);
      // 
      // btnReset
      // 
      this.btnReset.BackColor = System.Drawing.SystemColors.Window;
      this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnReset.ForeColor = System.Drawing.SystemColors.WindowText;
      this.btnReset.Location = new System.Drawing.Point(907, 695);
      this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(90, 45);
      this.btnReset.TabIndex = 5;
      this.btnReset.Text = "Wyczyść filtr";
      this.btnReset.UseMnemonic = false;
      this.btnReset.UseVisualStyleBackColor = false;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // pracownicyDataGridView
      // 
      this.pracownicyDataGridView.AllowUserToDeleteRows = false;
      this.pracownicyDataGridView.AllowUserToResizeColumns = false;
      this.pracownicyDataGridView.AllowUserToResizeRows = false;
      this.pracownicyDataGridView.AutoGenerateColumns = false;
      this.pracownicyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.pracownicyDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.pracownicyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.pracownicyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.pracownicyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPracownikaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.stanowiskoDataGridViewTextBoxColumn,
            this.pensjaDataGridViewTextBoxColumn});
      this.pracownicyDataGridView.DataSource = this.pracownicyBindingSource;
      this.pracownicyDataGridView.EnableHeadersVisualStyles = false;
      this.pracownicyDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
      this.pracownicyDataGridView.Location = new System.Drawing.Point(0, 202);
      this.pracownicyDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pracownicyDataGridView.MultiSelect = false;
      this.pracownicyDataGridView.Name = "pracownicyDataGridView";
      this.pracownicyDataGridView.RowHeadersVisible = false;
      this.pracownicyDataGridView.RowHeadersWidth = 51;
      this.pracownicyDataGridView.RowTemplate.Height = 24;
      this.pracownicyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.pracownicyDataGridView.Size = new System.Drawing.Size(1182, 93);
      this.pracownicyDataGridView.TabIndex = 6;
      // 
      // idPracownikaDataGridViewTextBoxColumn
      // 
      this.idPracownikaDataGridViewTextBoxColumn.DataPropertyName = "IdPracownika";
      this.idPracownikaDataGridViewTextBoxColumn.HeaderText = "IdPracownika";
      this.idPracownikaDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.idPracownikaDataGridViewTextBoxColumn.Name = "idPracownikaDataGridViewTextBoxColumn";
      this.idPracownikaDataGridViewTextBoxColumn.ReadOnly = true;
      this.idPracownikaDataGridViewTextBoxColumn.Visible = false;
      // 
      // imieDataGridViewTextBoxColumn
      // 
      this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
      this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
      this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
      // 
      // nazwiskoDataGridViewTextBoxColumn
      // 
      this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
      this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
      this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
      // 
      // stanowiskoDataGridViewTextBoxColumn
      // 
      this.stanowiskoDataGridViewTextBoxColumn.DataPropertyName = "Stanowisko";
      this.stanowiskoDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
      this.stanowiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.stanowiskoDataGridViewTextBoxColumn.Name = "stanowiskoDataGridViewTextBoxColumn";
      // 
      // pensjaDataGridViewTextBoxColumn
      // 
      this.pensjaDataGridViewTextBoxColumn.DataPropertyName = "Pensja";
      this.pensjaDataGridViewTextBoxColumn.HeaderText = "Pensja";
      this.pensjaDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.pensjaDataGridViewTextBoxColumn.Name = "pensjaDataGridViewTextBoxColumn";
      // 
      // pracownicyBindingSource
      // 
      this.pracownicyBindingSource.DataMember = "Pracownicy";
      this.pracownicyBindingSource.DataSource = this.firmaDataSet;
      // 
      // klienciTableAdapter
      // 
      this.klienciTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.FakturySprzedazyTableAdapter = null;
      this.tableAdapterManager.KlienciTableAdapter = this.klienciTableAdapter;
      this.tableAdapterManager.KontrahenciTableAdapter = null;
      this.tableAdapterManager.PracownicyTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = Firma.FirmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // pracownicyTableAdapter
      // 
      this.pracownicyTableAdapter.ClearBeforeFill = true;
      // 
      // kontrahenciDataGridView
      // 
      this.kontrahenciDataGridView.AllowUserToDeleteRows = false;
      this.kontrahenciDataGridView.AllowUserToResizeColumns = false;
      this.kontrahenciDataGridView.AllowUserToResizeRows = false;
      this.kontrahenciDataGridView.AutoGenerateColumns = false;
      this.kontrahenciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.kontrahenciDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.kontrahenciDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
      this.kontrahenciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.kontrahenciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.nipDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn});
      this.kontrahenciDataGridView.DataSource = this.kontrahenciBindingSource;
      this.kontrahenciDataGridView.EnableHeadersVisualStyles = false;
      this.kontrahenciDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
      this.kontrahenciDataGridView.Location = new System.Drawing.Point(0, 326);
      this.kontrahenciDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.kontrahenciDataGridView.MultiSelect = false;
      this.kontrahenciDataGridView.Name = "kontrahenciDataGridView";
      this.kontrahenciDataGridView.RowHeadersVisible = false;
      this.kontrahenciDataGridView.RowHeadersWidth = 51;
      this.kontrahenciDataGridView.RowTemplate.Height = 24;
      this.kontrahenciDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.kontrahenciDataGridView.Size = new System.Drawing.Size(1182, 112);
      this.kontrahenciDataGridView.TabIndex = 7;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      this.idDataGridViewTextBoxColumn.Visible = false;
      // 
      // nazwaDataGridViewTextBoxColumn
      // 
      this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
      this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
      this.nazwaDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
      // 
      // nipDataGridViewTextBoxColumn
      // 
      this.nipDataGridViewTextBoxColumn.DataPropertyName = "Nip";
      this.nipDataGridViewTextBoxColumn.HeaderText = "Nip";
      this.nipDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.nipDataGridViewTextBoxColumn.Name = "nipDataGridViewTextBoxColumn";
      // 
      // ulicaDataGridViewTextBoxColumn
      // 
      this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
      this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
      this.ulicaDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
      // 
      // miastoDataGridViewTextBoxColumn
      // 
      this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
      this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
      this.miastoDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
      // 
      // kontrahenciBindingSource
      // 
      this.kontrahenciBindingSource.DataMember = "Kontrahenci";
      this.kontrahenciBindingSource.DataSource = this.firmaDataSet1;
      // 
      // firmaDataSet1
      // 
      this.firmaDataSet1.DataSetName = "FirmaDataSet1";
      this.firmaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // kontrahenciTableAdapter
      // 
      this.kontrahenciTableAdapter.ClearBeforeFill = true;
      // 
      // fakturyBindingSource
      // 
      this.fakturyBindingSource.DataMember = "FakturySprzedazy";
      this.fakturyBindingSource.DataSource = this.firmaDataSet;
      // 
      // fakturySprzedazyTableAdapter
      // 
      this.fakturySprzedazyTableAdapter.ClearBeforeFill = true;
      // 
      // fakturyDataGridView
      // 
      this.fakturyDataGridView.AllowUserToDeleteRows = false;
      this.fakturyDataGridView.AllowUserToResizeColumns = false;
      this.fakturyDataGridView.AllowUserToResizeRows = false;
      this.fakturyDataGridView.AutoGenerateColumns = false;
      this.fakturyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.fakturyDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.fakturyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
      this.fakturyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.fakturyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.numerDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.zaplaconoDataGridViewTextBoxColumn,
            this.kontrahentIdDataGridViewTextBoxColumn,
            this.pracownikIdDataGridViewTextBoxColumn});
      this.fakturyDataGridView.DataSource = this.fakturyBindingSource;
      this.fakturyDataGridView.EnableHeadersVisualStyles = false;
      this.fakturyDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
      this.fakturyDataGridView.Location = new System.Drawing.Point(0, 469);
      this.fakturyDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.fakturyDataGridView.MultiSelect = false;
      this.fakturyDataGridView.Name = "fakturyDataGridView";
      this.fakturyDataGridView.RowHeadersVisible = false;
      this.fakturyDataGridView.RowHeadersWidth = 51;
      this.fakturyDataGridView.RowTemplate.Height = 24;
      this.fakturyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.fakturyDataGridView.Size = new System.Drawing.Size(1182, 174);
      this.fakturyDataGridView.TabIndex = 8;
      // 
      // idDataGridViewTextBoxColumn1
      // 
      this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
      this.idDataGridViewTextBoxColumn1.ReadOnly = true;
      this.idDataGridViewTextBoxColumn1.Visible = false;
      // 
      // numerDataGridViewTextBoxColumn
      // 
      this.numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
      this.numerDataGridViewTextBoxColumn.HeaderText = "Numer";
      this.numerDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
      // 
      // nettoDataGridViewTextBoxColumn
      // 
      this.nettoDataGridViewTextBoxColumn.DataPropertyName = "Netto";
      this.nettoDataGridViewTextBoxColumn.HeaderText = "Netto";
      this.nettoDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.nettoDataGridViewTextBoxColumn.Name = "nettoDataGridViewTextBoxColumn";
      // 
      // vatDataGridViewTextBoxColumn
      // 
      this.vatDataGridViewTextBoxColumn.DataPropertyName = "Vat";
      this.vatDataGridViewTextBoxColumn.HeaderText = "Vat";
      this.vatDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.vatDataGridViewTextBoxColumn.Name = "vatDataGridViewTextBoxColumn";
      // 
      // dataDataGridViewTextBoxColumn
      // 
      this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
      this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
      this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
      // 
      // zaplaconoDataGridViewTextBoxColumn
      // 
      this.zaplaconoDataGridViewTextBoxColumn.DataPropertyName = "Zaplacono";
      this.zaplaconoDataGridViewTextBoxColumn.HeaderText = "Zaplacono";
      this.zaplaconoDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.zaplaconoDataGridViewTextBoxColumn.Name = "zaplaconoDataGridViewTextBoxColumn";
      // 
      // kontrahentIdDataGridViewTextBoxColumn
      // 
      this.kontrahentIdDataGridViewTextBoxColumn.DataPropertyName = "KontrahentId";
      this.kontrahentIdDataGridViewTextBoxColumn.HeaderText = "KontrahentId";
      this.kontrahentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.kontrahentIdDataGridViewTextBoxColumn.Name = "kontrahentIdDataGridViewTextBoxColumn";
      // 
      // pracownikIdDataGridViewTextBoxColumn
      // 
      this.pracownikIdDataGridViewTextBoxColumn.DataPropertyName = "PracownikId";
      this.pracownikIdDataGridViewTextBoxColumn.HeaderText = "PracownikId";
      this.pracownikIdDataGridViewTextBoxColumn.MinimumWidth = 6;
      this.pracownikIdDataGridViewTextBoxColumn.Name = "pracownikIdDataGridViewTextBoxColumn";
      // 
      // btnNiezaplacone
      // 
      this.btnNiezaplacone.BackColor = System.Drawing.SystemColors.Window;
      this.btnNiezaplacone.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnNiezaplacone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnNiezaplacone.ForeColor = System.Drawing.SystemColors.WindowText;
      this.btnNiezaplacone.Location = new System.Drawing.Point(12, 695);
      this.btnNiezaplacone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnNiezaplacone.Name = "btnNiezaplacone";
      this.btnNiezaplacone.Padding = new System.Windows.Forms.Padding(1);
      this.btnNiezaplacone.Size = new System.Drawing.Size(160, 45);
      this.btnNiezaplacone.TabIndex = 9;
      this.btnNiezaplacone.Text = "Nieuregulowane";
      this.btnNiezaplacone.UseMnemonic = false;
      this.btnNiezaplacone.UseVisualStyleBackColor = false;
      // 
      // btnFakturyDostawcy
      // 
      this.btnFakturyDostawcy.BackColor = System.Drawing.SystemColors.Window;
      this.btnFakturyDostawcy.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnFakturyDostawcy.ForeColor = System.Drawing.SystemColors.WindowText;
      this.btnFakturyDostawcy.Location = new System.Drawing.Point(184, 695);
      this.btnFakturyDostawcy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnFakturyDostawcy.Name = "btnFakturyDostawcy";
      this.btnFakturyDostawcy.Size = new System.Drawing.Size(160, 45);
      this.btnFakturyDostawcy.TabIndex = 10;
      this.btnFakturyDostawcy.Text = "Faktury dostawcy";
      this.btnFakturyDostawcy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnFakturyDostawcy.UseMnemonic = false;
      this.btnFakturyDostawcy.UseVisualStyleBackColor = false;
      // 
      // btnWszystkieFaktury
      // 
      this.btnWszystkieFaktury.BackColor = System.Drawing.SystemColors.Window;
      this.btnWszystkieFaktury.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnWszystkieFaktury.ForeColor = System.Drawing.SystemColors.WindowText;
      this.btnWszystkieFaktury.Location = new System.Drawing.Point(356, 695);
      this.btnWszystkieFaktury.Margin = new System.Windows.Forms.Padding(3, 4, 35, 4);
      this.btnWszystkieFaktury.Name = "btnWszystkieFaktury";
      this.btnWszystkieFaktury.Size = new System.Drawing.Size(160, 45);
      this.btnWszystkieFaktury.TabIndex = 11;
      this.btnWszystkieFaktury.Text = "Wszystkie faktury";
      this.btnWszystkieFaktury.UseMnemonic = false;
      this.btnWszystkieFaktury.UseVisualStyleBackColor = false;
      // 
      // labelKlienci
      // 
      this.labelKlienci.AutoSize = true;
      this.labelKlienci.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.labelKlienci.Location = new System.Drawing.Point(55, 34);
      this.labelKlienci.Name = "labelKlienci";
      this.labelKlienci.Size = new System.Drawing.Size(59, 23);
      this.labelKlienci.TabIndex = 12;
      this.labelKlienci.Text = "Klienci";
      // 
      // labelPracownicy
      // 
      this.labelPracownicy.AutoSize = true;
      this.labelPracownicy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.labelPracownicy.Location = new System.Drawing.Point(34, 175);
      this.labelPracownicy.Name = "labelPracownicy";
      this.labelPracownicy.Size = new System.Drawing.Size(100, 23);
      this.labelPracownicy.TabIndex = 13;
      this.labelPracownicy.Text = "Pracownicy";
      // 
      // labelKontrahenci
      // 
      this.labelKontrahenci.AutoSize = true;
      this.labelKontrahenci.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.labelKontrahenci.Location = new System.Drawing.Point(28, 299);
      this.labelKontrahenci.Name = "labelKontrahenci";
      this.labelKontrahenci.Size = new System.Drawing.Size(106, 23);
      this.labelKontrahenci.TabIndex = 14;
      this.labelKontrahenci.Text = "Kontrahenci";
      // 
      // labelFaktury
      // 
      this.labelFaktury.AutoSize = true;
      this.labelFaktury.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.labelFaktury.Location = new System.Drawing.Point(34, 442);
      this.labelFaktury.Name = "labelFaktury";
      this.labelFaktury.Size = new System.Drawing.Size(71, 23);
      this.labelFaktury.TabIndex = 15;
      this.labelFaktury.Text = "Faktury";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1182, 753);
      this.Controls.Add(this.labelFaktury);
      this.Controls.Add(this.labelKontrahenci);
      this.Controls.Add(this.labelPracownicy);
      this.Controls.Add(this.klienciDataGridView);
      this.Controls.Add(this.labelKlienci);
      this.Controls.Add(this.btnWszystkieFaktury);
      this.Controls.Add(this.btnFakturyDostawcy);
      this.Controls.Add(this.btnNiezaplacone);
      this.Controls.Add(this.fakturyDataGridView);
      this.Controls.Add(this.kontrahenciDataGridView);
      this.Controls.Add(this.pracownicyDataGridView);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnSzukaj);
      this.Controls.Add(this.txtSzukaj);
      this.Controls.Add(this.btnUsun);
      this.Controls.Add(this.klienciBindingNavigator);
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.MinimumSize = new System.Drawing.Size(900, 600);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Firma - baza klientów";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).EndInit();
      this.klienciBindingNavigator.ResumeLayout(false);
      this.klienciBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.klienciDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pracownicyDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.kontrahenciDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fakturyBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.fakturyDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private FirmaDataSet firmaDataSet;
    private System.Windows.Forms.BindingSource klienciBindingSource;
    private FirmaDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
    private FirmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator klienciBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton klienciBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView klienciDataGridView; 
    private System.Windows.Forms.Button btnUsun;
    private System.Windows.Forms.TextBox txtSzukaj;
    private System.Windows.Forms.Button btnSzukaj;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.DataGridView pracownicyDataGridView;
    private System.Windows.Forms.BindingSource pracownicyBindingSource;
    private FirmaDataSetTableAdapters.PracownicyTableAdapter pracownicyTableAdapter;
    private System.Windows.Forms.DataGridView kontrahenciDataGridView;
    private FirmaDataSet1 firmaDataSet1;
    private System.Windows.Forms.BindingSource kontrahenciBindingSource;
    private FirmaDataSet1TableAdapters.KontrahenciTableAdapter kontrahenciTableAdapter;
    private System.Windows.Forms.BindingSource fakturyBindingSource;
    private FirmaDataSetTableAdapters.FakturySprzedazyTableAdapter fakturySprzedazyTableAdapter;
    private System.Windows.Forms.DataGridView fakturyDataGridView;
    private System.Windows.Forms.Button btnNiezaplacone;
    private System.Windows.Forms.Button btnFakturyDostawcy;
    private System.Windows.Forms.Button btnWszystkieFaktury;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn idPracownikaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn stanowiskoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn pensjaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nipDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn zaplaconoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn pracownikIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.Label labelKlienci;
    private System.Windows.Forms.Label labelPracownicy;
    private System.Windows.Forms.Label labelKontrahenci;
    private System.Windows.Forms.Label labelFaktury;
    }
  }

