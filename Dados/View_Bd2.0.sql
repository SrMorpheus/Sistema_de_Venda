Use SYSTVENDA20;

 #view do produto
CREATE  VIEW View_Produto as 
select *from tbl_produto 
INNER JOIN tbl_categoria On
fk_categoria = cod_categoria;

#view do estoque
create view views_estoque as
select  DATE_FORMAT(tbl_estoque.data_estoque, "%d/%m/%Y %H:%i" )     as data_estoque,
	 tbl_estoque.cod_estoque as cod_estoque,
     tbl_produto.cod_produto       as cod_produto,
       tbl_produto.nome_produto       as nome_produto,
       tbl_produto.descricao_produto as descricao,
       tbl_categoria.nome_categoria as Categoria,
       tbl_estoque.quantidade_estoque as quantidade,
       tbl_estoque.preco_estoque      as estoque,
      ( tbl_estoque.quantidade_estoque * tbl_estoque.preco_estoque)  as Total,
		tbl_usuario.cod_usuario     as cod_usuario

from tbl_estoque
         inner join tbl_produto on tbl_estoque.fk_estoque_produto = tbl_produto.cod_produto
         inner join tbl_categoria on tbl_produto.fk_categoria  = tbl_categoria.cod_categoria
         inner join tbl_usuario on tbl_estoque.fk_usuario_estoque = tbl_usuario.cod_usuario
         where      tbl_estoque.ativo_estoque = true;
         
   #view de Historico      
create  view views_historico as
select DATE_FORMAT(tbl_historico.data_historico , "%d/%m/%Y %H:%i" )     as data_historico,
	tbl_historico.tipo_historico     as tipo,
    tbl_produto.nome_produto         as produto,
	tbl_historico.quantidade_produto as quantidade,
	tbl_historico.preco_historico    as preco,
	(tbl_historico.preco_historico  * tbl_historico.quantidade_produto) as Total, 
	tbl_usuario.nome_usuario         as usuario,
    tbl_usuario.cod_usuario         as cod_usuario
   
from tbl_historico
         inner join tbl_produto on tbl_historico.fk_historico_produto = tbl_produto.cod_produto
         inner join tbl_usuario on tbl_historico.fk_usuario_operacao = tbl_usuario.cod_usuario;


#VIEW DE VENDAS
create view view_vendas as
select DATE_FORMAT(tbl_vendas.data_venda, "%d/%m/%Y %H:%i") as data_venda,
		tbl_vendas.cod_venda    as cod_vendas,
       tbl_produto.nome_produto     as produto,
       tbl_vendas.quantidade_venda  as quantidade,
       tbl_vendas.preco_venda       as preco,
	   (tbl_vendas.quantidade_venda *  tbl_vendas.preco_venda) as Total,
       tbl_vendas.observacao_venda  as obeservacao,
        tbl_usuario.cod_usuario     as cod_usuario,
       tbl_usuario.nome_usuario     as usuario_venda,
       tbl_cliente.nome_cliente     as cliente,
      
       tbl_pagamento.tipo_pagamento as tipo_pagamento
from tbl_vendas
         inner join tbl_usuario on tbl_vendas.fk_usuario_venda = tbl_usuario.cod_usuario
         inner join tbl_cliente on tbl_vendas.fk_cliente_venda = tbl_cliente.cod_cliente
         inner join tbl_produto on tbl_vendas.fk_produto_venda = tbl_produto.cod_produto
         inner join tbl_pagamento on tbl_vendas.fk_pagamento = tbl_pagamento.cod_pagamento;

#view de usuario
create view view_usuario as
select tbl_usuario.nome_usuario as nome,
       tbl_usuario.nome_empresa as empresa,
       tbl_usuario.cpf_usuario as cpf,
       tbl_usuario.data_nascimento as data_nascimento,
       tbl_usuario.email_usuario as email,
       tbl_rua.nome_rua as endereco,
       tbl_usuario.complemento_endereco
from tbl_usuario inner join tbl_rua on tbl_usuario.fk_endereco = tbl_rua.cod_rua;



