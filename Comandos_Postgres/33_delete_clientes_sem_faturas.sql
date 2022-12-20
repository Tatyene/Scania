select * from administracao.tb_clientes;

--Buscar todos os clientes que não possuam fatura

select * from administracao.tb_clientes where id not in
 (select idcliente from financeiro.tb_faturas);

-- Remover todos os clientes que não estejam na tabela tb_faturas
delete from administracao.tb_clientes where id not in
 (select idcliente from financeiro.tb_faturas);


-- Esta instrução falhará porque o cliente id=1 é referenciado em tb_faturas
delete from administracao.tb_clientes where id = 1;