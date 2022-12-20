-- Esta função possui propósito geral, e por isso será colocada em um schema separado
create function funcoes.calcularSoma(REAL, REAL)
RETURNS REAL AS 
$$
BEGIN
	RETURN $1 + $2;
END
$$
LANGUAGE PLPGSQL;