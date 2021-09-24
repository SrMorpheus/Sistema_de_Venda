    USE  SYSTVENDA20;



#Gatilhos para inserts automaticos nas tabelas login e historico

#gatilho para insert na tabela
DELIMITER $
CREATE TRIGGER trigger_login AFTER INSERT ON
tbl_usuario FOR EACH ROW
BEGIN

INSERT INTO tbl_Login ()  VALUES (default, new.cpf_usuario, new.cpf_usuario, MD5(new.cpf_usuario), new.cod_usuario);

END$
DELIMITER ;


#gatilho para insert na tabela historico toda vez que tiver uma entrada
DELIMITER $
CREATE TRIGGER trigger_historico_entrada AFTER INSERT ON
tbl_entrada_produto FOR EACH ROW
BEGIN
INSERT INTO tbl_historico () VALUES (default, new.data_entrada, new.fk_entrada_produto, new.quantidade_entrada, new.preco_entrada, new.fk_entrada_usuario, "Entrada de Produtos");

END$
DELIMITER ;

#gatilho para inserir informação de vendas no historico;
DELIMITER $
CREATE TRIGGER trigger_historico_vendas BEFORE INSERT ON
tbl_vendas FOR EACH ROW
BEGIN

INSERT INTO tbl_historico () VALUES (default, new.data_venda, new.fk_produto_venda, new.quantidade_venda, new.preco_venda, new.fk_usuario_venda, "Venda de Produtos");

END$

#Gatilho para deixa senha criptografada quando for mudar ela :
 DELIMITER $
 CREATE   TRIGGER trg_mudar_senha before update on tbl_login
 FOR EACH ROW 
 begin
SET new.senha = md5(new.senha);
 END$
DELIMITER ;


#GATILHO QUE INSERT NOVOS PRODUTOS NO ESTOQUE E DA UPDATE NA QUANTIDADE E DATA
DELIMITER $$
CREATE    TRIGGER TRIGGER_ESTOQUE_ENTRADA before INSERT 
ON  tbl_entrada_produto FOR EACH ROW
BEGIN


if((Select count(1) from tbl_estoque where fk_estoque_produto = new.fk_entrada_produto AND  preco_estoque = new.preco_entrada AND  fk_usuario_estoque = new.fk_entrada_usuario AND ativo_estoque = true) = 1) THEN
UPDATE tbl_estoque set quantidade_estoque = quantidade_estoque + new.quantidade_entrada,  data_estoque = new.data_entrada where fk_estoque_produto = new.fk_entrada_produto AND  preco_estoque = new.preco_entrada AND  fk_usuario_estoque = new.fk_entrada_usuario;

elseif ((Select count(1) from tbl_estoque where fk_estoque_produto = new.fk_entrada_produto AND  preco_estoque = new.preco_entrada AND  fk_usuario_estoque = new.fk_entrada_usuario   AND ativo_estoque = true) >= 1) then 
INSERT INTO tbl_estoque() VALUES (default, new.data_entrada, new.fk_entrada_produto, new.quantidade_entrada, new.preco_entrada, new.fk_entrada_usuario, true);

else  INSERT INTO tbl_estoque() VALUES (default, new.data_entrada, new.fk_entrada_produto, new.quantidade_entrada, new.preco_entrada, new.fk_entrada_usuario, true);

end if;
end$$


#GATILHO que da update na data e na quantidade do estoque
DELIMITER $$
CREATE   TRIGGER TRIGGER_ESTOQUE_VENDA before INSERT 
ON  tbl_vendas FOR EACH ROW
BEGIN


if((Select count(1) from tbl_estoque where fk_estoque_produto = new.fk_produto_venda AND fk_usuario_estoque = new.fk_usuario_venda and preco_estoque = new.preco_venda and quantidade_estoque >0) = 1) THEN
UPDATE tbl_estoque set quantidade_estoque = quantidade_estoque - new.quantidade_venda,  data_estoque = new.data_venda where fk_estoque_produto = new.fk_produto_venda AND fk_usuario_estoque = new.fk_usuario_venda and preco_estoque = new.preco_venda and quantidade_estoque >0;

end if;
end$$



#Gatilho para mostrar produto alterado ou exluido da tabela estoque

DELIMITER $$
CREATE   TRIGGER TRIGGER_ESTOQUE_update after  update
ON  tbl_estoque
 FOR EACH ROW
BEGIN
declare produto_estoque int(11);
declare quantidade int(11);
declare preco decimal(10,2);
declare usuario int(11);

 select fk_estoque_produto, quantidade_estoque, preco_estoque, fk_usuario_estoque  into produto_estoque, quantidade, preco,usuario from tbl_estoque where cod_estoque = old.cod_estoque;


if new.ativo_estoque = false then


INSERT INTO tbl_historico () VALUES (default, current_timestamp() , produto_estoque, quantidade, preco, usuario, "Exclusão de Produtos");

elseif(new.ativo_estoque != false) then
INSERT INTO tbl_historico () VALUES (default, current_timestamp() , produto_estoque, quantidade, preco, usuario, "Alteração de Produtos");


end if;
end$$

