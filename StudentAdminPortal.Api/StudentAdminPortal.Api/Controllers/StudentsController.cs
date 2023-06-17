using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.Api.DomainModels;
using StudentAdminPortal.Api.Repositories;

namespace StudentAdminPortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper mapper;
        public StudentsController(IStudentRepository studentRepository,IMapper mapper)
        {
            _studentRepository= studentRepository;
            this.mapper=mapper;
        }
        [HttpGet,Route("GetAllStudentsAsync")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {

           var students =await _studentRepository.GetStudentsAsync();

            return Ok(mapper.Map<List<Student>>(students));
         
        }

    }
}
