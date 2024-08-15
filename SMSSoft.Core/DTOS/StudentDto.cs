namespace SMSSoft.Core.Models
{
    public class StudentDto
    {
        public StudentDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
