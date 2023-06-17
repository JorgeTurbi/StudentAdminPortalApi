using StudentAdminPortal.Api.DataModels;

namespace StudentAdminPortal.Api.Repositories
{
    public interface IStudentRepository
    {
       Task<List<Student>> GetStudentsAsync();


    }
}
