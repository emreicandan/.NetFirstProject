using System;
using ExampleAPI.Context;
using ExampleAPI.Core;
using ExampleAPI.Entities;
using ExampleAPI.Repositories.Abstract;

namespace ExampleAPI.Repositories.Concretes;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(ExampleDbContext context) : base(context)
    {
    }
}

