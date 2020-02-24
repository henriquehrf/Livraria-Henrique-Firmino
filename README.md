# Livraria-Henrique-Firmino

Este é um projeto protótipo de CRUD SPA utilizando as tecnologias <b>AngularJS, MVC, Entity FrameworkCore, MS Unit Test e Selenium WebDriver Test.</b>

## Passos para uso

Após baixar o projeto, o <b> primeiro passo </b> é configurar a conexão com o banco de dados. Para isto, no projeto <b>Livraria.Henrique.Dados</b>, classe LivroContext, configure a string de conexão.

Pronto, agora só selecionar o projeto <b>Livraria.Henrique.Web</b> como projeto de <i> Set as StartUp Projet</i> e executar a solução.

## Sobre os recursos implementados

Atualmente o projeto foi desenvolvido com o front-end utilizando AngularJS, foi utilizado os recursos de <i>diretivas</i>  e <i> factorys </i> para componentização e fluxo dos elementos de tela. 
Sobre a persistência, utilizou-se o ORM Entity Framework Core.
Sobre a estrutura de teste, utilizou-se os recursos do MS UnitTest para os testes de unidades, basicamente validando a persistência dos dados no banco de dados.
Já a estrutura de teste do Selenium WebDriver, teve como foco validar teste de UI e dar subsidio para testes futuros de maior complexidade simulando o comportamento de um usuário.

Sobre as funcionalidades, basicamente é um CRUD de uma tabela de livros.

## Autor
<li>Henrique R. Firmino - Projeto Inicial</li>
