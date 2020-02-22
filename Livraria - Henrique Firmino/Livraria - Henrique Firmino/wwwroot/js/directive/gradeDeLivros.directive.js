app.directive("gradeDeLivros", function () {
	return {
		templateUrl: "view/gradeDeLivros.html",
		restrict: "E",
		scope: {
			title: "="
		},

		link: function (scope, element, attr) {
		}
	};
});
