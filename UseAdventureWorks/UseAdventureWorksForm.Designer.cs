namespace UseAdventureWorks
{
    partial class UseAdventureWorksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseAdventureWorksForm));
            this.label1 = new System.Windows.Forms.Label();
            this.adventureWorks2016CTP3DataSet = new UseAdventureWorks.AdventureWorks2016CTP3DataSet();
            this.countryRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionTableAdapter = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter();
            this.tableAdapterManager = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager();
            this.countryRegionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.countryRegionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.countryRegionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMuntEenheid = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingNavigator)).BeginInit();
            this.countryRegionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Munteenheid";
            // 
            // adventureWorks2016CTP3DataSet
            // 
            this.adventureWorks2016CTP3DataSet.DataSetName = "AdventureWorks2016CTP3DataSet";
            this.adventureWorks2016CTP3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryRegionBindingSource
            // 
            this.countryRegionBindingSource.DataMember = "CountryRegion";
            this.countryRegionBindingSource.DataSource = this.adventureWorks2016CTP3DataSet;
            // 
            // countryRegionTableAdapter
            // 
            this.countryRegionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryRegionCurrencyTableAdapter = null;
            this.tableAdapterManager.CountryRegionTableAdapter = this.countryRegionTableAdapter;
            this.tableAdapterManager.CurrencyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // countryRegionBindingNavigator
            // 
            this.countryRegionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.countryRegionBindingNavigator.BindingSource = this.countryRegionBindingSource;
            this.countryRegionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.countryRegionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.countryRegionBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.countryRegionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.countryRegionBindingNavigatorSaveItem});
            this.countryRegionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.countryRegionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.countryRegionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.countryRegionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.countryRegionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.countryRegionBindingNavigator.Name = "countryRegionBindingNavigator";
            this.countryRegionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.countryRegionBindingNavigator.Size = new System.Drawing.Size(1012, 42);
            this.countryRegionBindingNavigator.TabIndex = 2;
            this.countryRegionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // countryRegionBindingNavigatorSaveItem
            // 
            this.countryRegionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryRegionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countryRegionBindingNavigatorSaveItem.Image")));
            this.countryRegionBindingNavigatorSaveItem.Name = "countryRegionBindingNavigatorSaveItem";
            this.countryRegionBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.countryRegionBindingNavigatorSaveItem.Text = "Save Data";
            this.countryRegionBindingNavigatorSaveItem.Click += new System.EventHandler(this.countryRegionBindingNavigatorSaveItem_Click_2);
            // 
            // countryRegionDataGridView
            // 
            this.countryRegionDataGridView.AllowUserToAddRows = false;
            this.countryRegionDataGridView.AllowUserToDeleteRows = false;
            this.countryRegionDataGridView.AutoGenerateColumns = false;
            this.countryRegionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryRegionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.countryRegionDataGridView.DataSource = this.countryRegionBindingSource;
            this.countryRegionDataGridView.Location = new System.Drawing.Point(107, 110);
            this.countryRegionDataGridView.Name = "countryRegionDataGridView";
            this.countryRegionDataGridView.ReadOnly = true;
            this.countryRegionDataGridView.RowHeadersWidth = 82;
            this.countryRegionDataGridView.RowTemplate.Height = 33;
            this.countryRegionDataGridView.Size = new System.Drawing.Size(696, 300);
            this.countryRegionDataGridView.TabIndex = 3;
            this.countryRegionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.countryRegionDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 135;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CountryRegionCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "CountryRegionCode";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Klik op een land om de munteenheid te kennen";
            // 
            // lbMuntEenheid
            // 
            this.lbMuntEenheid.FormattingEnabled = true;
            this.lbMuntEenheid.ItemHeight = 25;
            this.lbMuntEenheid.Location = new System.Drawing.Point(112, 474);
            this.lbMuntEenheid.Name = "lbMuntEenheid";
            this.lbMuntEenheid.Size = new System.Drawing.Size(289, 79);
            this.lbMuntEenheid.TabIndex = 5;
            // 
            // UseAdventureWorksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 659);
            this.Controls.Add(this.lbMuntEenheid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryRegionDataGridView);
            this.Controls.Add(this.countryRegionBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "UseAdventureWorksForm";
            this.Text = "UseAdventureWorks";
            this.Load += new System.EventHandler(this.UseAdventureWorks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingNavigator)).EndInit();
            this.countryRegionBindingNavigator.ResumeLayout(false);
            this.countryRegionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        //        private UseAdventureWorksForm.AdventureWorks2016CTP3DataSet adventureWorks2016CTP3DataSet;
        private UseAdventureWorks.AdventureWorks2016CTP3DataSet adventureWorks2016CTP3DataSet;

        private System.Windows.Forms.BindingSource countryRegionBindingSource;
        //        private UseAdventureWorksForm.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter countryRegionTableAdapter;
        private UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter countryRegionTableAdapter;

        //        private UseAdventureWorksForm.AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager tableAdapterManager;

        private System.Windows.Forms.BindingNavigator countryRegionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton countryRegionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView countryRegionDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ListBox lbMuntEenheid;
    }
}

