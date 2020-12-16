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
    
    public partial class T_StayReservationBasics
    {
        public int StayReservationBasicID { get; set; }
        public string StayReservationNO { get; set; }
        public Nullable<System.DateTime> CheckInDate { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerKanaName { get; set; }
        public string ZipCode { get; set; }
        public string Pref { get; set; }
        public string City { get; set; }
        public string OtherAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public Nullable<int> DistrictID { get; set; }
        public Nullable<bool> GroupFlag { get; set; }
        public string ApplicantName { get; set; }
        public Nullable<System.DateTime> ArrivalDateTime { get; set; }
        public string ArrivalNote { get; set; }
        public Nullable<System.DateTime> DepartureDateTime { get; set; }
        public string DepartureNote { get; set; }
        public string AdvancePaymentCharge { get; set; }
        public Nullable<System.DateTime> AdvancePaymentDate { get; set; }
        public Nullable<System.DateTime> ReceptionDate { get; set; }
        public string StayReservationMethod { get; set; }
        public Nullable<int> InputUserID { get; set; }
        public string Note { get; set; }
        public Nullable<bool> CheckInFlag { get; set; }
        public Nullable<bool> CheckOutFlag { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<System.DateTime> CancelRevivalDate { get; set; }
        public string ReservationPhoneNumber { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public Nullable<bool> Visibility { get; set; }
    }
}