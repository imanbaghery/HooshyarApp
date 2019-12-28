namespace Hooshyar.App
{
	partial class frmAdd
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
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.lblName = new DevExpress.XtraEditors.LabelControl();
			this.lblCount = new DevExpress.XtraEditors.LabelControl();
			this.lblCountType = new DevExpress.XtraEditors.LabelControl();
			this.numCount = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.cmbCountType = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(35, 28);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(135, 20);
			this.txtName.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(184, 31);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(50, 13);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "نام محصول";
			// 
			// lblCount
			// 
			this.lblCount.Location = new System.Drawing.Point(184, 66);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(23, 13);
			this.lblCount.TabIndex = 3;
			this.lblCount.Text = "تعداد";
			// 
			// lblCountType
			// 
			this.lblCountType.Location = new System.Drawing.Point(184, 102);
			this.lblCountType.Name = "lblCountType";
			this.lblCountType.Size = new System.Drawing.Size(21, 13);
			this.lblCountType.TabIndex = 3;
			this.lblCountType.Text = "واحد";
			// 
			// numCount
			// 
			this.numCount.Location = new System.Drawing.Point(76, 64);
			this.numCount.Name = "numCount";
			this.numCount.Size = new System.Drawing.Size(94, 20);
			this.numCount.TabIndex = 4;
			// 
			// btnSave
			// 
			this.btnSave.ImageOptions.ImageUri.Uri = "Apply;Colored";
			this.btnSave.Location = new System.Drawing.Point(159, 174);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 41);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "ذخیره";
			// 
			// btnCancel
			// 
			this.btnCancel.ImageOptions.ImageUri.Uri = "Cancel";
			this.btnCancel.Location = new System.Drawing.Point(12, 174);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(95, 41);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "انصراف";
			// 
			// cmbCountType
			// 
			this.cmbCountType.FormattingEnabled = true;
			this.cmbCountType.Location = new System.Drawing.Point(35, 99);
			this.cmbCountType.Name = "cmbCountType";
			this.cmbCountType.Size = new System.Drawing.Size(135, 21);
			this.cmbCountType.TabIndex = 8;
			// 
			// frmAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 227);
			this.Controls.Add(this.cmbCountType);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.numCount);
			this.Controls.Add(this.lblCountType);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "اضافه کردن محصول";
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit txtName;
		private DevExpress.XtraEditors.LabelControl lblName;
		private DevExpress.XtraEditors.LabelControl lblCount;
		private DevExpress.XtraEditors.LabelControl lblCountType;
		private System.Windows.Forms.NumericUpDown numCount;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private DevExpress.XtraEditors.SimpleButton btnCancel;
		private System.Windows.Forms.ComboBox cmbCountType;
	}
}