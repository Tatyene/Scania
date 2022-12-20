/*
	UNION permite a consulta conjunta de duas ou mais tabelas que tenham correspondência
	entre as colunas (mesmo número e mesmo tipo).
*/
select documento as CPF, nome, telefone as contato from administracao.tb_clientes
UNION
select cpf, nome, email from administracao.tb_convidado;