-- Incluir evento pelo evento.csv
COPY administracao.tb_evento (id, descricao, responsavel, preco, data)
from 'C:/ProjetoAula/03_PostgreSQL/evento.csv' 
using delimiters ';';