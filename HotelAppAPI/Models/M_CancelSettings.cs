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
    
    public partial class M_CancelSettings
    {
        public int CancelID { get; set; }
        public string CancelCode { get; set; }
        public bool StoreDisplayFlag { get; set; }
        public string CancelName { get; set; }
        public int CancelRate { get; set; }
        public int CompanyID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime UpdateDateTime { get; set; }
        public System.DateTime RecordDate { get; set; }
        public bool Visibility { get; set; }
    }
}