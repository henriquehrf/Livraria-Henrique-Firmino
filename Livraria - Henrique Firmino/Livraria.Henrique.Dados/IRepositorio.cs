using System.Collections.Generic;

namespace Livraria.Henrique.Dados
{
	public interface IRepositorio<T> where T : class
	{
		IEnumerable<T> Todos { get; }
		void Incluir(T obj);
		void Alterar(T obj);
		void Excluir(T obj);
	}
}
