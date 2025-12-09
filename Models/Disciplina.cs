using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisciplinasApi.Models
{
	public class Disciplina
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public string Nome { get; set; } = null!;

		[Required]
		public int CargaHoraria { get; set; }

		public string? Professor { get; set; }
	}
}
