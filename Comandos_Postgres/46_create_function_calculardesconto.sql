create function administracao.CalcularDesconto(valor REAL, taxa REAL)
returns REAL AS 
$$
begin
	RETURN valor - valor * taxa / 100;
end
$$
LANGUAGE PLPGSQL;