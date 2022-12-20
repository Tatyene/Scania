/*4. Apresentar os eventos (descricao), a quantidade e o valor total arregadado.
*/
select 
	e.descricao, count(c.id) as quant_convidados, sum(e.preco) as valor_total
from administracao.tb_inscricoes i
INNER JOIN administracao.tb_evento e on	e.id = i.idevento
INNER JOIN administracao.tb_convidado c	on c.id = i.idconvidado
group by e.descricao




