namespace WindowsFormsApp1
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.btAddDivision = new System.Windows.Forms.Button();
            this.btChangeDivision = new System.Windows.Forms.Button();
            this.btRemoveDivision = new System.Windows.Forms.Button();
            this.btAddWorker = new System.Windows.Forms.Button();
            this.btChangeWorker = new System.Windows.Forms.Button();
            this.btRemoveWorker = new System.Windows.Forms.Button();
            this.dataWorkTestDataSet = new WindowsFormsApp1.DataWorkTestDataSet();
            this.divisionSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.divisionSetTableAdapter = new WindowsFormsApp1.DataWorkTestDataSetTableAdapters.DivisionSetTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DataWorkTestDataSetTableAdapters.TableAdapterManager();
            this.divisionSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.divisionSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.divisionSetGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.workerSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerSetTableAdapter = new WindowsFormsApp1.DataWorkTestDataSetTableAdapters.WorkerSetTableAdapter();
            this.workerSetGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetBindingNavigator)).BeginInit();
            this.divisionSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddDivision
            // 
            this.btAddDivision.Location = new System.Drawing.Point(39, 474);
            this.btAddDivision.Name = "btAddDivision";
            this.btAddDivision.Size = new System.Drawing.Size(75, 23);
            this.btAddDivision.TabIndex = 0;
            this.btAddDivision.Text = "Добавить";
            this.btAddDivision.UseVisualStyleBackColor = true;
            this.btAddDivision.Click += new System.EventHandler(this.btAddDivision_Click);
            // 
            // btChangeDivision
            // 
            this.btChangeDivision.Location = new System.Drawing.Point(150, 474);
            this.btChangeDivision.Name = "btChangeDivision";
            this.btChangeDivision.Size = new System.Drawing.Size(95, 23);
            this.btChangeDivision.TabIndex = 1;
            this.btChangeDivision.Text = "Редактировать";
            this.btChangeDivision.UseVisualStyleBackColor = true;
            this.btChangeDivision.Click += new System.EventHandler(this.btChangeDivision_Click);
            // 
            // btRemoveDivision
            // 
            this.btRemoveDivision.Location = new System.Drawing.Point(291, 474);
            this.btRemoveDivision.Name = "btRemoveDivision";
            this.btRemoveDivision.Size = new System.Drawing.Size(75, 23);
            this.btRemoveDivision.TabIndex = 2;
            this.btRemoveDivision.Text = "Удалить";
            this.btRemoveDivision.UseVisualStyleBackColor = true;
            this.btRemoveDivision.Click += new System.EventHandler(this.btRemoveDivision_Click);
            // 
            // btAddWorker
            // 
            this.btAddWorker.Location = new System.Drawing.Point(752, 474);
            this.btAddWorker.Name = "btAddWorker";
            this.btAddWorker.Size = new System.Drawing.Size(75, 23);
            this.btAddWorker.TabIndex = 3;
            this.btAddWorker.Text = "Добавить";
            this.btAddWorker.UseVisualStyleBackColor = true;
            this.btAddWorker.Click += new System.EventHandler(this.btAddWorker_Click);
            // 
            // btChangeWorker
            // 
            this.btChangeWorker.Location = new System.Drawing.Point(1074, 474);
            this.btChangeWorker.Name = "btChangeWorker";
            this.btChangeWorker.Size = new System.Drawing.Size(110, 23);
            this.btChangeWorker.TabIndex = 4;
            this.btChangeWorker.Text = "Редактировать";
            this.btChangeWorker.UseVisualStyleBackColor = true;
            this.btChangeWorker.Click += new System.EventHandler(this.btChangeWorker_Click);
            // 
            // btRemoveWorker
            // 
            this.btRemoveWorker.Location = new System.Drawing.Point(1204, 474);
            this.btRemoveWorker.Name = "btRemoveWorker";
            this.btRemoveWorker.Size = new System.Drawing.Size(75, 23);
            this.btRemoveWorker.TabIndex = 5;
            this.btRemoveWorker.Text = "Удалить";
            this.btRemoveWorker.UseVisualStyleBackColor = true;
            this.btRemoveWorker.Click += new System.EventHandler(this.btRemoveWorker_Click);
            // 
            // dataWorkTestDataSet
            // 
            this.dataWorkTestDataSet.DataSetName = "DataWorkTestDataSet";
            this.dataWorkTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // divisionSetBindingSource
            // 
            this.divisionSetBindingSource.DataMember = "DivisionSet";
            this.divisionSetBindingSource.DataSource = this.dataWorkTestDataSet;
            // 
            // divisionSetTableAdapter
            // 
            this.divisionSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DivisionSetTableAdapter = this.divisionSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DataWorkTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerSetTableAdapter = null;
            // 
            // divisionSetBindingNavigator
            // 
            this.divisionSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.divisionSetBindingNavigator.BindingSource = this.divisionSetBindingSource;
            this.divisionSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.divisionSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.divisionSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.divisionSetBindingNavigatorSaveItem});
            this.divisionSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.divisionSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.divisionSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.divisionSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.divisionSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.divisionSetBindingNavigator.Name = "divisionSetBindingNavigator";
            this.divisionSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.divisionSetBindingNavigator.Size = new System.Drawing.Size(1334, 25);
            this.divisionSetBindingNavigator.TabIndex = 6;
            this.divisionSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // divisionSetBindingNavigatorSaveItem
            // 
            this.divisionSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.divisionSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("divisionSetBindingNavigatorSaveItem.Image")));
            this.divisionSetBindingNavigatorSaveItem.Name = "divisionSetBindingNavigatorSaveItem";
            this.divisionSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.divisionSetBindingNavigatorSaveItem.Text = "Save Data";
            this.divisionSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.divisionSetBindingNavigatorSaveItem_Click);
            // 
            // divisionSetGridControl
            // 
            this.divisionSetGridControl.DataSource = this.divisionSetBindingSource;
            this.divisionSetGridControl.Location = new System.Drawing.Point(39, 52);
            this.divisionSetGridControl.MainView = this.gridView1;
            this.divisionSetGridControl.Name = "divisionSetGridControl";
            this.divisionSetGridControl.Size = new System.Drawing.Size(404, 359);
            this.divisionSetGridControl.TabIndex = 7;
            this.divisionSetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.divisionSetGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // workerSetBindingSource
            // 
            this.workerSetBindingSource.DataMember = "WorkerSet";
            this.workerSetBindingSource.DataSource = this.dataWorkTestDataSet;
            // 
            // workerSetTableAdapter
            // 
            this.workerSetTableAdapter.ClearBeforeFill = true;
            // 
            // workerSetGridControl
            // 
            this.workerSetGridControl.DataSource = this.workerSetBindingSource;
            this.workerSetGridControl.Location = new System.Drawing.Point(752, 42);
            this.workerSetGridControl.MainView = this.gridView2;
            this.workerSetGridControl.Name = "workerSetGridControl";
            this.workerSetGridControl.Size = new System.Drawing.Size(527, 394);
            this.workerSetGridControl.TabIndex = 8;
            this.workerSetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.workerSetGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workerSetGridControl);
            this.Controls.Add(this.divisionSetGridControl);
            this.Controls.Add(this.divisionSetBindingNavigator);
            this.Controls.Add(this.btRemoveWorker);
            this.Controls.Add(this.btChangeWorker);
            this.Controls.Add(this.btAddWorker);
            this.Controls.Add(this.btRemoveDivision);
            this.Controls.Add(this.btChangeDivision);
            this.Controls.Add(this.btAddDivision);
            this.Name = "fmMain";
            this.Text = "fmMain";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataWorkTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetBindingNavigator)).EndInit();
            this.divisionSetBindingNavigator.ResumeLayout(false);
            this.divisionSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divisionSetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerSetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddDivision;
        private System.Windows.Forms.Button btChangeDivision;
        private System.Windows.Forms.Button btRemoveDivision;
        private System.Windows.Forms.Button btAddWorker;
        private System.Windows.Forms.Button btChangeWorker;
        private System.Windows.Forms.Button btRemoveWorker;
        private DataWorkTestDataSet dataWorkTestDataSet;
        private System.Windows.Forms.BindingSource divisionSetBindingSource;
        private DataWorkTestDataSetTableAdapters.DivisionSetTableAdapter divisionSetTableAdapter;
        private DataWorkTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator divisionSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton divisionSetBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl divisionSetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource workerSetBindingSource;
        private DataWorkTestDataSetTableAdapters.WorkerSetTableAdapter workerSetTableAdapter;
        private DevExpress.XtraGrid.GridControl workerSetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
    }
}

