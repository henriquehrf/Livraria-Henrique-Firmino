app.directive("livro", function () {
	return {
		templateUrl: "view/livro.html",
		restrict: "E",
		scope: {
			conteudo: "=",
		},

		link: function (scope, element, attr) {

			scope.salvarFormulario = function () {

				if (!scope.conteudo.livros)
					scope.conteudo.livros = [];

				scope.conteudo.livros.push(scope.livro);
				scope.livro = null;
			};
		}
	};
});
