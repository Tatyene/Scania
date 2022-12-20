-- subquery -- usada como criterio de busca para a consulta principal

/*
	Desejamos a lista de clientes que possua alguma fatura
*/
select * from administracao.tb_clientes WHERE id IN 
(SELECT idcliente from financeiro.tb_faturas);

select * from administracao.tb_clientes WHERE id IN 
(SELECT DISTINCT idcliente from financeiro.tb_faturas); -- DISTINCT Exclui ID repetidos


SELECT * from financeiro.tb_faturas;
SELECT DISTINCT idcliente from financeiro.tb_faturas;
SELECT DISTINCT idcartao from financeiro.tb_faturas;
SELECT DISTINCT idcliente, idcartao from financeiro.tb_faturas;


/*
	Desejamos a lista de clientes que NÃO possuan alguma fatura
*/
select * from administracao.tb_clientes WHERE id not IN 
(SELECT idcliente from financeiro.tb_faturas);

select * from administracao.tb_clientes WHERE id not IN 
(SELECT DISTINCT idcliente from financeiro.tb_faturas); -- DISTINCT Exclui ID repetidos