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
    
    public partial class T_StoreBankAccounts
    {
        public int StoreBankAccountID { get; set; }
        public int BankAccountID { get; set; }
        public string BankAccountCode { get; set; }
        public string StoreBankAccountCode { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BankKanaName { get; set; }
        public string BranchKanaName { get; set; }
        public string BankKind { get; set; }
        public string BankNumber { get; set; }
        public string AccountHolder { get; set; }
        public int CompanyID { get; set; }
        public int StoreID { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime UpdateDateTime { get; set; }
        public System.DateTime RecordDate { get; set; }
        public bool Visicility { get; set; }
    }
}
