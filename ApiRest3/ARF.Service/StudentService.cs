using ARF.Domain;

namespace ARF.Service
{
    public class StudentService
    {
        public void AddStudent(Student student)
        {
            int age = DateTime.Today.Year - student.Birthday.Year;

            if(age >= 18)
            {
                if (student.CPF.Length != 11)
                {
                    throw new Exception("CPF inválido");
                }
            }
            else
            {
                throw new Exception("Aluno tem que ter 18 anos ou mais");
            }
        }
    }
}
