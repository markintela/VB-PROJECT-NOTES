using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace VB_PROJECTS_NOTES.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DefaultValue(1)]
        public int Active { get; set; }
    }
}
