app.directive("gradeDeLivros", ["carregadorDeLivrosDaGrade", function (carregadorDeLivrosDaGrade) {
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
				scope.conteudo.livros.splice(scope.conteudo.livros.indexOf(livro), 1);
			};
		}
	};
}]);
