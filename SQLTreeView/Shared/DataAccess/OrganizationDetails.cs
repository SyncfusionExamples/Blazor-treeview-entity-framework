using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SQLTreeView.Data
{
    public class OrganizationDetails
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
       
        public int Id { get; set; }
        public int? ParentId { get; set; }
       
        public bool? HasTeam { get; set; }

        public bool? IsExpanded { get; set; }

        public string Name { get; set; }

    }
}
