USE SYSTVENDA20;

# Insert de clientes
INSERT INTO tbl_cliente (cod_cliente, nome_cliente, fk_endereco_cliente, complemento_endereco_cliente) VALUES
  (2, 'ANDRÉ COSTA QUEIROZ', 2, 'proximo ao campo de futebol'),
  (3, 'ARTUR DA GLORIA PASTANA', 3, 'proximo ao campo de futebol'),
  (4, 'AYMMEE NADINE DINIZ NERIS', 4, 'proximo ao campo de futebol'),
  (5, 'BRUNO SOARES DIAS', 5, 'proximo ao campo de futebol'),
  (6, 'BRUNO GONÇALVES BARROS', 6, 'proximo ao campo de futebol'),
  (7, 'CHRISTIANO DE OLIVEIRA BEZERR', 7, 'proximo ao campo de futebol'),
  (8, 'CALEBE DE SOUZA FERREIRA', 8, 'proximo ao campo de futebol'),
  (9, 'DAVID MIRANDA DOS SANTOS NETO', 9, 'proximo ao campo de futebol'),
  (10, 'DOUGLAS DA SILVA SOUSA', 11, 'proximo ao campo de futebol'),
  (11, 'FELIPE DA SILVA RODRIGUES', 10, 'proximo ao campo de futebol'),
  (12, 'FILIPE SALES NUNES', 12, 'proximo ao campo de futebol'),
  (13, 'GABRIEL BRAZÃO DE ALMEIDA', 13, 'proximo ao campo de futebol'),
  (14, 'GABRIEL LAMARÃO DA SILVA COSTA', 14, 'proximo ao campo de futebol'),
  (15, 'GUILHERME DA MOTA CARVALHO', 15, 'proximo ao campo de futebol'),
  (16, 'HERMINIO CARLOS GURGEL MEDEIROS NETTO ', 16, 'proximo ao campo de futebol'),
  (17, 'JOSÉ CLEMER TEIXEIRA PANTOJA', 17, 'proximo ao campo de futebol'),
  (18, 'LEANDRO DE JESUS CAVALCANTE DA SILVA ', 18, 'proximo ao campo de futebol'),
  (19, 'LORENZO LEÃO SANTA BRÍGIDA', 19, 'proximo ao campo de futebol'),
  (20, 'MARCIO PANTOJA PACHECO JUNIOR', 20, 'proximo ao campo de futebol'),
  (21, ' MAIARA PRISCILA LIMA DOS SANTOS ', 21, 'proximo ao campo de futebol'),
  (22, 'MARCO ANTONIO MONTEIRO DE BRITO', 22, 'proximo ao campo de futebol'),
  (23, 'MOISES HOMOBONO NERI BRITO', 23, 'proximo ao campo de futebol'),
  (24, 'PATRÍCIO VÍCTOR MARINHO DIAS', 24, 'proximo ao campo de futebol'),
  (25, 'PAULO VINICIUS RIBEIRO ASSUNÇÃO ', 25, 'proximo ao campo de futebol'),
  (26, 'SELTHON MACELLO CAPIBERIBE SOEIRO', 26, 'proximo ao campo de futebol'),
  (27, ' VITOR HUGO AMANAJAS ROCHA', 27, 'proximo ao campo de futebol'),
  (28, 'RENEY LARANJEIRA CARDOSO', 28, 'proximo ao campo de futebol'),
  (29, 'SERGIO FINAMORE ONIL ', 29, 'proximo ao campo de futebol'),
  (30, 'Jhon Rocha', 30, 'proximo ao campo de futebol');

# Insert Categoria de Produto
INSERT INTO tbl_categoria(cod_categoria, nome_categoria) values
    (default, "salgado"),
    (default, "doce"),
    (default, "bebida"),
    (default, "pizza"),
    (default, "comida Japonesa");
    
  
insert into `tbl_categoria`(cod_categoria, nome_categoria) 
values(default, 'bolos');

insert into `tbl_categoria`(cod_categoria, nome_categoria) 
values(default, 'frutas');
#torta 6
insert into `tbl_categoria` (cod_categoria, nome_categoria) 
values(default, 'torta');

    


# Insert telefone clientes
INSERT INTO tbl_telefone_cliente(COD_TELEFONE_CLIENTE, DDD_TELEFONE_CLIENTE, NUMERO_TELEFONE_CLIENTE, FK_CLIENTE_TELEFONE) values
    (1, "96", "981018721",2),
    (2, "96", "991884121",2),
    (3, "96", "991028321",3),
    (4, "96", "981018721",4),
    (5, "96", "991112221",5),
    (6, "96", "991017777",6),
    (7, "96", "911018721",7),
    (8, "96", "911018721",8),
    (9, "96", "911018721",9),
    (10,"96", "981011721",10),
    (11, "96", "981223721",11),
    (12, "96", "991884121",12),
    (13, "96", "991028321",13),
    (14, "96", "982222721",14),
    (15, "96", "989133221",15),
    (16, "96", "989013777",16),
    (17, "96", "912218711",17),
    (18, "96", "912018722",18),
    (19, "96", "913018722",19),
    (20, "96", "984011722",20),
    (21, "96", "981223721",21),
    (22, "96", "991884121",22),
    (23, "96", "991028321",23),
    (24, "96", "982222721",24),
    (25, "96", "989133221",25),
    (26, "96", "989013777",26),
    (27, "96", "912218711",27),
    (28, "96", "912018722",28),
    (29, "96", "913018722",29),
    (30, "96", "984011722",30);
    
    
insert into `tbl_pagamento` (cod_pagamento, tipo_pagamento) 
values( default, 'Dinheiro');

insert into `tbl_pagamento` (cod_pagamento, tipo_pagamento) 
values( default, 'Cartão');

insert into `tbl_pagamento` (cod_pagamento, tipo_pagamento) 
values( default, 'Transferência');

insert into `tbl_pagamento` (cod_pagamento, tipo_pagamento) 
values( default, 'Pix');

