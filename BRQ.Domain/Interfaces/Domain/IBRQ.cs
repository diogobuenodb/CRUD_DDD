﻿using BRQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRQ.Domain.Interfaces.Domain
{
    public interface IBRQ
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Create(User user);
        void Delete(int id);
        void Edit(User user);
    }
}
