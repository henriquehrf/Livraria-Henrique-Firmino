using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria___Henrique_Firmino.Models
{
	public class LivroVO
	{
		[Key]
		[Column(Order = 1)]
		public int Id { get; set; }
		[Column(Order = 2)]
		public string Titulo { get; set; }
		[Column(Order = 3)]
		public string Genero { get; set; }
		[Column(Order = 4)]
		public DateTime DataPublicacao { get; set; }
		[Column(Order = 5)]
		public int Pagina { get; set; }
		[Column(Order = 6)]
		public string Autor { get; set; }
		[Column(Order = 7)]
		public string Editora { get; set; }
		[Column(Order = 8)]
		public string Descricao { get; set; }
		[Column(Order = 9)]
		public string Sinopse { get; set; }
		[Column(Order = 10)]
		public string Capa { get; set; }
		[Column(Order = 11)]
		public string Links { get; set; }

	}
}
