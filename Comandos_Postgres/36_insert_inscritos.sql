select * from administracao.tb_evento;
select * from administracao.tb_inscricoes;
select * from administracao.tb_convidado order by id;

-- Efetuando inscrições de convidados em eventos
insert into administracao.tb_inscricoes (idevento, idconvidado, datainscricao)
values 
(1, 1, current_date), (1, 2, current_date), (1, 3, current_date),
(1, 4, current_date), (2, 5, current_date), (2, 6, current_date),
(2, 7, current_date), (2, 8, current_date), (3, 9, current_date),
(3, 13, current_date), (4, 15, current_date), (5, 14, current_date),
(5, 16, current_date), (4, 17, current_date);