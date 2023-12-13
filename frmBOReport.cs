using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POScreen.DAL;
using DevExpress.XtraEditors;
using System.Globalization;

namespace POScreen
{
    public partial class frmBOReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmBOReport()
        {
            InitializeComponent();
        }

        private void frmBOReport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            bindWarehouse();
            filldata();
        }
        private void filldata()
        {
            List<vw_FetchCusSorMaster> listvw_FetchCusSorMaster;
            using (var context = new SysproCompanyTEntities())
            {
                if (startdate.Year != 1 && enddate.Year != 1)
                {
                    listvw_FetchCusSorMaster = context.vw_FetchCusSorMaster.Where(c => c.ProdDate >= startdate && c.ProdDate <= enddate).ToList();
                    if (warehouse != "All")
                    {
                        listvw_FetchCusSorMaster = listvw_FetchCusSorMaster.Where(c => c.Warehouse == warehouse).ToList();
                        //vwFetchCusSorMasterBindingSource.DataSource = result1;
                    }
                    vwFetchCusSorMasterBindingSource.DataSource = listvw_FetchCusSorMaster;
                }
            }
        }
        private void bindWarehouse()
        {
            using (var context = new SysproCompanyTEntities())
            {
                if (startdate.Year != 1 && enddate.Year != 1)
                {
                    repWarehouse.Items.Clear();
                    var result = context.vw_FetchCusSorMaster.Where(c => c.ProdDate >= startdate && c.ProdDate <= enddate).Select(c => c.Warehouse).Distinct().ToList();
                    repWarehouse.Items.Add("All");


                    foreach (var item in result)
                    {
                        repWarehouse.Items.Add(item);
                    }
                }
                else
                {
                    var fromdate = DateTime.Now.AddMonths(-1);
                    var toDate = DateTime.Now;
                    repWarehouse.Items.Clear();
                    var result = context.vw_FetchCusSorMaster.Where(c => c.ProdDate >= fromdate && c.ProdDate <= toDate).Select(c => c.Warehouse).Distinct().ToList();
                    repWarehouse.Items.Add("All");


                    foreach (var item in result)
                    {
                        repWarehouse.Items.Add(item);
                    }
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(folderBrowserDialog.SelectedPath + "/ProductionOrder.xlsx");
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            filldata();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        string warehouse = "All";
        DateTime startdate ;
        DateTime enddate ;
        private void repWarehouse_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit rep = (ComboBoxEdit)sender;
            warehouse = rep.EditValue.ToString();
            filldata();
        }

        private void repStart_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            if (rep.EditValue != null)
                startdate = (DateTime)rep.EditValue;
            filldata();
        }

        private void repEnd_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            enddate = (DateTime)rep.EditValue;
            filldata();
        }
    }
}