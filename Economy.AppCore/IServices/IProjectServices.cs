using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface IProjectServices:IServices<Project>
    {
        List<Project> GetProjectByUser(int IdUser);
        Project FindbyId(int id,int IdUser);
        List<Project> GetProjectsByName(string name, int IdUser);
    }
}
