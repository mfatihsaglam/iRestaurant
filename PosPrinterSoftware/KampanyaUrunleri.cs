
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
    
public partial class KampanyaUrunleri
{

    public int kampanyaUrunleriId { get; set; }

    public int kampanyaId { get; set; }

    public int urunId { get; set; }

    public bool silindi { get; set; }



    public virtual Kampanyalar Kampanyalar { get; set; }

    public virtual Urunler Urunler { get; set; }

}

}