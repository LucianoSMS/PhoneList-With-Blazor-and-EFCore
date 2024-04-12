using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Contacto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatorio para o campo NOME")]
        [StringLength(200)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatorio para o campo EMAIL")]
        [StringLength(150)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatorio para o campo TELEMOVEL")]
        [StringLength(100)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatorio para o campo TELEFONE")]
        [StringLength(100)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Preenchimento obrigatorio para o campo ENDERECO")]
        [StringLength(200)]
        public string Address { get; set; }

        [Required(ErrorMessage = "*Obrigatorio Selecionar uma Imagem")]
        public string Photo {  get; set; }

        public Contacto() { }
    }
}
