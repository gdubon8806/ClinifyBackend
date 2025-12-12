using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClinifyBackend.Domain.Entities;

namespace ClinifyBackend.Application.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAll();
    }
}
