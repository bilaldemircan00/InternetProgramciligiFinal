//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bilal_internet_prg_api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cevaplar
    {
        public int cevap_id { get; set; }
        public string cevap_icerik { get; set; }
        public int uye_id { get; set; }
        public int soru_id { get; set; }
        public System.DateTime tarih { get; set; }
    
        public virtual Sorular Sorular { get; set; }
        public virtual Uyeler Uyeler { get; set; }
    }
}
