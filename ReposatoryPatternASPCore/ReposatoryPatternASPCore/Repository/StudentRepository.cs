using RepositoryPatternASPCore.Models;

namespace RepositoryPatternASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel{ StdId = 1,StdName="Keshav",StdGender="Male",StdStandard=12},
                new StudentModel{ StdId = 2,StdName="Madhav",StdGender="Male",StdStandard=13}

            };
        }
        public List<StudentModel> getAllStudents()
        {
           return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.StdId == id).FirstOrDefault();
        }
    }
}
