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
    
    public partial class T_StoreDeposits
    {
        public int StoreDepositID { get; set; }
        public int DepositID { get; set; }
        public string DepositCode { get; set; }
        public string StoreDepositCode { get; set; }
        public string DepositName { get; set; }
        public string KanaName { get; set; }
        public int ClassifyID { get; set; }
        public string SpecialDepositCode { get; set; }
        public int CompanyID { get; set; }
        public int StoreID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime UpdateDateTime { get; set; }
        public System.DateTime RecordDate { get; set; }
        public bool Visibilidy { get; set; }
    }
}
