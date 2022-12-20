-- select sumn(valor) from financeiro.tb_faturas;
select
	c.documento, c.nome, ca.numcartao, sum(f.valor) as total, COUNT(f.valor) as qtde_faturas
from
	administracao.tb_clientes c 
INNER JOIN financeiro.tb_faturas f on c.id = f.idcliente
INNER JOIN financeiro.tb_cartoes ca on ca.id = f.idcartao
GROUP BY
	c.documento, c.nome, ca.numcartao
ORDER BY 
	c.documento;
/*
	O agrupamento (GROUP BY) deve levar em conta os campos que não forem
	usados em alguma função de agregação
*/