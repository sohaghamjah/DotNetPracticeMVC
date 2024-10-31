using PracticeMVC.Models;

namespace PracticeMVC.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudnetModel> getAllStudent()
        {
            return DataSource();
        }

        public StudnetModel getStudentModel(int id)
        {
            return DataSource().Where(x => x.Roll == id).First();
        }

        private List<StudnetModel> DataSource()
        {
            return new List<StudnetModel>
            {
                new StudnetModel
                {
                    Name = "Sohag Hamjah",
                    Roll = 11,
                    Gender = "Male"
                },
                new StudnetModel
                {
                    Name = "Abc Hamjah",
                    Roll = 12,
                    Gender = "Male"
                },
                new StudnetModel
                {
                    Name = "Xyz Hamjah",
                    Roll = 13,
                    Gender = "Female"
                }
            };
        }
    }
}
