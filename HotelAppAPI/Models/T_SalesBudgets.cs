//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelAppAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_SalesBudgets
    {
        public int SalesBudgetID { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public Nullable<int> Budget { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public Nullable<int> EmployeeID { get; set; }
    }
}
