﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Drzava
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Drzava()
    {
        this.Ski = new HashSet<Ski>();
    }

    public int id { get; set; }
    public string naziv { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Ski> Ski { get; set; }
}

public partial class Ski
{
    public int id { get; set; }
    public string naziv { get; set; }
    public Nullable<int> drzavaId { get; set; }

    public virtual Drzava Drzava { get; set; }
}
