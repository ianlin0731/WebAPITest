namespace WebAPITest.Models.Dtos
{
    public class CourseCreateDto
    {
        public int CourseID { get; set; }

        public required string Title { get; set; }

        public int Credits { get; set; }
    }
}
