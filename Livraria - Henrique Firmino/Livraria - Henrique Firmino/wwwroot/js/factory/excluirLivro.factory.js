app.factory("excluirLivro", ["$http", function ($http) {

	var vm = {
		excluirLivro: function (livro, aoFinalizar) {
			$http.post(document.URL + "api/Livro/RemoverUmLivro", livro)
				.then(function (retorno) {
					if (aoFinalizar)
						aoFinalizar();
				});
		},
	};

	return {
		excluirLivro: function (livro, aoFinalizar) {
			vm.excluirLivro(livro, aoFinalizar);
		}
	};
}]);
