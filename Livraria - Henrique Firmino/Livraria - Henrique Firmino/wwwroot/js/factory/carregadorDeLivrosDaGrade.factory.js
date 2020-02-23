app.factory("carregadorDeLivrosDaGrade", ["$http", function ($http) {

	var vm = {
		retornarTodosLivros: function (aoFinalizar) {
			$http.get(document.URL + "api/Livro/RetornarTodosLivros")
				.then(function (retorno) {
					if (aoFinalizar)
						aoFinalizar(retorno.data);
				});
		},
	};

	return {
		retornarTodosLivros: function (aoFinalizar) {
			 vm.retornarTodosLivros(aoFinalizar);
		}
	};
}]);
