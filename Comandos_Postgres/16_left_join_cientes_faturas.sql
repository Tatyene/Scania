
-- LEFT JOIN (tabela primaria -> tabela secundária)
select
	c.documento, c.nome,
	f.valor, f.datavencto
from
	administracao.tb_clientes c LEFT JOIN financeiro.tb_faturas f
on
	c.id = f.idcliente
	
	
-- LEFT JOIN (tabela secundaria -> tabela primaria)
select
	c.documento, c.nome,
	f.valor, f.datavencto
from
	financeiro.tb_faturas f LEFT JOIN administracao.tb_clientes c
on
	c.id = f.idcliente
