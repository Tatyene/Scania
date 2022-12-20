-- Copiando o conteúdo do arquivo convidados.txt para a tabela tb_convidado

COPY administracao.tb_convidado (cpf, nome, email)
from 'C:/ProjetoAula/03_PostgreSQL/convidados.csv'
using delimiters ';';