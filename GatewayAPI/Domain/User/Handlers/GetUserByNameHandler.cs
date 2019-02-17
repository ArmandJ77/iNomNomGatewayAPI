﻿using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Infrastructure;
using Domain.User.DTO;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace Domain.User.Handlers
{
    public class GetUserByNameHandler : BaseHandler, IGetUserByNameHandler
    {
        public GetUserByNameHandler(IMapper autoMapper, GatewayContext context) : base(autoMapper, context)
        {
        }

        public async Task<UserDto> ExecuteAsync(string userName)
        {
            //Check local DB
            var entity = await Context.ClientAuthentications.SingleOrDefaultAsync(x => x.UserName == userName);

            if (entity != null)
                if(entity.IsValid == true && !entity.IsDeleted)
                return mapper.Map<ClientAuthentication,UserDto>(entity);

            return null;
        }
    }

    public interface IGetUserByNameHandler
    {
        Task<UserDto> ExecuteAsync(string userName);
    }
}
