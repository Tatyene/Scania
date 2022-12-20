/*
	Nessa consulta uniremos as 3 tabelas:
		tb_clientes: documento, nome cliente
		tb_cartoes: numero cartao, limite
		tb_faturas: valor fatura, datavencimento
*/

select
	cl.documento, cl.nome,
	ca.numcartao, ca.limite,
	ft.valor, ft.datavencto
from
	administracao.tb_clientes cl, financeiro.tb_cartoes ca,
	financeiro.tb_faturas ft
where
	cl.id = ft.idcliente and ca.id = ft.idcartao