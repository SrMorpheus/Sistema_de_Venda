    USE  SYSTVENDA20;


/*CREATE TABLE `tbl_bloco`(
    cod_bloco INT(11) PRIMARY KEY  NOT NULL AUTO_INCREMENT,
    nome_bloco VARCHAR(90) NOT NULL
    )engine = InnoDB default charset = utf8mb4;
    */
	# Departamento de Ciências e Tecnologias 
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'DCET');
    
    #Rua principal---------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, '1.1 Via Principal: DCET e Bloco de Eng. Civil', 1);
    
    
    
    # Departamento de Artes visuais, letras e jornalismo 
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'DEPLA');
    
    #Rua principal--------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, '1.2 Via Principal: Passarela entre DEPLA e DCET', 2);
    
    
    
    # Meio ambiente e desenvolvimento
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de Ciências ambientais');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
	values(default, 'Rua principal: bloco de ciências ambientais', 3);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '2.5 Passarela entre Ciências ambientais, lab. e bloco de física e lab. de biológicas.', 3);
    
    
    
    #Bloco de educação física
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de educação física');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Ao lado da piscina e atrás do lab. de educação física', 4);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.3 V.P passarela entre bloco de educação física e laboratório', 4);
    
    
    
    # arena universitaria
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'arena universitaria');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, de frente com o DCET e ao lado do Hospital universitário', 5);
    
    
    
    # Física
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de Física');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'De frente com o NTI, ao lado do bloco de ciências ambientais e perto da caixa de água', 6);
    
    
    
    # Secretariado executivo
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de Secretariado executivo');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás da biblioteca central e atrás do bloco das coordenações', 7);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '2.1 Passarela: Blocos: F, G, I, K, H e J', 7);
    
    
    
    # administração
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de administração');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás da biblioteca central, entre os labs. de geografia e robótica', 8);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '2.2 Passarela: Blocos: L, M, N, O e P', 8);
    
    
    
    # Ateliê de arquitetura
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Ateliê de arquitetura');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás do bloco de administração, entre PPGMDR e Matemática', 9);
    
    
    
    # matemática
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de matemática');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás do lab. de robótica, entre Ateliê de arquitetura e o bloco de História', 10);
    
    
    
    # História
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de História');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás do bloco de direito, entre o bloco de matemática e Enfermagem', 11);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '2.3 Passarela: Blocos: R, Q, S e T', 11);
    
    
    
    # Direito
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de Direito');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'A frente do bloco de história e do lado do lab. de robótica', 12);
    
    
    
    # enfermagem
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de enfermagem');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Entre o bloco de história e PPGBIO', 13);
    
    
    
    # bloco de coordenação
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de coordenação');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, entre a prefeitura e a biblioteca central', 14);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.8 Via Principal: Blocos: A, B, C, Biblioteca central, bloco das coordenações e prefeitura.', 14);
    
    
    
    # pedagogia
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de pedagogia');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, entre o juizado especial e o bloco de ciências sociais', 15);
    
    
    
    # ciências sociais
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'bloco de ciências sociais');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, Entre o bloco de pedagogia e a biblioteca central', 16);
    
    
    
    # garagem central
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'garagem central');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, entre o DEPLA e o almoxarifado central', 17);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.4 Via Principal: Almoxarifado, garagem central e deposito.', 17);
    
    
    
    # Almoxarifado central
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Almoxarifado central');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, entre a garagem central e o bloco de ciências ambientais, de frente com a piscina.', 18);
    
    # Rua auxiliar-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, '1.17 Via Principal: Passarela: Entre almoxarifado e area de resenha/Caixa Santander.', 18);
    
    
    
    # Depósito
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Depósito');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás do bloco de ciências ambientais, na rua lateral entre o almoxarifado e a garagem central', 19);
    
    
    
    # Lab. Educação física
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Lab. Educação física');
    
    # Rua principal--------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal: Lab. Educação física de frente com a garagem', 20);
    
    # Rua auxiliar--------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, '1.6 Passarela Lab. e Bloco de Educação física, ginásio e piscina.', 20);
    
    
    
    # Piscina Universitária
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Piscina Universitária');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, entre o laboratório/bloco de ed. Física e o Ginásio', 21);
    
    
    
    # Ginasio/vestiario/W.C./Cantina
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Ginásio/vestiario/W.C./Cantina');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, de lado com o DERCA e do lado da piscina', 22);
    
    
    
    # Caixa Santander/Area de resenha
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Caixa Santander');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, dentro da Reitoria, na parte de trás.', 23);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.16 Via Principal: Passarela C.V Centro de vivência e agência santander', 23);
    
    
    
    # Lab. de Física
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Lab. de Física');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Entre o bloco de de física e o de ciências ambientais', 24);
    
    
    
    # Lab. Biológicas perto do lab. de física
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Lab. Biológicas');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Ao lado do bloco de física perto da caixa de água', 25);
    
    
    
    # DEPSEC
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'DEPSEC');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, entre o DERCA e o caixa santander/Area de resenha.', 26);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.5 Via Principal: Passarela: Derca e Depsec', 26);
    
    
    
    # DERCA
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'DERCA');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua Principal, do lado do ginásio', 27);
    
    
    
    # Adm. DCET
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Adm. DCET');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Ao lado do DERCA, na frente do NTI e de frente com o bloco de física', 28);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.7 Passarela: NTI, caixa dágua, bloco de física e CBIO', 28);
    
    
    
    # NTI
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'NTI');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na frente da Adm. do DCT, do lado da prefeitura e perto da caixa de água', 29);
    
    
    
    # Prefeitura
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Prefeitura');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, entre o bloco das coordenações e o NTI', 30);
    
    
    
    # Ciências Biológicas
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Ciências biologicas');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás do NTI, entre o CBIO e o Lab. de Biológicas', 31);
    
    
    
    # Lab. de Biológicas perto de ciências biológicas
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Lab. Biológicas');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás da prefeitura, entre o bloco de secretariado e o bloco de biológicas', 32);
    
    
    
    # Laab e Lab. Biológicas
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Laab e Lab. Biológicas');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'atrás do bloco de secretariado, entre o lab. de Biológicas e o PPGMDR', 33);
    
    
    
    # PPGGMDR
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'PPGGMDR');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás do lab. de geografia e entre o Ateliê de arquitetura e o Laab e Lab. Biológicas', 34);
    
    
    
    # Lab. de Enfermagem
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Lab. de Enfermagem');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás da bibiloteca central, na frente do bloco de administração', 35);
    
    
    
    # Lab. Robótica
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Lab. Robótica');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás da biblioteca central, entre o bloco de administração e o bloco de direito', 36);
    
    
    
    # PPGBIO
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'PPGBIO');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Ao lado do bloco de enfermagem, último bloco atrás da biblioteca central', 37);
    
    
    
    # Centros academicos
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Centros academicos');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Do lado do bloco de geografia e da Cantina/xerox/W.C.', 38);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '2.4 Passarela: blocos: 14, D e E', 38);
    
    
    
    # Xerox/Cantina/W.C.
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Xerox/Cantina/W.C.');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás do juizado especial e o bloco de pedagogia, entre o bloco de geografia e o centro academico', 39);
    
    
    
    # Juizado especial
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Juizado especial');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Entre a rádio e o bloco de pedagogia, na rua principal.', 40);
    
    
    
    # Biblioteca Central
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Biblioteca Central');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, entre o bloco das coordenações e o bloco de ciências sociais, na frente do banco santander', 41);
    
    
    
    # Bloco das coordenações
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Bloco das coordenações');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, entre a prefeitura e o biblioteca central', 42);
    
    
    
    # Reitoria
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Reitoria');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, na frente do anfiteatro(Colisseu), ao lado do estácionamento, na frente do Derca e da prefeitura', 43);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.15 Via Principal: Passarela: reitoria, caixa do banco do Brasil, gestão de pessoas e CEPAP', 43);
    
    
    
    # Caixa Banco do Brasil
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Caixa Banco do Brasil');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na parte de trás da reitoria', 44);
    
    
    
    # Anfiteatro (Colisseu) 
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Anfiteatro (Colisseu)');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás da reitoria, do estácionamento e ao lado do CEPAP.', 45);
    
    
    
    # CEPAP
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'CEPAP');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Ao lado do anfiteatro(Colisseu) e atrás do estácionamento', 46);
 
 
 
    # Agência Santander/C.V. Centro de vivência
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Agência Santander/C.V. Centro de vivência');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Entre o restaurante, o centro de gestão de pessoas, a reitoria e o anfiteatro(Colisseu)', 47);
    
    
    
    # Gestão de pessoas
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Gestão de pessoas');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, atrás da reitoria, entre o anfiteatro(Colisseu) e o Centro de vivência', 48);
    
    
    
    # Restaurante(R.U)
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Restaurante(R.U)');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na frente do CIPPG(Bloco Aranha), na rua principal', 49);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.9 Via Principal: Restaurante (R.U)', 49);
    
    
    
    # CIPPG (Bloco Aranha)
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'CIPPG (Bloco Aranha)');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, de frente com o restaurante(R.U)', 50);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.10 Via Principal: Passarela: Auditório aranha, CEPA e Bloco de pós-graduação.', 50);
    
    
    
    # CEPA
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'CEPA');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Entre o CIPPG(Bloco Aranha) e o bloco de pós-graduação, na rua principal', 51);
    
    
    
    # Pós-Gradução
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Pós-Gradução');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, na frente da Rádio Universitária', 52);
    
    
    
    # Rádio Universitária
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Rádio Universitária');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, de frente com o bloco de pós-graduação, do lado do juizado especial.', 53);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.11 Via Principal: Passarela: Entre a rádio universitária e o Lab. de informatica básica.', 53);
    
    
    
    # Lab. UNIFAP DIGITAL e Lab. Ciências Sociais
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Lab. UNIFAP DIGITAL e Lab. Ciências Sociais');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, de lado com a rádio universitária e PROEAC', 54);
    
    
    
    # PROEAC
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'PROEAC');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, entre UMAP e o Lab. UNIFAP DIGITAL e Lab. Ciências Sociais', 55);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.12 Via Principal: Passarela: entre PROEAC e UMAP', 55);
    
    
    
    # UMAP
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'UMAP');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Atrás do PROEAC, na rua principal', 56);
    
    
    
    # Fisioterapia
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Fisioterapia');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, do lado do bloco de Medicina/Farmacia', 57);
    
    
    
    # Medicina/Farmacia
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Medicina/Farmacia');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Na rua principal, ao lado da UBS-Unifap e de frente com o ambulatório', 58);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.13 Via Principal: Passarela: Entre bloco de fisioterapia, medicina, enfermagem e UBS-Unifap', 58);
    
    
    
    # Ambulatórios
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Ambulatórios');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principal, de frente com o bloco de Medicina/Farmacia e ao lado do laboratório', 59);
    
    #Rua Auxiliar----------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco)
    values (default, '1.14 Via Principal: Passarela: Ambulatório e Laboratório.', 59);
    
    
    
    # UBS-Unifap
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'UBS-Unifap');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua principa, do lado do bloco de medicina/farmacia e de frente para o laboratório', 60);
    
    
    
    # Laboratório
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'Laboratório');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'de frente com a UBS-Unifap ao lado do ambulatório', 61);
    
    
    
    # práticas pedagogicas
    insert into `tbl_bloco` (cod_bloco, nome_bloco) values(default, 'práticas pedagogicas');
    
    # Rua principal-------------------------------------
    insert into `tbl_rua` (cod_rua, nome_rua, fk_bloco) 
    values(default, 'Rua externa, escolinha da unifap', 62);
    
  