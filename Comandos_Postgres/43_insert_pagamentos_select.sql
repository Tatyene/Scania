-- Efetuar o pagamento dos eventos contratados por um convidado.
-- Neste exemplo estamos efetuando o pagamento do convidado Julia Dias (id = 3)
insert into administracao.tb_pagamentos (idinscricao, datapgto, valor)
select 
	ins.id as idinscricao, current_date, e.preco
from administracao.tb_inscricoes ins
INNER JOIN administracao.tb_evento e on	e.id = ins.idevento
INNER JOIN administracao.tb_convidado c	on c.id = ins.idconvidado
where c.id = 3;

select * from administracao.tb_pagamentos tp 