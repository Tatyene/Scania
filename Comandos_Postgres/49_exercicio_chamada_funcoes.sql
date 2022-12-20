select * from administracao.tb_convidado;

select administracao.CalcularTotalEventos(13);

--Valor 0 volta null
select  
	cv. id, cv.nome, 
	LENGTH(cv.nome) as caracteres_nome,
	administracao.CalcularTotalEventos(18) AS total
FROM administracao.tb_convidado cv
WHERE cv.id = 18;

--valor 0 volta 0
select  
	cv. id, cv.nome, 
	LENGTH(cv.nome) as caracteres_nome,
	COALESCE(administracao.CalcularTotalEventos(18), 0) AS total
FROM administracao.tb_convidado cv
WHERE cv.id = 18;

