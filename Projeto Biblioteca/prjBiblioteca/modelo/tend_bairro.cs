//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjBiblioteca.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tend_bairro
    {
        public tend_bairro()
        {
            this.tend_endereco = new HashSet<tend_endereco>();
        }
    
        public int id_bairro { get; set; }
        public string bairro { get; set; }
        public int id_cidade { get; set; }
    
        public virtual tend_cidade tend_cidade { get; set; }
        public virtual ICollection<tend_endereco> tend_endereco { get; set; }
    }
}
