using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using Hooshyar.Data;
using Hooshyar.IocConfig;
using Hooshyar.Model;
using Hooshyar.Service.Interface;

namespace Hooshyar.App
{
	public partial class frmAdd : Form
	{
		private IUnitOfWork _unitOfWork;
		private IItemService _itemService;
		private ICountTypeService _countTypeService;
		public frmAdd()
		{
			InitializeComponent();
			InitializeEvents();
		}

		private void InitializeEvents()
		{
			this.Load += FrmAddLoad;
			btnSave.Click += BtnSaveClick;
			btnCancel.Click += BtnCancelClick;
		}

		private void FrmAddLoad(object sender, EventArgs e)
		{
			_unitOfWork = SmObjectFactory.Container.GetInstance<IUnitOfWork>();
			_itemService = SmObjectFactory.Container.GetInstance<IItemService>();
			_countTypeService = SmObjectFactory.Container.GetInstance<ICountTypeService>();
			BindCmbCountType();
		}

		private void BindCmbCountType()
		{
			var countTypes = _countTypeService.GetTypes();

			cmbCountType.DisplayMember = "Name";
			cmbCountType.ValueMember = "Id";

			cmbCountType.DataSource = countTypes;
		}

		private void BtnCancelClick(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnSaveClick(object sender, EventArgs e)
		{
			SaveItem();
			Close();
		}

		private void SaveItem()
		{
			try
			{
				var item = new Item(txtName.Text, numCount.Value, int.Parse(cmbCountType.SelectedValue.ToString()));
				_itemService.AddItem(item);
				_unitOfWork.SaveChanges();
			}
			catch (Exception e)
			{
				MessageBox.Show("عملیات با مشکل مواجه شد");
			}
			
		}
	}
}
