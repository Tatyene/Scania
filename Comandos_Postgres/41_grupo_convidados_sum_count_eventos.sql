/*5. Apresentar a lista de participantes (nome, email) e o valor que gastará em eventos.
*/
select 
	c.nome, c.email, count(e.preco) as quant_eventos, sum(e.preco) as valor_gasto
from administracao.tb_inscricoes i
INNER JOIN administracao.tb_evento e on	e.id = i.idevento
INNER JOIN administracao.tb_convidado c	on c.id = i.idconvidado
group by c.nome, c.email;


