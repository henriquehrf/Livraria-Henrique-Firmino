app.directive("gradeDeLivros", ["carregadorDeLivrosDaGrade", "excluirLivro", function (carregadorDeLivrosDaGrade, excluirLivro) {
	return {
		templateUrl: "view/gradeDeLivros.html",
		restrict: "E",
		scope: {
			conteudo: "="
		},

		link: function (scope, element, attr) {

			window.onload = function () {
				let aoFinalizar = function (livros) {
					scope.conteudo.livros = livros;
				};
				carregadorDeLivrosDaGrade.retornarTodosLivros(aoFinalizar);
			};

			scope.editarLivro = function (livro) {
				scope.conteudo.livro = livro;
			};

			scope.excluirLivro = function (livro) {

				let aoExcluir = function () {
					let aoFinalizar = function (livros) {
						scope.conteudo.livros = livros;
					};
					carregadorDeLivrosDaGrade.retornarTodosLivros(aoFinalizar);
				};

				console.log(livro);
				excluirLivro.excluirLivro(livro, aoExcluir);
			};
		}
	};
}]);
