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
	public partial class frmGrid : Form
	{
		private IUnitOfWork _unitOfWork;
		private IItemService _itemService;
		public frmGrid()
		{
			InitializeComponent();
			InitializeEvents();			
		}

		private void InitializeEvents()
		{
			btnAdd.Click += BtnAddClick;
			this.Load +=FrmGridLoad;
		}

		private void BtnAddClick(object sender, EventArgs e)
		{
			var frmAdd=new frmAdd();
			
			frmAdd.ShowDialog();

		}

		private void FrmGridLoad(object sender, EventArgs e)
		{
			_unitOfWork = SmObjectFactory.Container.GetInstance<IUnitOfWork>();
			_itemService = SmObjectFactory.Container.GetInstance<IItemService>();
			BindGrid();
		}

		private void BindGrid()
		{
			var items = _itemService.GetAll();
			grdItems.DataSource = items;
		}
	}
}
