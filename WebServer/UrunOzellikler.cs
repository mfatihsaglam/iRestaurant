
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace iRestaurant
{

using System;
    using System.Collections.Generic;
    
public partial class UrunOzellikler
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public UrunOzellikler()
    {

        this.SiparisUrunleri = new HashSet<SiparisUrunleri>();

    }


    public int urunOzellikId { get; set; }

    public string urunOzellikAd { get; set; }

    public double urunOzellikFiyat { get; set; }

    public int urunId { get; set; }

    public bool silindi { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SiparisUrunleri> SiparisUrunleri { get; set; }

    public virtual Urunler Urunler { get; set; }

}

}
