CREATE TABLE usuario (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Nickname VARCHAR(50) UNIQUE NOT NULL,
    Senha VARCHAR(255) NOT NULL,
    DataDeNascimento DATE NOT NULL,
    Nivel VARCHAR(50) DEFAULT 'iniciante',
    PontuacaoTotal INT DEFAULT 0,
    AcertosTotais INT DEFAULT 0,
    PerguntasRespondidas INT DEFAULT 0,
    MaiorSequenciaAcertos INT DEFAULT 0,
    AcertosConsecutivosAtuais INT DEFAULT 0,
    UltimoAcesso DATE
);

CREATE TABLE pergunta (
    Id SERIAL PRIMARY KEY,
    Enunciado TEXT NOT NULL,
    Tipo VARCHAR(50) NOT NULL,
    Nivel VARCHAR(50) NOT NULL,
    Tema VARCHAR(100) NOT NULL,
    Pontuacao INT NOT NULL
);

CREATE TABLE alternativa (
    Id SERIAL PRIMARY KEY,
    PerguntaId INT NOT NULL REFERENCES pergunta(Id) ON DELETE CASCADE,
    Texto TEXT NOT NULL,
    IsCorreta BOOLEAN NOT NULL
);

CREATE TABLE historico_partida (
    Id SERIAL PRIMARY KEY,
    UsuarioId INT NOT NULL REFERENCES usuario(Id) ON DELETE CASCADE,
    PerguntaId INT NOT NULL REFERENCES pergunta(Id),
    DataHora TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    TemaPergunta VARCHAR(100) NOT NULL,
    Acertou BOOLEAN NOT NULL,
    PontuacaoGanha INT NOT NULL
);

CREATE TABLE conquista (
    Id SERIAL PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descricao TEXT NOT NULL,
    Icone VARCHAR(255)
);

CREATE TABLE usuario_conquista (
    UsuarioId INT NOT NULL REFERENCES usuario(Id) ON DELETE CASCADE,
    ConquistaId INT NOT NULL REFERENCES conquista(Id) ON DELETE CASCADE,
    DataObtencao TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (UsuarioId, ConquistaId)
);