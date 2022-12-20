
-- INNER JOIN (tabela primaria -> tabela secundária)
select
	c.documento, c.nome,
	f.valor, f.datavencto
from
	administracao.tb_clientes c INNER JOIN financeiro.tb_faturas f
on
	c.id = f.idcliente
	
	
-- INNER JOIN (tabela secundaria -> tabela primaria)
select
	c.documento, c.nome,
	f.valor, f.datavencto
from
	financeiro.tb_faturas f INNER JOIN administracao.tb_clientes c
on
	c.id = f.idcliente
	
/* 
	Usando INNER JOIN podemos usar as duas tabelas em quaisquer ordem
*/