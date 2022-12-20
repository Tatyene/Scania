/*
	Uso da função coalesce(): ela recebe dois parâmetros, sendo que o 
	objetivo é apresentar o valor do primeiro parâmetro. Se o primeiro parâmetro
	for nulo, ou inválido, o segundo parâmetro é retornado como alternativa.
*/
select 
	id, idinscricao, datapgto, coalesce(valor, 0) as valor
from
	administracao.tb_pagamentos;