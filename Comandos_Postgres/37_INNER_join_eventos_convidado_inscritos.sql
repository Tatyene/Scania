select * from administracao.tb_evento;
select * from administracao.tb_inscricoes;
select * from administracao.tb_convidado;
/*Prática:
	1. Apresentar os eventos (descricao, responsavel, data) e seus participantes (nome, email).
*/
select 
	e.descricao, e.responsavel, e.data,	c.nome, c.email
from administracao.tb_inscricoes i
INNER JOIN administracao.tb_evento e on	e.id = i.idevento
INNER JOIN administracao.tb_convidado c	on c.id = i.idconvidado

