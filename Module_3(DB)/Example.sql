CREATE TABLE aluno (
    matricula NUMBER,
    nome      varchar(200),
    sexo      CHAR(1),
    data_nasc DATE
);

DROP TABLE aluno

CREATE TABLE aluno (
    matricula NUMBER
        CONSTRAINT unn_aluno_matricula NOT NULL
    UNIQUE,
    nome      VARCHAR(200)
        CONSTRAINT nn_aluno_nome NOT NULL,
    sexo      CHAR(1)
        CONSTRAINT nn_aluno_sexo NOT NULL,
    data_nasc DATE
        CONSTRAINT nn_aluno_data_nasc NOT NULL
);
    
    
    CREATE TABLE materia (
    codigo    NUMBER NOT NULL,
    descricao VARCHAR(200)
        CONSTRAINT uk_materia_descricao UNIQUE
);

DROP TABLE materia;

CREATE TABLE materia (
    codigo    NUMBER
        CONSTRAINT pk_materia_codigo PRIMARY KEY,
    descricao VARCHAR(200)
        CONSTRAINT uk_materia_descricao UNIQUE
);
-- Chave primária composta a constraint é sempre declarada no nível de tabela
DROP TABLE reg_geral;
CREATE TABLE reg_geral(
    RG NUMBER,  
    nome varchar(200),
    org_emissor varchar(6),
        CONSTRAINT PK_reg_geral_RG_org_emissor PRIMARY KEY (RG, org_emissor)
        
);

-- Abreviação metodo CHECK = CK
DROP TABLE aluno;
CREATE TABLE aluno(
matricula NUMBER,
NOME VARCHAR2(30),
sexo CHAR(1) CONSTRAINT CK_aluno_sexo CHECK (sexo IN ('M','F'))
);

