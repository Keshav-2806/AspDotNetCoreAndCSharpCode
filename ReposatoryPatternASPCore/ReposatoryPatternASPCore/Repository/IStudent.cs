using RepositoryPatternASPCore.Models;

namespace RepositoryPatternASPCore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
