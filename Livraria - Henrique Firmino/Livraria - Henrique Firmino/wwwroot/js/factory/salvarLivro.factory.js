app.factory("salvarLivro", ["$http", function ($http) {

	var vm = {
		salvarLivro: function (livro, aoFinalizar) {
			$http.post(document.URL + "api/Livro/InserirUmLivro", livro)
				.then(function (retorno) {
					if (aoFinalizar)
						aoFinalizar();
				});
		},
	};

	return {
		salvarLivro: function (livro, aoFinalizar) {
			vm.salvarLivro(livro, aoFinalizar);
		}
	};
}]);
