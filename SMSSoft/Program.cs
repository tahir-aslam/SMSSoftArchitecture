// See https://aka.ms/new-console-template for more information
using SMSSoft.Core.Interfaces;
using SMSSoft.Core.Models;
using SMSSoft.Services;

Console.WriteLine("My School Management Software!");

StudentDto student = new StudentDto(1, "Muhammad");

IStudentService studentService = new StudentService();

await studentService.AddStudentAsync(student);
    
