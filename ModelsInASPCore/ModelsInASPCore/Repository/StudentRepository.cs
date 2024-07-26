using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Keshav", Gender = "Male", Standard = 11 },
                new StudentModel { rollNo = 2, Name = "Madhav", Gender = "Male", Standard = 12 },
                new StudentModel { rollNo = 3, Name = "Pranav", Gender = "Male", Standard = 10 },
                new StudentModel { rollNo = 4, Name = "Suraj", Gender = "Male", Standard = 7 },
                new StudentModel { rollNo = 5, Name = "Pranay", Gender = "Male", Standard = 1 },

            };
        }
        public List<StudentModel> getAllStudents()
        {
            return DataSource(); 
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x=>x.rollNo==id).FirstOrDefault();
        }
       
    }
}
