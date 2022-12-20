/*2. Apresentar os eventos (descricao) e a quantidade de participantes por evento.
*/
select 
	e.descricao, count(c.id) as quant_convidados
from administracao.tb_inscricoes i
INNER JOIN administracao.tb_evento e on	e.id = i.idevento
INNER JOIN administracao.tb_convidado c	on c.id = i.idconvidado
group by e.descricao;