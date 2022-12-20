-- select * from administracao.tb_convidado;

-- select * from administracao.tb_clientes;

--Objetivo: adicionar os clientes na tabela tb_convidado

insert into administracao.tb_convidado (cpf, nome, email)
select c.documento, c.nome, c.telefone from administracao.tb_clientes c
where c.documento NOT IN (SELECT cpf from administracao.tb_convidado);