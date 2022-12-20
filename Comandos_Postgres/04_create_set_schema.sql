--Criando o schema financeiro
create schema financeiro;

--movendo a tabela cliente de schema
alter table administracao.tb_clientes set schema financeiro;

--retornando tb_cliente e alterando tb_cartoes
alter table financeiro.tb_clientes set schema administracao;
alter table administracao.tb_cartoes set schema financeiro;