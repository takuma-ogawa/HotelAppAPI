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
    
    public partial class T_StayReservationDetails
    {
        public int StayReservationDetailID { get; set; }
        public Nullable<int> StayReservationID { get; set; }
        public string StayReservationNO { get; set; }
        public string StayReservationNOBranchNumber { get; set; }
        public Nullable<System.DateTime> UseDate { get; set; }
        public Nullable<int> BreakfastNumber { get; set; }
        public Nullable<int> BreakfastUnnecessaryNumber { get; set; }
        public Nullable<int> BreakfastUnselectedNumber { get; set; }
        public Nullable<int> DinnerNumber { get; set; }
        public Nullable<int> DinnerUnnecessaryNumber { get; set; }
        public Nullable<int> DinnerUnselectedNumber { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<bool> Visibility { get; set; }
    }
}