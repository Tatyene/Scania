create or replace function administracao.CalcularTotalEventos(idConv integer)
returns decimal(12, 2) as
$$
declare
	valorTotal decimal(12, 2);
	id integer;
begin
	select 
		c.id, sum(e.preco) as valor_gasto
	into
		id, valorTotal
	from administracao.tb_inscricoes i
	INNER JOIN administracao.tb_evento e on	e.id = i.idevento
	INNER JOIN administracao.tb_convidado c	on c.id = i.idconvidado
	where c.id = idConv
	group by c.id;
	
	RETURN valorTotal;
end
$$
language plpgsql;