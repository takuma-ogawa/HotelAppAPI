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
    
    public partial class M_DayDefaultChargeRanks
    {
        public int DayDefaultChargeRankID { get; set; }
        public int StoreID { get; set; }
        public int CompanyID { get; set; }
        public string MonRank { get; set; }
        public string TueRank { get; set; }
        public string WedRank { get; set; }
        public string ThuRank { get; set; }
        public string FriRank { get; set; }
        public string SatRank { get; set; }
        public string SunRank { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime UpdateDateTime { get; set; }
        public System.DateTime RecordDate { get; set; }
    }
}
