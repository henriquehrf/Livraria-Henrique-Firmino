app.factory("alterarLivro", ["$http", function ($http) {

	var vm = {
		alterarLivro: function (livro, aoFinalizar) {
			$http.put(document.URL + "api/Livro/AlterarUmLivro", livro)
				.then(function (retorno) {
					if (aoFinalizar)
						aoFinalizar();
				});
		},
	};

	return {
		alterarLivro: function (livro, aoFinalizar) {
			vm.alterarLivro(livro, aoFinalizar);
		}
	};
}]);
