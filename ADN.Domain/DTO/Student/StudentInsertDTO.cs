using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADN.Domain.DTO.Student
{
    public class StudentInsertDTO
    {
        
        [Required(ErrorMessage = "O campo{0} é obrigatório!")]
        [MaxLength(30, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        [MinLength(3, ErrorMessage = "{0} deve ter no mínimo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo{0} é obrigatório!")]
        [MaxLength(2, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo{0} é obrigatório!")]
        public DateTime DataNascimento { get; set; }
    }
}
