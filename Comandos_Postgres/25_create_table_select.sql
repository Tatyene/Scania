/*
	Nós vamos salvar o resultado da busca em uma tabela chamada
	administracao.tb_clientes_compras
*/

CREATE TABLE IF NOT EXISTS administracao.tb_clientes_compras
AS
	select
		c.documento, c.nome, sum(f.valor) as total, COUNT(f.valor) as qtde_faturas
	from
		administracao.tb_clientes c INNER JOIN financeiro.tb_faturas f
	on
		c.id = f.idcliente
	GROUP BY
		c.documento, c.nome
	ORDER BY 
		c.documento;
		
select * from administracao.tb_clientes_compras;
