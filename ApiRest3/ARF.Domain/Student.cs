using System.ComponentModel.DataAnnotations;

namespace ARF.Domain
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome deve ter mais que 2 caracteres")]
        [MaxLength(150, ErrorMessage = "O nome deve ter 150 ou menos caracteres")]        
        public string Name { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatório")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        public string CPF { get; set; }
    }
}
