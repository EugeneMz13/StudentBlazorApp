namespace StudentAppMint.Data
{
    public class Student
    {
        public DateTime RegistrationDate { get; set; }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public double AvgStudentScore { get; set; }
    }
}
