using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VB_PROJECTS_NOTES.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        [DefaultValue(1)]
        public int Active { get; set; }
        public virtual Region Region { get; set; }
    }
}
