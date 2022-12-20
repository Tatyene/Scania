/*Vamos apresentar todos os clientes que possuam alguma fatura
	Nesta consulta serão apresentados:
		tb_clientes: documento e nome
		tb_faturas: valor e datavencto
*/
select 
	administracao.tb_clientes.documento, 
	administracao.tb_clientes.nome,
	financeiro.tb_faturas.valor,
	financeiro.tb_faturas.datavencto
from  
	administracao.tb_clientes, financeiro.tb_faturas
where
	administracao.tb_clientes.id = financeiro.tb_faturas.idcliente;
	
--Atribuindo ALIAS para as tabelas
select 
	c.documento, c.nome,
	f.valor, f.datavencto -- f.* pega todos os campos da tabela fatura na busca
from  
	administracao.tb_clientes c, financeiro.tb_faturas f
where
	c.id = f.idcliente;
	

--Atribuindo ALIAS para as tabelas e para os campos
select 
	c.documento AS CPF, c.nome AS Cliente,
	f.valor, f.datavencto as "Data Vendimento" -- f.* pega todos os campos da tabela fatura na busca
from  
	administracao.tb_clientes c, financeiro.tb_faturas f
where
	c.id = f.idcliente;
	
--Determinando um campo calculado: desconto de 10% para pagamento antecipado
select 
	c.documento AS CPF, c.nome AS Cliente,
	f.valor, f.valor * 0.9 as antecipado, f.datavencto as "Data Vencimento" -- f.* pega todos os campos da tabela fatura na busca
from  
	administracao.tb_clientes c, financeiro.tb_faturas f
where
	c.id = f.idcliente;