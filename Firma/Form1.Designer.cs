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
      this.klienciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.firmaDataSet = new Firma.FirmaDataSet();
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
      this.klienciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.klienciDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.klienciTableAdapter = new Firma.FirmaDataSetTableAdapters.KlienciTableAdapter();
      this.tableAdapterManager = new Firma.FirmaDataSetTableAdapters.TableAdapterManager();
      this.btnUsun = new System.Windows.Forms.Button();
      this.txtSzukaj = new System.Windows.Forms.TextBox();
      this.btnSzukaj = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).BeginInit();
      this.klienciBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.klienciDataGridView)).BeginInit();
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
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
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
      this.klienciBindingNavigator.Size = new System.Drawing.Size(800, 31);
      this.klienciBindingNavigator.TabIndex = 0;
      this.klienciBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 28);
      this.bindingNavigatorCountItem.Text = "z {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
      this.bindingNavigatorDeleteItem.Text = "Usuń";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
      this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
      this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
      this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
      this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
      // 
      // klienciBindingNavigatorSaveItem
      // 
      this.klienciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.klienciBindingNavigatorSaveItem.Name = "klienciBindingNavigatorSaveItem";
      this.klienciBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
      this.klienciBindingNavigatorSaveItem.Text = "Zapisz dane";
      // 
      // klienciDataGridView
      // 
      this.klienciDataGridView.AutoGenerateColumns = false;
      this.klienciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.klienciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.klienciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.klienciDataGridView.DataSource = this.klienciBindingSource;
      this.klienciDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
      this.klienciDataGridView.Location = new System.Drawing.Point(0, 31);
      this.klienciDataGridView.Name = "klienciDataGridView";
      this.klienciDataGridView.RowHeadersWidth = 51;
      this.klienciDataGridView.RowTemplate.Height = 24;
      this.klienciDataGridView.Size = new System.Drawing.Size(800, 373);
      this.klienciDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "IdKlienta";
      this.dataGridViewTextBoxColumn1.HeaderText = "IdKlienta";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
      // klienciTableAdapter
      // 
      this.klienciTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.KlienciTableAdapter = this.klienciTableAdapter;
      this.tableAdapterManager.UpdateOrder = Firma.FirmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // btnUsun
      // 
      this.btnUsun.Location = new System.Drawing.Point(43, 335);
      this.btnUsun.Name = "btnUsun";
      this.btnUsun.Size = new System.Drawing.Size(75, 23);
      this.btnUsun.TabIndex = 2;
      this.btnUsun.Text = "Usuń klienta";
      this.btnUsun.UseVisualStyleBackColor = true;
      this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
      // 
      // txtSzukaj
      // 
      this.txtSzukaj.Location = new System.Drawing.Point(319, 335);
      this.txtSzukaj.Name = "txtSzukaj";
      this.txtSzukaj.Size = new System.Drawing.Size(100, 22);
      this.txtSzukaj.TabIndex = 3;
      // 
      // btnSzukaj
      // 
      this.btnSzukaj.Location = new System.Drawing.Point(238, 336);
      this.btnSzukaj.Name = "btnSzukaj";
      this.btnSzukaj.Size = new System.Drawing.Size(75, 23);
      this.btnSzukaj.TabIndex = 4;
      this.btnSzukaj.Text = "Szukaj";
      this.btnSzukaj.UseVisualStyleBackColor = true;
      this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(483, 335);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 23);
      this.btnReset.TabIndex = 5;
      this.btnReset.Text = "Wyczyść filtr";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnSzukaj);
      this.Controls.Add(this.txtSzukaj);
      this.Controls.Add(this.btnUsun);
      this.Controls.Add(this.klienciDataGridView);
      this.Controls.Add(this.klienciBindingNavigator);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).EndInit();
      this.klienciBindingNavigator.ResumeLayout(false);
      this.klienciBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.firmaDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.klienciDataGridView)).EndInit();
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
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.Button btnUsun;
    private System.Windows.Forms.TextBox txtSzukaj;
    private System.Windows.Forms.Button btnSzukaj;
    private System.Windows.Forms.Button btnReset;
    }
  }

