-- select sumn(valor) from financeiro.tb_faturas;
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
/*
	Oagrupamento (GROUP BY) deve levar em conta os campos que não forem
	usados em alguma função de agregação
*/