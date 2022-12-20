select
	cli.documento, cli.nome AS cliente, cnv.nome as convidado
from
	administracao.tb_clientes cli, administracao.tb_convidado cnv
where
	cli.documento = cnv.cpf;
	
/*
	As tabelas tb_clientes e tb_convidado possuem registros com o mesmo CPF,
	mas com nomes diferentes. Vamos assumir que o nome do cliente seja o correto,
	significando que devemos alterar a tabela de tb_convidado
*/

update 
	administracao.tb_convidado cnv
set
	nome = cli.nome 
from 
	administracao.tb_clientes cli
where 
	cli.documento = cnv.cpf;