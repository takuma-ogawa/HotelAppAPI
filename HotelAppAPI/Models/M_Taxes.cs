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
    
    public partial class M_Taxes
    {
        public int TaxID { get; set; }
        public string TaxCode { get; set; }
        public string TaxName { get; set; }
        public int TaxRate { get; set; }
        public bool ReductionFlag { get; set; }
    }
}
