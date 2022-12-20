select * from administracao.tb_evento;

--Escolher 2 registros (eventos) e atribuir 0 para o valor
update administracao.tb_evento set preco = 0 where id = 4;

--Escolher 2 registros e reajustar seu valor em 10% (registros com valor <> 0)
update administracao.tb_evento set preco = preco * 1.1 where id in (1, 3);

--Atribuir o valor de R$ 100,00 para os eventos gratuitos.
update administracao.tb_evento set preco = 100 where preco = 0;

-- Para os eventos cujo responsável tenha menos que 7 caracteres, acrescentar o sobrenome 'Silva'
-- Obs.: operador de concatenação: ||
update administracao.tb_evento set responsavel = responsavel || ' Silva'
where length(responsavel) < 7;