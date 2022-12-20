select * from financeiro.tb_faturas;


-- uso de funções de agregação
select count(*) as total_registros from financeiro.tb_faturas;
select count(valor) as total_registros from financeiro.tb_faturas;


select sum(valor) as valor_total from financeiro.tb_faturas; --soma todos os valores do campo referido

select avg(valor) as valor_total from financeiro.tb_faturas; --average (média)

select max(valor) as valor_total from financeiro.tb_faturas; --retorna o maior valor

select min(valor) as valor_total from financeiro.tb_faturas; --retorna o menor valor