﻿using Domain.Entities;
using Domain.Abstract;

namespace Domain.Repositories
{
    public interface ILectionsRepository : IDbRepository<Lection>
    {
    }
}
