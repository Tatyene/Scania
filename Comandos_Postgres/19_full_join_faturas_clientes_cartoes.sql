-- Unindo as três tabelas

select
	cl.nome, ca.numcartao, f.datavencto, f.valor
from 
	financeiro.tb_faturas f 
INNER JOIN administracao.tb_clientes cl on cl.id = f.idcliente
INNER JOIN financeiro.tb_cartoes ca on ca.id = f.idcartao;

select
	cl.nome, ca.numcartao, f.datavencto, f.valor
from 
	financeiro.tb_faturas f 
INNER JOIN administracao.tb_clientes cl on cl.id = f.idcliente
LEFT JOIN financeiro.tb_cartoes ca on ca.id = f.idcartao;


select
	cl.nome, ca.numcartao, f.datavencto, f.valor
from 
	financeiro.tb_faturas f 
INNER JOIN administracao.tb_clientes cl on cl.id = f.idcliente
RIGHT JOIN financeiro.tb_cartoes ca on ca.id = f.idcartao;


select
	cl.nome, ca.numcartao, f.datavencto, f.valor
from 
	financeiro.tb_faturas f 
right JOIN administracao.tb_clientes cl on cl.id = f.idcliente
right JOIN financeiro.tb_cartoes ca on ca.id = f.idcartao;


select
	cl.nome, ca.numcartao, f.datavencto, f.valor
from 
	financeiro.tb_faturas f 
full JOIN administracao.tb_clientes cl on cl.id = f.idcliente
full JOIN financeiro.tb_cartoes ca on ca.id = f.idcartao;


select
	cl.nome, ca.numcartao, f.datavencto, f.valor
from 
	financeiro.tb_faturas f 
left JOIN administracao.tb_clientes cl on cl.id = f.idcliente
left JOIN financeiro.tb_cartoes ca on ca.id = f.idcartao;