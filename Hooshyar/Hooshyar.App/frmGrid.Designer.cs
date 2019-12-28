namespace Hooshyar.App
{
	partial class frmGrid
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			this.grdItems = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CountTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Count = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
			this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// grdItems
			// 
			this.grdItems.Dock = System.Windows.Forms.DockStyle.Bottom;
			gridLevelNode1.RelationName = "Level1";
			this.grdItems.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.grdItems.Location = new System.Drawing.Point(0, 83);
			this.grdItems.MainView = this.gridView1;
			this.grdItems.Name = "grdItems";
			this.grdItems.Size = new System.Drawing.Size(643, 296);
			this.grdItems.TabIndex = 1;
			this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Name,
            this.CountTypeId,
            this.Count});
			this.gridView1.GridControl = this.grdItems;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// Name
			// 
			this.Name.AppearanceCell.Options.UseTextOptions = true;
			this.Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.Name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.Name.AppearanceHeader.Options.UseTextOptions = true;
			this.Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.Name.Caption = "نام";
			this.Name.FieldName = "Name";
			this.Name.Name = "Name";
			this.Name.OptionsColumn.AllowEdit = false;
			this.Name.Visible = true;
			this.Name.VisibleIndex = 2;
			// 
			// CountTypeId
			// 
			this.CountTypeId.AppearanceCell.Options.UseTextOptions = true;
			this.CountTypeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.CountTypeId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.CountTypeId.AppearanceHeader.Options.UseTextOptions = true;
			this.CountTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.CountTypeId.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.CountTypeId.Caption = "واحد";
			this.CountTypeId.FieldName = "CountType.Name";
			this.CountTypeId.Name = "CountTypeId";
			this.CountTypeId.OptionsColumn.AllowEdit = false;
			this.CountTypeId.Visible = true;
			this.CountTypeId.VisibleIndex = 0;
			// 
			// Count
			// 
			this.Count.AppearanceCell.Options.UseTextOptions = true;
			this.Count.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.Count.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.Count.AppearanceHeader.Options.UseTextOptions = true;
			this.Count.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.Count.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.Count.Caption = "تعداد";
			this.Count.FieldName = "Count";
			this.Count.Name = "Count";
			this.Count.OptionsColumn.AllowEdit = false;
			this.Count.Visible = true;
			this.Count.VisibleIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.ImageOptions.ImageUri.Uri = "Add";
			this.btnAdd.Location = new System.Drawing.Point(504, 22);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(127, 40);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "محصول جدید";
			// 
			// btnExcel
			// 
			this.btnExcel.ImageOptions.ImageUri.Uri = "ExportToXLSX";
			this.btnExcel.Location = new System.Drawing.Point(12, 22);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(128, 40);
			this.btnExcel.TabIndex = 3;
			this.btnExcel.Text = "خروجی اکسل";
			// 
			// frmGrid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 379);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.grdItems);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			//this.Name = "frmGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "هوشیار";
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraGrid.GridControl grdItems;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton btnAdd;
		private DevExpress.XtraEditors.SimpleButton btnExcel;
		private DevExpress.XtraGrid.Columns.GridColumn Name;
		private DevExpress.XtraGrid.Columns.GridColumn Count;
		private DevExpress.XtraGrid.Columns.GridColumn CountTypeId;
	}
}

