﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coreNXTProtoV1.Models;
namespace coreNXTProtoV1.Business.Repository.IRepository
{
    public interface IAttributeNamesRepository
    {
        public Task<IEnumerable<AttributeNamesDTO>> GetAllAttributeNames();

    }
}
