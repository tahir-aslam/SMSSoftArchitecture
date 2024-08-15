using SMSSoft.Core.Interfaces;
using SMSSoft.Core.Models;
using SMSSoft.Core.Repositories;
using SMSSoft.Repositories;

namespace SMSSoft.Services
{
    public class StudentService : IStudentService
    {
        public async Task AddStudentAsync(StudentDto student)
        {
            IStudentRepository studentRepository = new StudentRepository();
            await studentRepository.AddStudentAsync(student);
        }

        public Task DeleteStudentAsync(StudentDto student)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentDto>> GetStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudentAsync(StudentDto student)
        {
            throw new NotImplementedException();
        }
    }
}
