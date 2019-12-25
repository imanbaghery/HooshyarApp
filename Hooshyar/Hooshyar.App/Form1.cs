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
	public partial class MainForm : Form
	{
		private IUnitOfWork _unitOfWork;
		private IItemService _itemService;
		public MainForm()
		{
			InitializeComponent();
			InitializeEvents();			
		}

		private void InitializeEvents()
		{
			btnAdd.Click += BtnAdd_Click;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			//var container = SmObjectFactory.Container;
			
			
		}

		private void Form1_Load(object sender, EventArgs e)
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
