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
    
    public partial class curso
    {
        public curso()
        {
            this.aluno = new HashSet<aluno>();
            this.professor = new HashSet<professor>();
        }
    
        public int idcurso { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<aluno> aluno { get; set; }
        public virtual ICollection<professor> professor { get; set; }
    }
}
