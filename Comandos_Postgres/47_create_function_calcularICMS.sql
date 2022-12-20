--Esta é uma função de propósito geral, cujo objetivo é determinar o valor 
-- do icms do produto

create or replace function funcoes.CalcularICMS(preco decimal(12, 2))
returns decimal(12,2) as 
$$
declare
	icms decimal(12, 2);
	valorImposto decimal (12, 2);
begin
	icms := 18;
	valorImposto := preco * icms / 100;
	return valorImposto;
end
$$
language plpgsql;