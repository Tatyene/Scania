/*
	VIEWS - uma instrução SQL, só que armazenada, um script, e não armazena
	usadas para condensar resultados de consultas em um único objeto
	Funciona como uma tabela virtual porém não é. Faz esse papel, mas não é.
	É como se vc pegasse uma instrução SQL e colocasse numa função.
*/

CREATE OR REPLACE VIEW financeiro.view_faturas AS 
select
	c.documento, c.nome, sum(f.valor) as total, COUNT(f.valor) as qtde_faturas
from
	administracao.tb_clientes c INNER JOIN financeiro.tb_faturas f
on
	c.id = f.idcliente
GROUP BY
	c.documento, c.nome
HAVING
	COUNT(f.valor) > 1
ORDER BY 
	c.documento;