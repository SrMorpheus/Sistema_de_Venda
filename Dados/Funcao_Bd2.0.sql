    USE  SYSTVENDA20;

#função de valida cpf retornando a bool
DELIMITER $
CREATE FUNCTION fn_cpf_validar(cpf VARCHAR(20))
RETURNS BOOL

BEGIN

DECLARE retorno bool;

IF ((SELECT count(1)from tbl_usuario WHERE cpf_usuario = cpf ) >= 1) THEN SET retorno = true;

ELSE SET retorno = FALSE ;
END IF;

RETURN RETORNO ;

END$
DELIMITER ;


#função de valida email retornando a bool
DELIMITER $
CREATE FUNCTION fn_email_validar(email VARCHAR(90))
RETURNS BOOL

BEGIN

DECLARE retorno bool;

IF ((SELECT count(1)from tbl_usuario WHERE email_usuario = email ) >= 1) THEN SET retorno = true;

ELSE SET retorno = FALSE ;
END IF;

RETURN RETORNO ;

END$
DELIMITER ;



#função valida cpf retornando a um texto
DELIMITER $
CREATE FUNCTION fn_cpf_validar_texto(cpf VARCHAR(20))
RETURNS varchar(100)
BEGIN

DECLARE retorno varchar(100);

IF ((SELECT count(1)from tbl_usuario WHERE cpf_usuario = cpf ) = 1) THEN SET retorno = "ESSE CPF JA EXISTE NO BANCO DE DADOS";

ELSEIF ((SELECT count(1)from tbl_usuario WHERE cpf_usuario = cpf ) > 1 ) THEN SET retorno = "ESSE CPF JA ESTÁ DUPLICADO NO BANCO DE DADOS, AVISE O ADMINISTARDOR " ;

ELSE SET RETORNO = "ESSE CPF NÃO EXISTE NO BANCO DE DADOS";

END IF;

RETURN RETORNO ;

END$
DELIMITER ;

#FUNÇÃO PARA VALIDAR ENTRADA
DELIMITER $
CREATE  FUNCTION Fn_Valida_entrada(login varchar(50), password2 varchar(50)) 
RETURNS BOOL
BEGIN
    DECLARE RETORNO Bool;
	IF ((SELECT count(1) from tbl_login where cpf_login = login and Login = login and senha = Md5(password2)) = 1) THEN
       SET RETORNO = TRUE;
	ELSE SET RETORNO = FALSE;
	   END IF;
       RETURN RETORNO ;
	END$
DELIMITER ;



#cRIAÇÃO DE FUNÇÃO PARA VALIDAR ANTES DE RESETAR A SENHA PARA PADRÃO

DELIMITER $
CREATE FUNCTION fn_Valida_senha_resetar(email varchar(90),  cpf varchar(90))
RETURNS BOOL
 BEGIN

DECLARE RETORNO BOOL;
 
 IF ((SELECT count(1)  from tbl_usuario , tbl_login where email_usuario = email and cpf_usuario = cpf and cpf_login =  cpf) = 1) THEN 
 SET RETORNO  = TRUE;
 
 ELSE SET RETORNO = FALSE;
END IF;
 
 RETURN RETORNO;
 
 END$


#Função de   alterar a senha 
DELIMITER $
CREATE  FUNCTION fn_alterar_senha( usuario int , senha_atual varchar(90))
Returns bool
Begin
DECLARE RETORNO BOOL;

If ((Select count(1) from tbl_login where fk_usuario = usuario and senha = Md5(senha_atual)) = 1 ) then


SET RETORNO = TRUE ; 

ELSE SET RETORNO = FALSE;

END IF;

RETURN RETORNO;
End $
