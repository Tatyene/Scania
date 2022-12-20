select * from administracao.tb_clientes; 

-- Alterar um email que esteja supostamente errado

update administracao.tb_convidado set email = 'isabel@gmail.com' where id = 7;  