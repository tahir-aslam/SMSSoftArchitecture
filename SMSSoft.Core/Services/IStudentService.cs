using SMSSoft.Core.Models;

namespace SMSSoft.Core.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentDto>> GetStudentsAsync();

        Task AddStudentAsync(StudentDto student);

        Task UpdateStudentAsync(StudentDto student);

        Task DeleteStudentAsync(StudentDto student);
    }
}
