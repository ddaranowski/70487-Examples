//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NinjaDomain.OldStyleContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ninja
    {
        public Ninja()
        {
            this.NinjaEquipments = new HashSet<NinjaEquipment>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ServedInOniwaban { get; set; }
        public int ClanId { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual Clan Clan { get; set; }
        public virtual ICollection<NinjaEquipment> NinjaEquipments { get; set; }
    }
}