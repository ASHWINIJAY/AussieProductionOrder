
namespace POScreen
{
    partial class frmBOReport
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repWarehouse = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repStart = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repEnd = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwFetchCusSorMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMStockDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionCompletion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDispatchDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockingUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShippingInstruction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPickedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberOfParcels = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNoItems = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWeightKgs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineShipDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchCusSorMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barEditItem1,
            this.barEditItem2,
            this.barEditItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repWarehouse,
            this.repStart,
            this.repEnd});
            this.ribbon.Size = new System.Drawing.Size(1364, 200);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = global::POScreen.Properties.Resources.refreshallpivottable;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = global::POScreen.Properties.Resources.clearheaderandfooter;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Export To Excel";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = global::POScreen.Properties.Resources.export;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Warehouse";
            this.barEditItem1.Edit = this.repWarehouse;
            this.barEditItem1.EditWidth = 100;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repWarehouse
            // 
            this.repWarehouse.AutoHeight = false;
            this.repWarehouse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repWarehouse.Name = "repWarehouse";
            this.repWarehouse.EditValueChanged += new System.EventHandler(this.repWarehouse_EditValueChanged);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Start  Date ";
            this.barEditItem2.Edit = this.repStart;
            this.barEditItem2.EditWidth = 100;
            this.barEditItem2.Id = 6;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repStart
            // 
            this.repStart.AutoHeight = false;
            this.repStart.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStart.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStart.Name = "repStart";
            this.repStart.EditValueChanged += new System.EventHandler(this.repStart_EditValueChanged);
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "End Date    ";
            this.barEditItem3.Edit = this.repEnd;
            this.barEditItem3.EditWidth = 100;
            this.barEditItem3.Id = 7;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repEnd
            // 
            this.repEnd.AutoHeight = false;
            this.repEnd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnd.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnd.Name = "repEnd";
            this.repEnd.EditValueChanged += new System.EventHandler(this.repEnd_EditValueChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Filters";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 680);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1364, 41);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwFetchCusSorMasterBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 200);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1364, 480);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwFetchCusSorMasterBindingSource
            // 
            this.vwFetchCusSorMasterBindingSource.DataSource = typeof(POScreen.DAL.vw_FetchCusSorMaster);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesOrder,
            this.colMStockCode,
            this.colMStockDes,
            this.colInvoiceNumber,
            this.colProductionCompletion,
            this.colProductionDate,
            this.colDispatchDate,
            this.colWarehouse,
            this.colOrderQty,
            this.colStockingUOM,
            this.colShippingInstruction,
            this.colProductionStatus,
            this.colCourier,
            this.colConNote,
            this.colPickedBy,
            this.colNumberOfParcels,
            this.colTotalNoItems,
            this.colTotalWeightKgs,
            this.colLineShipDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSalesOrder
            // 
            this.colSalesOrder.FieldName = "SalesOrder";
            this.colSalesOrder.MinWidth = 30;
            this.colSalesOrder.Name = "colSalesOrder";
            this.colSalesOrder.Visible = true;
            this.colSalesOrder.VisibleIndex = 0;
            this.colSalesOrder.Width = 112;
            // 
            // colMStockCode
            // 
            this.colMStockCode.FieldName = "MStockCode";
            this.colMStockCode.MinWidth = 30;
            this.colMStockCode.Name = "colMStockCode";
            this.colMStockCode.Visible = true;
            this.colMStockCode.VisibleIndex = 1;
            this.colMStockCode.Width = 112;
            // 
            // colMStockDes
            // 
            this.colMStockDes.FieldName = "MStockDes";
            this.colMStockDes.MinWidth = 30;
            this.colMStockDes.Name = "colMStockDes";
            this.colMStockDes.Visible = true;
            this.colMStockDes.VisibleIndex = 2;
            this.colMStockDes.Width = 112;
            // 
            // colInvoiceNumber
            // 
            this.colInvoiceNumber.FieldName = "InvoiceNumber";
            this.colInvoiceNumber.MinWidth = 30;
            this.colInvoiceNumber.Name = "colInvoiceNumber";
            this.colInvoiceNumber.Visible = true;
            this.colInvoiceNumber.VisibleIndex = 6;
            this.colInvoiceNumber.Width = 112;
            // 
            // colProductionCompletion
            // 
            this.colProductionCompletion.FieldName = "ProductionCompletion";
            this.colProductionCompletion.MinWidth = 30;
            this.colProductionCompletion.Name = "colProductionCompletion";
            this.colProductionCompletion.Visible = true;
            this.colProductionCompletion.VisibleIndex = 7;
            this.colProductionCompletion.Width = 112;
            // 
            // colProductionDate
            // 
            this.colProductionDate.FieldName = "ProductionDate";
            this.colProductionDate.MinWidth = 30;
            this.colProductionDate.Name = "colProductionDate";
            this.colProductionDate.Visible = true;
            this.colProductionDate.VisibleIndex = 8;
            this.colProductionDate.Width = 112;
            // 
            // colDispatchDate
            // 
            this.colDispatchDate.FieldName = "DispatchDate";
            this.colDispatchDate.MinWidth = 30;
            this.colDispatchDate.Name = "colDispatchDate";
            this.colDispatchDate.Visible = true;
            this.colDispatchDate.VisibleIndex = 10;
            this.colDispatchDate.Width = 112;
            // 
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.MinWidth = 30;
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Visible = true;
            this.colWarehouse.VisibleIndex = 4;
            this.colWarehouse.Width = 112;
            // 
            // colOrderQty
            // 
            this.colOrderQty.FieldName = "OrderQty";
            this.colOrderQty.MinWidth = 30;
            this.colOrderQty.Name = "colOrderQty";
            this.colOrderQty.Visible = true;
            this.colOrderQty.VisibleIndex = 5;
            this.colOrderQty.Width = 112;
            // 
            // colStockingUOM
            // 
            this.colStockingUOM.FieldName = "StockingUOM";
            this.colStockingUOM.MinWidth = 30;
            this.colStockingUOM.Name = "colStockingUOM";
            this.colStockingUOM.Visible = true;
            this.colStockingUOM.VisibleIndex = 3;
            this.colStockingUOM.Width = 112;
            // 
            // colShippingInstruction
            // 
            this.colShippingInstruction.FieldName = "ShippingInstruction";
            this.colShippingInstruction.MinWidth = 30;
            this.colShippingInstruction.Name = "colShippingInstruction";
            this.colShippingInstruction.Visible = true;
            this.colShippingInstruction.VisibleIndex = 11;
            this.colShippingInstruction.Width = 112;
            // 
            // colProductionStatus
            // 
            this.colProductionStatus.FieldName = "ProductionStatus";
            this.colProductionStatus.MinWidth = 30;
            this.colProductionStatus.Name = "colProductionStatus";
            this.colProductionStatus.Visible = true;
            this.colProductionStatus.VisibleIndex = 9;
            this.colProductionStatus.Width = 112;
            // 
            // colCourier
            // 
            this.colCourier.FieldName = "Courier";
            this.colCourier.MinWidth = 30;
            this.colCourier.Name = "colCourier";
            this.colCourier.Visible = true;
            this.colCourier.VisibleIndex = 12;
            this.colCourier.Width = 112;
            // 
            // colConNote
            // 
            this.colConNote.FieldName = "ConNote";
            this.colConNote.MinWidth = 30;
            this.colConNote.Name = "colConNote";
            this.colConNote.Visible = true;
            this.colConNote.VisibleIndex = 13;
            this.colConNote.Width = 112;
            // 
            // colPickedBy
            // 
            this.colPickedBy.FieldName = "PickedBy";
            this.colPickedBy.MinWidth = 30;
            this.colPickedBy.Name = "colPickedBy";
            this.colPickedBy.Visible = true;
            this.colPickedBy.VisibleIndex = 14;
            this.colPickedBy.Width = 112;
            // 
            // colNumberOfParcels
            // 
            this.colNumberOfParcels.FieldName = "NumberOfParcels";
            this.colNumberOfParcels.MinWidth = 30;
            this.colNumberOfParcels.Name = "colNumberOfParcels";
            this.colNumberOfParcels.Visible = true;
            this.colNumberOfParcels.VisibleIndex = 15;
            this.colNumberOfParcels.Width = 112;
            // 
            // colTotalNoItems
            // 
            this.colTotalNoItems.FieldName = "TotalNoItems";
            this.colTotalNoItems.MinWidth = 30;
            this.colTotalNoItems.Name = "colTotalNoItems";
            this.colTotalNoItems.Visible = true;
            this.colTotalNoItems.VisibleIndex = 16;
            this.colTotalNoItems.Width = 112;
            // 
            // colTotalWeightKgs
            // 
            this.colTotalWeightKgs.FieldName = "TotalWeightKgs";
            this.colTotalWeightKgs.MinWidth = 30;
            this.colTotalWeightKgs.Name = "colTotalWeightKgs";
            this.colTotalWeightKgs.Visible = true;
            this.colTotalWeightKgs.VisibleIndex = 17;
            this.colTotalWeightKgs.Width = 112;
            // 
            // colLineShipDate
            // 
            this.colLineShipDate.FieldName = "LineShipDate";
            this.colLineShipDate.MinWidth = 30;
            this.colLineShipDate.Name = "colLineShipDate";
            this.colLineShipDate.Visible = true;
            this.colLineShipDate.VisibleIndex = 18;
            this.colLineShipDate.Width = 112;
            // 
            // frmBOReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 721);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmBOReport";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Production Order - Company Z";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmBOReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchCusSorMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource vwFetchCusSorMasterBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colMStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMStockDes;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionCompletion;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDispatchDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colStockingUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colShippingInstruction;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCourier;
        private DevExpress.XtraGrid.Columns.GridColumn colConNote;
        private DevExpress.XtraGrid.Columns.GridColumn colPickedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberOfParcels;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNoItems;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWeightKgs;
        private DevExpress.XtraGrid.Columns.GridColumn colLineShipDate;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repWarehouse;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repStart;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repEnd;
    }
}