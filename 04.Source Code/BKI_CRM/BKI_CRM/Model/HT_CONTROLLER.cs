//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BKI_CRM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HT_CONTROLLER
    {
        public HT_CONTROLLER()
        {
            this.HT_ACTION = new HashSet<HT_ACTION>();
        }
    
        public System.Guid ID { get; set; }
        public string CONTROLLER_NAME { get; set; }
    
        public virtual ICollection<HT_ACTION> HT_ACTION { get; set; }
    }
}