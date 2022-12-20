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
	
	
	
--WHERE - aplicado a linhas, valores individuais
--HAVING - aplicado a um grupo de linhas -- só faz sentido numa instrução group by
-- 	e você só coloca a quantidades de valores do campo
--	precisa ser colocado após o GROUP BY e repetida a instrução de agregação