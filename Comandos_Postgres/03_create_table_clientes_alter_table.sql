--Criando a tabela tb_clientes no schema adminstracao
CREATE TABLE tb_clientes (
	documento char(14) 		not null,
	nome varchar(100) 		not null,
	telefone char(12) 		not null,
	endereco varchar(100),
	uf char(2)				default 'SP',
	status boolean			default TRUE	
);

--Tabela criada no schema errado!Vamos movê-la para administracao
--ALTER TABLE: produz alterações na estrutura da tabela, não no registro da tabela
alter table tb_clientes set schema administracao;
--se fosse o contrário seria alter table adminstracao.tb_clientes set schema public;

--Faltou a chave primária. Vamos adicioná-la
alter table administracao.tb_clientes add column id serial not null primary key;

-- o documento deve ter OU 11 OU 14 digítos
alter table administracao.tb_clientes
add constraint chk_tamanho_documento check(length(trim(documento)) = 11 or length(trim(documento)) = 14);

--o documento deve ser exclusivo
alter table administracao.tb_clientes 
add constraint unq_documento_exclusivo unique(documento);