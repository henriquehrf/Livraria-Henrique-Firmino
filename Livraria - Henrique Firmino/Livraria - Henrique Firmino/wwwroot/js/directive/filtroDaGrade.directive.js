app.directive("filtroDaGrade", ["$filter", function ($filter) {
	return {
		templateUrl: "view/filtroDaGrade.html",
		restrict: "E",
		scope: {
			conteudo: "=",
		},

		link: function (scope, element, attr) {
			scope.filtrarLivros = function () {
				scope.conteudo.termoDeBusca = scope.termoDeBusca;
			};
		}
	};
}]);
