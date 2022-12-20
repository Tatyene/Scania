
/*
	Desejamos a lista de cartões que foram usados (presentes na tabela tb_faturas)
	com valor superior a R$ 1000,00
*/
select * from financeiro.tb_cartoes where id in 
(select distinct idcartao from financeiro.tb_faturas where valor > 1000);

--select * from financeiro.tb_faturas where valor > 1000;