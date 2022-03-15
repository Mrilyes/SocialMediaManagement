using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaManagement.Models
{
    public class MenuItemAction
    {
        [Key]
        public int ItemActionID { get; set; }
        public string ItemActionName { get; set; }

        public virtual MenuItem MenuItem { get; set; }

    }
}
