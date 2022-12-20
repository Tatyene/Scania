/*3. Apresentar os eventos (descricao) e o valor total arrecadado por evento.
*/

select 
	e.descricao, sum(e.preco) as Valor_total
from administracao.tb_inscricoes i
INNER JOIN administracao.tb_evento e on	e.id = i.idevento
INNER JOIN administracao.tb_convidado c	on c.id = i.idconvidado
group by e.descricao