﻿using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.Api.DataModels;

namespace StudentAdminPortal.Api.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            _context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
           return await  _context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
