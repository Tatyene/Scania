-- Tabela tb_clientes - consultas

--1. buscar todos os clientes

select * from administracao.tb_clientes;

--2. buscar somente as colunas: documentos, nome e telefone, de todos os clientes

select documento, nome, telefone from administracao.tb_clientes;

select nome, telefone, documento from administracao.tb_clientes;

--3. Buscar todos os campos do cliente com documento = 61537012053

select * from administracao.tb_clientes where documento = '61537012053';

--4. todos os campos dos clientes cujo id esteja na faixa de 5 a 10

select * from administracao.tb_clientes where id >= 5 and id <= 10;

select * from administracao.tb_clientes where id BETWEEN 5 AND 10;

--5. Todos os campos dos cliente que não sejam de sp.

select * from administracao.tb_clientes where uf <> 'SP'; --com <>
select * from administracao.tb_clientes where uf != 'SP'; --com !=

--6.Mesmo que o exercício 5, mas colocando em ordem de estado e em cada estado, por ordem de nome
select * from administracao.tb_clientes where uf <> 'SP' order by uf, nome;
select * from administracao.tb_clientes where uf != 'SP' order by uf, nome desc; --ordem descendente
select * from administracao.tb_clientes where uf <> 'SP' order by uf, nome asc; -- ordem ascendente

--7. Buscando os cliente que tenham o nome iniciando com a letra 'A'
select * from administracao.tb_clientes where nome like 'A%';

--8. Clientes contendo a letra 'A' em qualquer parte do nome
select * from administracao.tb_clientes where nome like '%A%';

--9. Nome clientes contendo a letra 'A' ou a letra 'a' em qualquer parte do nome;
select * from administracao.tb_clientes where nome like '%A%' or nome like '%a%';

--10. Selecionando os campos documento, nome, telefone a partir de um ALIAS para a tabela
select c.documento, c.nome, c.telefone from administracao.tb_clientes c;


--11. Selecionando os campos documento, nome, telefone a partir de um ALIAS para a tabela, considerando apenas 
--	os nomes iniciando com 'A' ou 'C'
select c.documento, c.nome, c.telefone from administracao.tb_clientes c
where c.nome like 'A%' or c.nome like 'C%';

--12. Definindo um ALIAS para os campos 
select 
	documento AS CPF, 
	nome AS cliente, 
	telefone AS whatsapp 
from 
	administracao.tb_clientes;
