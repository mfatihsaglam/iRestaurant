
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace iRestaurantPosPrinterSoftware
{

using System;
    using System.Collections.Generic;
    
public partial class YazdirmaListesi
{

    public int yazdirmaListeId { get; set; }

    public int subeId { get; set; }

    public int siparislerId { get; set; }

    public bool silindi { get; set; }



    public virtual Siparisler Siparisler { get; set; }

    public virtual Subeler Subeler { get; set; }

}

}