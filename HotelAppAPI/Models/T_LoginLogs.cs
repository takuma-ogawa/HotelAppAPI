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
    
    public partial class T_LoginLogs
    {
        public int LoginLogID { get; set; }
        public string CompanyCode { get; set; }
        public string StoreCode { get; set; }
        public string EmployeeID { get; set; }
        public string Password { get; set; }
        public System.DateTime LoginDateTime { get; set; }
        public bool SuccessFlag { get; set; }
    }
}
