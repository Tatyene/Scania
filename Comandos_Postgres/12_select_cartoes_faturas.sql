/*
	Vamos estabelecer um vínculo entre tb_cartoes e tb_faturas:
		tb_cartoes: limite, numero do cartao
		tb_faturas: valor, data vencimento
*/

select
	c.numcartao, c.limite,
	f.valor, f.datavencto
from
	financeiro.tb_cartoes c,
	financeiro.tb_faturas f
where
	c.id = f.idcartao
	
-- Realizar a consulta anterior incluindo uma coluna representando o saldo do cartao
select
	c.numcartao, c.limite,
	f.valor, (c.limite - f.valor) as saldo, f.datavencto
from
	financeiro.tb_cartoes c, financeiro.tb_faturas f
where
	c.id = f.idcartao