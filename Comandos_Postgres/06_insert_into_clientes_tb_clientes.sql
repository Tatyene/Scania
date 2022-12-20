-- Inserindo novos registros na tabela tb_clientes, menos o campo id (serial)

insert into administracao.tb_clientes (documento, nome, telefone, endereco, uf, status) 
values ('27951968080', 'Impacta solucoes', '3254-2200', 'av paulista, 1009', 'SP', TRUE);

-- incluindo varios registros simultaneamente.
insert into administracao.tb_clientes (documento, nome, telefone, endereco, uf, status) 
values
	('61537012053', 'Jose Antonio', '3106-0774', 'R gomes freire, 33', 'SP', TRUE),
	('21105892050', 'Matheus Santos', '3135-5500', 'Av santo amaro, 1001', 'SP', true),
	('70455835080', 'Carlos Henrique', '3931-0657', 'Av Paulista, 386', 'SP', FALSE);