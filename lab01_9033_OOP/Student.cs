
namespace lab01_9033_OOP
{
    class Student : Person
    {
        private string sId;
        private string khoa;
        private double gpa;

        public Student()
        {
        }

        public Student(string name, string sId, string khoa, double gpa) : base(name)
        {
            SId = sId;
            Khoa = khoa;
            Gpa = gpa;
        }

        public string SId { get => sId; set => sId = value; }

        public string Khoa { get => khoa; set => khoa = value; }

        public double Gpa { get => gpa; set => gpa = value; }

        public override string ToString() => $"Name= {base.Name}, SID= {SId}, Khoa = {Khoa}, GPA = {Gpa}";
    }
}
