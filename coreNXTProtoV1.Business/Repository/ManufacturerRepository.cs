﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coreNXTProtoV1.Business.Repository.IRepository;
using coreNXTProtoV1.Models;
using coreNXTProtoV1.DataAccess.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


namespace coreNXTProtoV1.Business.Repository
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public ManufacturerRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<IEnumerable<ManufacturerDTO>> GetAllManufacturers()
        {
            try
            {
                var manufacturers =
                    _mapper.Map<IEnumerable<Manufacturer>, IEnumerable<ManufacturerDTO>>
                    (_db.Manufacturer);
                return await Task.FromResult(manufacturers);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
