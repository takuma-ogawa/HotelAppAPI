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
    
    public partial class T_StayReservationGuestLists
    {
        public int StayGuestListID { get; set; }
        public Nullable<int> StayReservationBasicID { get; set; }
        public Nullable<int> StayReservationDetailID { get; set; }
        public Nullable<int> StayReservationRoomTypeID { get; set; }
        public Nullable<int> StayReservationRoomID { get; set; }
        public string StayReservationRoomCode { get; set; }
        public string StayReservationRoomCodeBranchNumber { get; set; }
        public Nullable<System.DateTime> UseDate { get; set; }
        public string GuestName { get; set; }
        public string GuestNameKana { get; set; }
        public string Pref { get; set; }
        public string City { get; set; }
        public string OtherAddress { get; set; }
        public string Sex { get; set; }
        public Nullable<int> DistrictID { get; set; }
        public Nullable<bool> DMFlag { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public Nullable<bool> Visibility { get; set; }
    }
}
