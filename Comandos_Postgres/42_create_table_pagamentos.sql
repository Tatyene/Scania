-- Criando a tabela tb_pagamentos, associada a tabela tb_inscricoes

create table administracao.tb_pagamentos
(
	id serial not null primary key,
	idinscricao integer not null,
	datapgto date not null,
	valor decimal(12, 2),
	foreign key(idinscricao) references administracao.tb_inscricoes(id)
);

-- Tornar a chave estrangeira um campo exclusivo (idinscricao)
alter table administracao.tb_pagamentos
add constraint cmp_idinstricao_unique unique(idinscricao);