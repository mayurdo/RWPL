using System;
using System.Data.Linq;
using System.Linq.Expressions;
using RWPLEntityModel;

namespace RWPLLinqDataService
{
    partial class RWPLLinqDataContext
    {
    }

    partial class User : IEntity, IPageServiceName
    {
    }

    partial class UserAccessPage : IEntity, IPageServiceName
    {
    }

    partial class Dispatch : IEntity, IPageServiceName
    {
    }

    partial class DispatchItem : IEntity, IPageServiceName
    {
    }

    partial class BundlingM1 : IEntity, IPageServiceName
    {
    }

    partial class PaperReelConsumption : IEntity, IPageServiceName
    {
    }

    partial class DuplexPrintedPaper : IEntity, IPageServiceName
    {
    }

    partial class AutoStichingPin : IEntity, IPageServiceName
    {
    }

    partial class Rotary : IEntity, IPageServiceName
    {
    }

    partial class ItemMaster : IEntity, IPageServiceName
    {
    }

    partial class CustomerMaster : IEntity, IPageServiceName
    {
    }

    partial class DeliveryChallan : IEntity, IPageServiceName
    {
    }

    partial class DeliveryChallanItem : IEntity, IPageServiceName
    {
    }

    partial class InwardMaster : IEntity, IPageServiceName
    {
    }


    // Analysis Reports
    partial class PaperReelConsumptionAnalysi : IPageServiceName
    {
        
    }

    partial class CustomerSummary : IPageServiceName
    {
        
    }

    partial class DispatchAnalysi: IPageServiceName
    {
         
    }

    partial class StockMasterReport: IPageServiceName
    {
         
    }

}
