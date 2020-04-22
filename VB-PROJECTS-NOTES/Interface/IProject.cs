using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VB_PROJECTS_NOTES.Models;

namespace VB_PROJECTS_NOTES.Interface
{
    interface IProject
    {
       public interface IPersonService
        {
            Task<IList<Project>> GetPaginatedResult(int currentPage, int pageSize = 10);
            Task<int> GetCount();
        }
    }
}
