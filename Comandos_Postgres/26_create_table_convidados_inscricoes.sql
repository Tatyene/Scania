alter table tb_evento set schema administracao;

create table administracao.tb_convidado (
	id 		serial 		not null primary key,
	cpf 	char(11) 	not null check(length(cpf) = 11), --, unique(cpf),
	nome 	varchar(60) not null,
	email 	varchar(60) not null
);

alter table administracao.tb_convidado
add constraint unq_cpf_exclusivo unique(cpf);

create table administracao.tb_inscricoes (
	id 				serial 	not null primary key,
	idEvento 		integer not null,
	idConvidado 	integer not null,
	dataInscricao 	date 	not null,
	foreign key(idEvento) references administracao.tb_evento(id),
	foreign key(idConvidado) references administracao.tb_convidado(id)
);