using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hooshyar.Data;
using Hooshyar.IocConfig;
using Hooshyar.Service.Interface;

namespace Hooshyar.App
{
	public partial class frmAdd : Form
	{
		private IUnitOfWork _unitOfWork;
		private IItemService _itemService;
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
		}

		private void BtnCancelClick(object sender, EventArgs e)
		{
			
		}

		private void BtnSaveClick(object sender, EventArgs e)
		{
			
		}
	}
}
