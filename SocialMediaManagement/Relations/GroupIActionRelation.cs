using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaManagement.Models
{
    public class GroupIActionRelation
    {
        [Key]
        public int GroupIActionRelationID { get; set; }

        public int GroupID { get; set; }

        [ForeignKey(nameof(GroupID))]

        public virtual Group Group { get; set; }


        public int ItemActionID { get; set; }

        [ForeignKey(nameof(ItemActionID))]

        public virtual MenuItemAction MenuItemAction { get; set; }
    }
}
