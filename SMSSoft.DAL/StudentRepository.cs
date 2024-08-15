using SMSSoft.Core.Models;
using SMSSoft.Core.Repositories;
using SMSSoft.Repositories.Entities;

namespace SMSSoft.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public Task AddStudentAsync(StudentDto studentDto)
        {
            Student student = new Student()
            {
                Id = studentDto.Id,
                Name = studentDto.Name,
            };

            //DBContext.Students.Add(student);

            throw new NotImplementedException();
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
