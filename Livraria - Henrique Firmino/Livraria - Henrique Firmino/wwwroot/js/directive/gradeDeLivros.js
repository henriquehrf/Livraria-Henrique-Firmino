var app = angular.module("livrariaApp", []);

app.directive("gradeDeLivros", function () {
	return {
		templateUrl: "view/gradeDeLivros.html",
		scope: {
			title: "@"
		},
	};
});
