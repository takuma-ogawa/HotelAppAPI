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
    
    public partial class M_Employees
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string Password { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string EmployeeName { get; set; }
        public string RoleCode { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public System.DateTime UpdateDateTime { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public Nullable<bool> Visibility { get; set; }
    }
}
