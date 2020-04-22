using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace VB_PROJECTS_NOTES.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public string JenkisAddress { get; set; }
        public string GitAddress { get; set; }
        public string ProvisionGitAddress { get; set; }
        public string NexusFrontEndAddress{ get; set; }
        public string NexusProductAddress { get; set; }
        public string BiometricProductAddress { get; set; }
        public string Notes { get; set; }
        [DefaultValue(true)]
        public int Active { get; set; }
        public virtual Country Country{ get; set; }
    }
}
