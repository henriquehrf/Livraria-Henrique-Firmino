app.directive("livro", ["salvarLivro", "alterarLivro", "carregadorDeLivrosDaGrade", function (salvarLivro, alterarLivro, carregadorDeLivrosDaGrade) {
	return {
		templateUrl: "view/livro.html",
		restrict: "E",
		scope: {
			conteudo: "="
		},

		link: function (scope, element, attr) {
			scope.salvarFormulario = function () {
				if (!scope.conteudo.livros)
					scope.conteudo.livros = [];

				let aoSalvar = function () {
					let aoFinalizar = function (livros) {
						scope.conteudo.livros = livros;
					};
					carregadorDeLivrosDaGrade.retornarTodosLivros(aoFinalizar);
				};

				if (!scope.conteudo.livro.id)
					salvarLivro.salvarLivro(scope.conteudo.livro, aoSalvar);
				else
					alterarLivro.alterarLivro(scope.conteudo.livro, aoSalvar);

				scope.conteudo.livro = null;
			};

		}
	};
}]);
