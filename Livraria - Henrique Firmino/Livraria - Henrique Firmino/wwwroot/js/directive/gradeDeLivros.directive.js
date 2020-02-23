app.directive("gradeDeLivros", function () {
	return {
		templateUrl: "view/gradeDeLivros.html",
		restrict: "E",
		scope: {
			conteudo: "="
		},

		link: function (scope, element, attr) {
			scope.editarLivro = function (livro) {
				scope.conteudo.livro = livro;
			};

			scope.excluirLivro = function (livro) {
				scope.conteudo.livros.splice(scope.conteudo.livros.indexOf(livro), 1);
			};
		}
	};
});
