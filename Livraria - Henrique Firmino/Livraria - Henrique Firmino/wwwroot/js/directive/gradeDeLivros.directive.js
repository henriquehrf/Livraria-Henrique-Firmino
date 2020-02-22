app.directive("gradeDeLivros", function () {
	return {
		templateUrl: "view/gradeDeLivros.html",
		restrict: "E",
		scope: {
			conteudo: "="
		},

		link: function (scope, element, attr) {
		}
	};
});
