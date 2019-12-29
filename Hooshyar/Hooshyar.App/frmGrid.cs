using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevExpress.SpreadsheetSource;
using Hooshyar.Data;
using Hooshyar.IocConfig;
using Hooshyar.Model;
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
			btnExcel.Click += BtnExcelClick;
			this.Load += FrmGridLoad;
		}

		private void BtnExcelClick(object sender, EventArgs e)
		{
			try
			{
				ExportToExcel();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
			
		}

		private void ExportToExcel()
		{
			Microsoft.Office.Interop.Excel.Application excelApplication =
				new Microsoft.Office.Interop.Excel.Application();
			if (excelApplication == null)
			{
				throw new Exception("اکسل روی این سیستم نصب نمی باشد");
			}
			Microsoft.Office.Interop.Excel.Workbook excelWorkbook;
			Microsoft.Office.Interop.Excel.Worksheet excelWorksheet;
			object misValue = System.Reflection.Missing.Value;

			excelWorkbook = excelApplication.Workbooks.Add(misValue);
			excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelApplication.Worksheets.Item[1];

			excelWorksheet.Cells[1, 1] = "نام";
			excelWorksheet.Cells[1, 2] = "تعداد";
			excelWorksheet.Cells[1, 3] = "واحد";

			var items = (List<Item>)grdItems.DataSource;

			if (items == null || items.Count < 1)
			{
				return;
			}

			var i = 2;
			foreach (var item in items)
			{
				excelWorksheet.Cells[i, 1] = item.Name;
				excelWorksheet.Cells[i, 2] = item.Count;
				excelWorksheet.Cells[i, 3] = item.CountType.Name;
				i++;
			}

			excelWorkbook.Close(true, misValue, misValue);
			excelApplication.Quit();

			Marshal.ReleaseComObject(excelWorksheet);
			Marshal.ReleaseComObject(excelWorkbook);
			Marshal.ReleaseComObject(excelApplication);


		}

		private void BtnAddClick(object sender, EventArgs e)
		{
			var frmAdd = new frmAdd();
			frmAdd.FormClosed += FrmAdd_FormClosed;
			frmAdd.ShowDialog();

		}

		private void FrmAdd_FormClosed(object sender, FormClosedEventArgs e)
		{
			BindGrid();
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
