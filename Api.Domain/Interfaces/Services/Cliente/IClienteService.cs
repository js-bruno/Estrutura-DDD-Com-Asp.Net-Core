using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Cliente
{
    public interface IClienteService
    {
        Task<ClienteEntity> Get(Guid id);
        Task<IEnumerable<ClienteEntity>> GetAll();

        Task<ClienteEntity> Post(ClienteEntity cliente);
        Task<ClienteEntity> Put(ClienteEntity cliente);
        Task<bool> Delete(Guid id);

    }

}