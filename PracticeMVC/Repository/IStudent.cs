using PracticeMVC.Models;

namespace PracticeMVC.Repository
{
    public interface IStudent
    {
        List<StudnetModel> getAllStudent();

        StudnetModel getStudentModel(int id);
    }
}
