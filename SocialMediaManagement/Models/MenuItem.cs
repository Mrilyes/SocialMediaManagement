using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaManagement.Models
{
    public class MenuItem
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string URL { get; set; }
        public int Visible { get; set; }
        public string Icon { get; set; }
        public virtual ICollection<MenuItemAction> MenuItemActions { get; set; }
        public virtual ICollection<GroupItemRelation> GroupItemRelations { get; set; }


    }

}
