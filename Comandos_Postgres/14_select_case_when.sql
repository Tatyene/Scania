/*
	Nessa consulta uniremos as 3 tabelas:
		tb_clientes: documento, nome cliente
		tb_cartoes: numero cartao, limite
		tb_faturas: valor fatura, datavencimento, status
*/

select
	cl.documento, cl.nome,
	ca.numcartao, ca.limite,
	ft.valor, ft.datavencto, 
	
	case ft.status
		when '1' then 'Pendente'
		when '2' then 'Pago'
		else 'Não informado'
	end as Status
from
	administracao.tb_clientes cl, financeiro.tb_cartoes ca,
	financeiro.tb_faturas ft
where
	cl.id = ft.idcliente and ca.id = ft.idcartao