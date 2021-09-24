
	CREATE    DATABASE SYSTVENDA20;
    
    USE  SYSTVENDA20;
    
    #Tabela usuario que vai acessar nosso sistema (lembrando o usuario aqui é o vendedor )
    
	CREATE TABLE `tbl_usuario` (
    cod_usuario INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    nome_usuario VARCHAR(90) NOT NULL ,
    nome_empresa VARCHAR (90) NOT NULL,
    cpf_usuario VARCHAR(11) NOT NULL,
    data_nascimento DATE NOT NULL ,
    email_usuario VARCHAR(90) NOT NULL,
    fk_endereco INT(11) NOT NULL ,
    complemento_endereco VARCHAR(45),
    ativo_user BOOL NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
 
    #tabela login para entrar no sistema ela é prenchida atráves de um gatilho 
    
    CREATE TABLE `tbl_login`(
    cod_login INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
	cpf_login VARCHAR(11) NOT NULL,
    Login VARCHAR(90) NOT NULL,
    senha VARCHAR(90) NOT NULL,
    fk_usuario INT(11) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    
    #tabela cliente que é preenchida atráves da api do wpp
    CREATE TABLE `tbl_cliente`(
    cod_cliente INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    nome_cliente VARCHAR(90) NOT NULL,
    fk_endereco_cliente INT(11) NOT NULL,
    complemento_endereco_cliente VARCHAR(45)
    )engine = InnoDB default charset = utf8mb4;
    
    #tabelas endereços que apenas informação do bloco, rua , numero bloco o complemento ficar na tabela cliente e usuario
    
    CREATE TABLE `tbl_bloco`(
    cod_bloco INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    nome_bloco VARCHAR(90) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    
    CREATE TABLE `tbl_rua` (
    cod_rua INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    nome_rua VARCHAR(90) NOT NULL,
    fk_bloco INT(11) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    
    #tabelas para telefone do usuario e cliente
    
    CREATE TABLE `tbl_telefone_usuario`(
    cod_telefone_usuario INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    ddd_telefone_usuario  VARCHAR(2) NOT NULL,
    numero_telefone_usuario  VARCHAR(9) NOT NULL,
    fk_usuario_telefone INT(11) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
	CREATE  TABLE `tbl_telefone_cliente`(
    cod_telefone_cliente INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    ddd_telefone_cliente  VARCHAR(2) NOT NULL,
    numero_telefone_cliente  VARCHAR(9) NOT NULL,
    fk_cliente_telefone INT(11) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
     


    #tabela prdouto aqui usuariuo faz cadastro dos produtos que vai vender 
    CREATE TABLE  `tbl_produto`(
    cod_produto INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    nome_produto VARCHAR(50) NOT NULL,
    descricao_produto VARCHAR(90) ,
    fk_categoria INT(11) NOT NULL,
    ativo_produto BOOL NOT NULL,
    fk_usuario_produto  INT(11) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    
    CREATE TABLE `tbl_categoria`(
    cod_categoria INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    nome_categoria VARCHAR(50) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    
    #tabela responsavel pelo cadrasto de entrada dos produtos
    CREATE TABLE `tbl_entrada_produto`(
    cod_entrada INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    data_entrada timestamp not null default current_timestamp ,
    fk_entrada_produto INT(11) NOT NULL,
    preco_entrada DECIMAL(10,2) NOT NULL,
    quantidade_entrada INT(11) NOT NULL,
    fk_entrada_usuario INT(11) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    #tabela responsavel pelas vendas dos produots das vendas do usuario para cliente 
    CREATE TABLE `tbl_vendas`(
    cod_venda  INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    fk_usuario_venda INT(11) NOT NULL,
    fk_cliente_venda INT(11) NOT NULL,
    data_venda  timestamp not null default current_timestamp,
    fk_produto_venda INT(11) NOT NULL,
	quantidade_venda INT(11) NOT NULL,
    preco_venda DECIMAL(10,2) NOT NULL,
    fk_pagamento INT(11) NOT NULL,
    observacao_venda VARCHAR(90) 
    )engine = InnoDB default charset = utf8mb4;
    
    CREATE TABLE `tbl_pagamento` (
    cod_pagamento INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    tipo_pagamento VARCHAR(90)  NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    #tabela responsavel pelo controle de entrada e venda de produto por usuario
    CREATE TABLE `tbl_historico` (
    cod_historico INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    data_historico DATETIME NOT NULL,
    fk_historico_produto INT(11) NOT NULL,
    quantidade_produto INT(11) NOT NULL,
	preco_historico DECIMAL (10,2),
    fk_usuario_operacao INT(11) NOT NULL,
    tipo_historico VARCHAR(90)NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    
	CREATE TABLE `tbl_estoque` (
    cod_estoque INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    data_estoque DATETIME NOT NULL,
    fk_estoque_produto INT(11) NOT NULL,
    quantidade_estoque INT(11) NOT NULL,
	preco_estoque DECIMAL (10,2),
    fk_usuario_estoque INT(11) NOT NULL,
    ativo_estoque BOOL NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    
    

    
    # fazendo os fks das tabelas (obs não mexa pfv - apenas pessoas autorizadas)
    
    ALTER TABLE `tbl_usuario`
    ADD CONSTRAINT FK_endereco
	FOREIGN KEY(fk_endereco) REFERENCES `tbl_rua` (cod_rua);
    
	ALTER TABLE `tbl_login`
    ADD CONSTRAINT FK_usuario
	FOREIGN KEY(fk_usuario) REFERENCES `tbl_usuario` (cod_usuario);
    
	ALTER TABLE `tbl_cliente`
    ADD CONSTRAINT FK_endereco_cliente
	FOREIGN KEY(fk_endereco_cliente) REFERENCES `tbl_rua` (cod_rua);
    
    ALTER TABLE `tbl_telefone_usuario`
    ADD CONSTRAINT FK_usuario_telefone
	FOREIGN KEY(fk_usuario_telefone) REFERENCES `tbl_usuario` (cod_usuario);
    
  
    ALTER TABLE `tbl_telefone_cliente`
    ADD CONSTRAINT FK_cliente_telefone
	FOREIGN KEY(fk_cliente_telefone) REFERENCES `tbl_cliente` (cod_cliente);
    
	ALTER TABLE `tbl_entrada_produto`
    ADD CONSTRAINT FK_entrada_produto
	FOREIGN KEY(fk_entrada_produto) REFERENCES `tbl_produto` (cod_produto);
    
    ALTER TABLE `tbl_entrada_produto`
    ADD CONSTRAINT FK_entrada_usuario
	FOREIGN KEY(fk_entrada_usuario) REFERENCES `tbl_usuario` (cod_usuario);
    
	ALTER TABLE `tbl_produto`
    ADD CONSTRAINT FK_categoria
	FOREIGN KEY(fk_categoria) REFERENCES `tbl_categoria` (cod_categoria);
    
	ALTER TABLE `tbl_produto`
    ADD CONSTRAINT FK_usuario_produto
	FOREIGN KEY(fk_usuario_produto) REFERENCES `tbl_usuario` (cod_usuario);
    
    
    ALTER TABLE `tbl_rua`
    ADD CONSTRAINT FK_bloco
	FOREIGN KEY(fk_bloco) REFERENCES `tbl_bloco` (cod_bloco);
    
	ALTER TABLE `tbl_vendas`
    ADD CONSTRAINT FK_usuario_venda
	FOREIGN KEY(fk_usuario_venda) REFERENCES `tbl_usuario` (cod_usuario);
    
	ALTER TABLE `tbl_vendas`
    ADD CONSTRAINT FK_cliente_venda
	FOREIGN KEY(fk_cliente_venda) REFERENCES `tbl_cliente` (cod_cliente);
    
	ALTER TABLE `tbl_vendas`
    ADD CONSTRAINT FK_produto_venda
	FOREIGN KEY(fk_produto_venda) REFERENCES `tbl_produto` (cod_produto);
    
    
	ALTER TABLE `tbl_vendas`
    ADD CONSTRAINT FK_pagamento
	FOREIGN KEY(fk_pagamento) REFERENCES `tbl_pagamento` (cod_pagamento);
    
    
    ALTER TABLE `tbl_historico`
    ADD CONSTRAINT FK_historico_produto
	FOREIGN KEY(fk_historico_produto) REFERENCES `tbl_produto` (cod_produto);
    
      
    ALTER TABLE `tbl_historico`
    ADD CONSTRAINT FK_usuario_operacao
	FOREIGN KEY(fk_usuario_operacao) REFERENCES `tbl_usuario` (cod_usuario);
    
    
        
    ALTER TABLE `tbl_estoque`
    ADD CONSTRAINT FK_estoque_produto
	FOREIGN KEY(fk_estoque_produto) REFERENCES `tbl_produto` (cod_produto);
    
	ALTER TABLE `tbl_estoque`
    ADD CONSTRAINT FK_usuario_estoque
	FOREIGN KEY(fk_usuario_estoque) REFERENCES `tbl_usuario` (cod_usuario);
    
    
    
    
   
    
    
    
    
    
    
    
    
    
    