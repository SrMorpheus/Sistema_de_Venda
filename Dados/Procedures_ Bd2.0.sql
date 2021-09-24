    USE  SYSTVENDA20;

#procedure para resetar a senha do login para padrãO;

DELIMITER $$
CREATE  PROCEDURE Procedure_Resetar (IN email varchar(90), IN cpf varchar(90) )
BEGIN

DECLARE var int;
DECLARE varcpf varchar(90);

SELECT cod_usuario, cpf_usuario into var, varcpf  from tbl_usuario , tbl_login where email_usuario = email and cpf_usuario = cpf and cpf_login =  cpf;

UPDATE tbl_login set senha = varcpf where fk_usuario = var;

END $$
  DELIMITER ;
  
  #Procedure de alterar senha
  DELIMITER $$
CREATE  PROCEDURE Procedure_alterar_senha ( in usuario int , in senha_atual varchar(90), in  senha_nova varchar(90))

If ((Select count(1) from tbl_login where fk_usuario = usuario and senha = Md5(senha_atual)) = 1 ) then
update tbl_login  set senha = senha_nova where fk_usuario = usuario;

end if;
END $$
  DELIMITER ;

