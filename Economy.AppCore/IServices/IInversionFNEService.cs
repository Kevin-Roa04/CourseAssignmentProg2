using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.IServices
{
    public interface IInversionFNEService : IServices<InversionFne>
    {
        public List<InversionFne> GetListByProjectId(int projectId);
        public InversionFne GetById(int id);
        public InversionFne GetByName(string name, int projectId);
    }
}
