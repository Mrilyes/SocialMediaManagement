using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaManagement.Models
{
    public class GroupItemRelation
    {
        [Key]
        public int GroupMenuItemRelationId { get; set; }

        public int GroupID { get; set; }

        [ForeignKey(nameof(GroupID))]

        public virtual Group Group { get; set; }


        public int ItemID { get; set; }

        [ForeignKey(nameof(ItemID))]

        public virtual MenuItem MenuItem { get; set; }



    }
}
