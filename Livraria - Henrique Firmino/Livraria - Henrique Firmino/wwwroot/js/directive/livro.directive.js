app.directive("livro", function () {
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

				if (!scope.conteudo.livro.id) {
					scope.conteudo.livro.id = scope.conteudo.livros.length;
					scope.conteudo.livros.push(scope.conteudo.livro);
				}

				scope.conteudo.livro = null;
			};

		}
	};
});
