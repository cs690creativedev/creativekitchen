
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ck_project
{

using System;
    using System.Collections.Generic;
    
public partial class rates_installation
{

    public int rates_installation_number { get; set; }

    public int rate_number { get; set; }

    public int installation_number { get; set; }



    public virtual installation installation { get; set; }

    public virtual rate rate { get; set; }

}

}
