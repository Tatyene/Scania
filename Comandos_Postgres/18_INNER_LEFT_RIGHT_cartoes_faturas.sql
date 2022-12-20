--usando JOINS entre as tabelas tb_faturas e tb_cartoes

-- INNER JOIN
select
	ca.numcartao, f.valor, f.datavencto
from
	financeiro.tb_cartoes ca INNER JOIN financeiro.tb_faturas f
on
	ca.id = f.idcartao;
	

-- LEFT JOIN
select
	ca.numcartao, f.valor, f.datavencto
from
	financeiro.tb_cartoes ca LEFT JOIN financeiro.tb_faturas f
on
	ca.id = f.idcartao;
	

-- RIGHT JOIN
select
	ca.numcartao, f.valor, f.datavencto
from
	financeiro.tb_cartoes ca RIGHT JOIN financeiro.tb_faturas f
on
	ca.id = f.idcartao;