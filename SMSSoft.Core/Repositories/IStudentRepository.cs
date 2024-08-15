using SMSSoft.Core.Models;

namespace SMSSoft.Core.Repositories
{
    public interface IStudentRepository
    {
        Task<List<StudentDto>> GetStudentsAsync();

        Task AddStudentAsync(StudentDto student);

        Task UpdateStudentAsync(StudentDto student);

        Task DeleteStudentAsync(StudentDto student);
    }
}
