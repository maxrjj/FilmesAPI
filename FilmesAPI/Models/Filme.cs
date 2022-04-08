using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public object id { get; set; }

        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage ="Tamanho nao autorizado")]
        public string Genero { get; set; }
        
        [Range(1,600, ErrorMessage = "Fora do range de duração")]
        public int Duracao { get; set; }
        
    }
}
