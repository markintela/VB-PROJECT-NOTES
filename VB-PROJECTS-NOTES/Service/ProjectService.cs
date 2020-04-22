using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VB_PROJECTS_NOTES.Interface;
using VB_PROJECTS_NOTES.Models;

namespace VB_PROJECTS_NOTES.Service
{
    public class ProjectService : IProject
    {

        private readonly IHostingEnvironment _hostingEnvironment;
        public ProjectService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IList<Project>> GetPaginatedResult(int currentPage, int pageSize = 10)
        {
            var data = await GetData();
            return data.OrderBy(d => d.Id).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public async Task<int> GetCount()
        {
            var data = await GetData();
            return data.Count;
        }

        private async Task<IList<Project>> GetData()
        {
            var json = await File.ReadAllTextAsync(Path.Combine(_hostingEnvironment.ContentRootPath, "Data", "paging.json"));
            return JsonConvert.DeserializeObject<List<Project>>(json);
        }
    }
}
