//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POScreen.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_FetchCusSorMaster
    {
        public string SalesOrder { get; set; }
        public string MStockCode { get; set; }
        public string MStockDes { get; set; }
        public string InvoiceNumber { get; set; }
        public string ProductionCompletion { get; set; }
        public Nullable<System.DateTime> ProdDate { get; set; }
        public string ProductionDate { get; set; }
        public string DispatchDate { get; set; }
        public string Warehouse { get; set; }
        public Nullable<decimal> OrderQty { get; set; }
        public string StockingUOM { get; set; }
        public string ShippingInstruction { get; set; }
        public string ProductionStatus { get; set; }
        public string Courier { get; set; }
        public string ConNote { get; set; }
        public string PickedBy { get; set; }
        public string NumberOfParcels { get; set; }
        public string TotalNoItems { get; set; }
        public string TotalWeightKgs { get; set; }
        public string LineShipDate { get; set; }
    }
}
