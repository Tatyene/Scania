--Criando uma tebela chamada tb_cartões no schema admininstracao
CREATE TABLE administracao.tb_cartoes (
	ID serial 				not null PRIMARY KEY,
	numcartao char(16) 		not null check(length(numcartao)=16),
	limite decimal(12, 2) 	not null check(limite >= 1000 and limite <= 5000)
	
)