﻿using Cadastro_Cliente_Api.Data.Dtos;
using Cadastro_Cliente_Api.Models;
using System.IdentityModel.Tokens.Jwt;

namespace Cadastro_Cliente_Api.Data
{
    public interface IClienteDao
    {
        void PostCliente(CreateClienteDto dto, string token);
        IEnumerable<Cliente> Clientes(string token);
    }
}
