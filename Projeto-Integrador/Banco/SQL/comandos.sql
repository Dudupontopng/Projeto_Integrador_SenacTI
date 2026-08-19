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




-- ==========================================
-- 1. INSERINDO AS PERGUNTAS (Total: 60)
-- ==========================================
INSERT INTO pergunta (Id, Enunciado, Tipo, Nivel, Tema, Pontuacao) VALUES
-- TEMA: Hardware (1 a 10)
(1, 'Qual componente é considerado o cérebro do computador?', 'Multipla Escolha', 'Iniciante', 'Hardware', 10),
(2, 'A memória RAM perde seus dados quando o computador é desligado.', 'Verdadeiro ou Falso', 'Iniciante', 'Hardware', 10),
(3, 'O que significa a sigla SSD?', 'Multipla Escolha', 'Fácil', 'Hardware', 20),
(4, 'A placa-mãe é responsável por conectar todos os componentes do PC.', 'Verdadeiro ou Falso', 'Fácil', 'Hardware', 20),
(5, 'Qual é a principal função da GPU?', 'Multipla Escolha', 'Intermediário', 'Hardware', 30),
(6, 'A fonte de alimentação converte energia contínua em alternada.', 'Verdadeiro ou Falso', 'Intermediário', 'Hardware', 30),
(7, 'O que indica o "Clock" de um processador, medido em GHz?', 'Multipla Escolha', 'Avançado', 'Hardware', 50),
(8, 'A memória Cache L1 é mais rápida e menor que a L3.', 'Verdadeiro ou Falso', 'Avançado', 'Hardware', 50),
(9, 'Qual porta de vídeo transmite áudio e vídeo simultaneamente?', 'Multipla Escolha', 'Fácil', 'Hardware', 20),
(10, 'A BIOS fica armazenada no disco rígido do computador.', 'Verdadeiro ou Falso', 'Intermediário', 'Hardware', 30),

-- TEMA: Programação (11 a 20)
(11, 'O que é uma variável em programação?', 'Multipla Escolha', 'Iniciante', 'Programação', 10),
(12, 'O C# é uma linguagem orientada a objetos.', 'Verdadeiro ou Falso', 'Iniciante', 'Programação', 10),
(13, 'Para que serve um comando "if"?', 'Multipla Escolha', 'Fácil', 'Programação', 20),
(14, 'Um laço "while" executa o código pelo menos uma vez, independente da condição.', 'Verdadeiro ou Falso', 'Fácil', 'Programação', 20),
(15, 'O que é Polimorfismo em POO?', 'Multipla Escolha', 'Intermediário', 'Programação', 30),
(16, 'No C#, o modificador "private" permite acesso à variável por qualquer classe.', 'Verdadeiro ou Falso', 'Intermediário', 'Programação', 30),
(17, 'Qual o padrão de nomenclatura exigido para classes no C#?', 'Multipla Escolha', 'Avançado', 'Programação', 50),
(18, 'O Dapper é um Micro-ORM usado para mapear banco de dados.', 'Verdadeiro ou Falso', 'Avançado', 'Programação', 50),
(19, 'O que significa concatenar strings?', 'Multipla Escolha', 'Fácil', 'Programação', 20),
(20, 'O comando "break" serve para parar a execução de um loop.', 'Verdadeiro ou Falso', 'Intermediário', 'Programação', 30),

-- TEMA: Redes (21 a 30)
(21, 'O que é um endereço IP?', 'Multipla Escolha', 'Iniciante', 'Redes', 10),
(22, 'O Wi-Fi usa cabos físicos para transmitir dados.', 'Verdadeiro ou Falso', 'Iniciante', 'Redes', 10),
(23, 'Qual a função de um roteador?', 'Multipla Escolha', 'Fácil', 'Redes', 20),
(24, 'A sigla LAN significa Local Area Network.', 'Verdadeiro ou Falso', 'Fácil', 'Redes', 20),
(25, 'Qual protocolo é usado para navegação web segura?', 'Multipla Escolha', 'Intermediário', 'Redes', 30),
(26, 'O DNS converte endereços IP em nomes de domínio (URLs).', 'Verdadeiro ou Falso', 'Intermediário', 'Redes', 30),
(27, 'Qual porta padrão do protocolo HTTPS?', 'Multipla Escolha', 'Avançado', 'Redes', 50),
(28, 'O protocolo UDP garante a entrega de todos os pacotes enviados.', 'Verdadeiro ou Falso', 'Avançado', 'Redes', 50),
(29, 'O que é a Nuvem (Cloud)?', 'Multipla Escolha', 'Fácil', 'Redes', 20),
(30, 'O comando "ping" testa a conectividade entre dois equipamentos.', 'Verdadeiro ou Falso', 'Intermediário', 'Redes', 30),

-- TEMA: Segurança Digital (31 a 40)
(31, 'O que é um Antivírus?', 'Multipla Escolha', 'Iniciante', 'Segurança Digital', 10),
(32, 'Compartilhar senhas com amigos é uma prática segura.', 'Verdadeiro ou Falso', 'Iniciante', 'Segurança Digital', 10),
(33, 'O que é Phishing?', 'Multipla Escolha', 'Fácil', 'Segurança Digital', 20),
(34, 'Autenticação em duas etapas aumenta a segurança da conta.', 'Verdadeiro ou Falso', 'Fácil', 'Segurança Digital', 20),
(35, 'Qual a função de um Firewall?', 'Multipla Escolha', 'Intermediário', 'Segurança Digital', 30),
(36, 'Usar a mesma senha em vários sites é recomendado para não esquecer.', 'Verdadeiro ou Falso', 'Intermediário', 'Segurança Digital', 30),
(37, 'O que faz a biblioteca BCrypt?', 'Multipla Escolha', 'Avançado', 'Segurança Digital', 50),
(38, 'Ransomware é um malware que criptografa dados e cobra resgate.', 'Verdadeiro ou Falso', 'Avançado', 'Segurança Digital', 50),
(39, 'O que significa fazer Backup?', 'Multipla Escolha', 'Fácil', 'Segurança Digital', 20),
(40, 'Uma VPN oculta seu endereço IP real durante a navegação.', 'Verdadeiro ou Falso', 'Intermediário', 'Segurança Digital', 30),

-- TEMA: Sistemas Operacionais (41 a 50)
(41, 'O que é um Sistema Operacional?', 'Multipla Escolha', 'Iniciante', 'Sistemas Operacionais', 10),
(42, 'O Windows é um sistema operacional de código aberto.', 'Verdadeiro ou Falso', 'Iniciante', 'Sistemas Operacionais', 10),
(43, 'Qual destes é um Sistema Operacional para smartphones?', 'Multipla Escolha', 'Fácil', 'Sistemas Operacionais', 20),
(44, 'No Windows, a Lixeira armazena arquivos apagados permanentemente.', 'Verdadeiro ou Falso', 'Fácil', 'Sistemas Operacionais', 20),
(45, 'O que é o Kernel de um sistema operacional?', 'Multipla Escolha', 'Intermediário', 'Sistemas Operacionais', 30),
(46, 'O Linux foi criado por Bill Gates.', 'Verdadeiro ou Falso', 'Intermediário', 'Sistemas Operacionais', 30),
(47, 'Qual o comando de terminal Linux usado para listar arquivos?', 'Multipla Escolha', 'Avançado', 'Sistemas Operacionais', 50),
(48, 'Deadlock ocorre quando dois ou mais processos bloqueiam um ao outro indefinidamente.', 'Verdadeiro ou Falso', 'Avançado', 'Sistemas Operacionais', 50),
(49, 'Para que serve o Gerenciador de Tarefas?', 'Multipla Escolha', 'Fácil', 'Sistemas Operacionais', 20),
(50, 'Arquivos com extensão .exe são executáveis do Windows.', 'Verdadeiro ou Falso', 'Intermediário', 'Sistemas Operacionais', 30),

-- TEMA: Ferramentas de produtividade (51 a 60)
(51, 'Qual atalho de teclado é usado para COPIAR um texto?', 'Multipla Escolha', 'Iniciante', 'Ferramentas de produtividade', 10),
(52, 'O Microsoft Excel serve para criar apresentações de slides.', 'Verdadeiro ou Falso', 'Iniciante', 'Ferramentas de produtividade', 10),
(53, 'Para que serve o Trello?', 'Multipla Escolha', 'Fácil', 'Ferramentas de produtividade', 20),
(54, 'O atalho Ctrl + Z desfaz a última ação.', 'Verdadeiro ou Falso', 'Fácil', 'Ferramentas de produtividade', 20),
(55, 'No Excel, como se inicia uma fórmula matemática?', 'Multipla Escolha', 'Intermediário', 'Ferramentas de produtividade', 30),
(56, 'O Jira é usado exclusivamente para Kanban e Scrum Board.', 'Verdadeiro ou Falso', 'Intermediário', 'Ferramentas de produtividade', 30),
(57, 'O que é um "Commit" no GitHub?', 'Multipla Escolha', 'Avançado', 'Ferramentas de produtividade', 50),
(58, 'A formatação condicional no Excel altera a cor da célula baseada em regras.', 'Verdadeiro ou Falso', 'Avançado', 'Ferramentas de produtividade', 50),
(59, 'Qual ferramenta é nativa do Windows para textos rápidos e simples?', 'Multipla Escolha', 'Fácil', 'Ferramentas de produtividade', 20),
(60, 'O Google Docs permite edição simultânea por várias pessoas.', 'Verdadeiro ou Falso', 'Intermediário', 'Ferramentas de produtividade', 30);


-- ==========================================
-- 2. INSERINDO AS ALTERNATIVAS
-- (Garantindo que há 4 para Múltipla Escolha e 2 para V/F) 
-- ==========================================
INSERT INTO alternativa (PerguntaId, Texto, IsCorreta) VALUES
-- Pergunta 1 (Hardware, Multipla, Iniciante)
(1, 'Placa-mãe', false),
(1, 'Processador (CPU)', true),
(1, 'Disco Rígido (HD)', false),
(1, 'Fonte de energia', false),

-- Pergunta 2 (Hardware, V/F, Iniciante)
(2, 'Verdadeiro', true),
(2, 'Falso', false),

-- Pergunta 3 (Hardware, Multipla, Fácil)
(3, 'Solid State Drive', true),
(3, 'Super Speed Data', false),
(3, 'System Storage Device', false),
(3, 'Serial Storage Drive', false),

-- Pergunta 4 (Hardware, V/F, Fácil)
(4, 'Verdadeiro', true),
(4, 'Falso', false),

-- Pergunta 5 (Hardware, Multipla, Intermediário)
(5, 'Processamento Gráfico (Vídeo)', true),
(5, 'Resfriar o sistema', false),
(5, 'Armazenar dados permanentemente', false),
(5, 'Proteger contra vírus', false),

-- Pergunta 6 (Hardware, V/F, Intermediário)
(6, 'Verdadeiro', false),
(6, 'Falso', true),

-- Pergunta 7 (Hardware, Multipla, Avançado)
(7, 'O número de núcleos do processador', false),
(7, 'A capacidade de armazenamento', false),
(7, 'A velocidade e frequência de processamento', true),
(7, 'O consumo de energia em Watts', false),

-- Pergunta 8 (Hardware, V/F, Avançado)
(8, 'Verdadeiro', true),
(8, 'Falso', false),

-- Pergunta 9 (Hardware, Multipla, Fácil)
(9, 'VGA', false),
(9, 'HDMI', true),
(9, 'USB', false),
(9, 'Ethernet', false),

-- Pergunta 10 (Hardware, V/F, Intermediário)
(10, 'Verdadeiro', false),
(10, 'Falso', true),

-- Pergunta 11 (Programação, Multipla, Iniciante)
(11, 'Um erro no código', false),
(11, 'Um espaço na memória para guardar um valor', true),
(11, 'Um tipo de monitor', false),
(11, 'Uma rede de internet', false),

-- Pergunta 12 (Programação, V/F, Iniciante)
(12, 'Verdadeiro', true),
(12, 'Falso', false),

-- Pergunta 13 (Programação, Multipla, Fácil)
(13, 'Criar um loop infinito', false),
(13, 'Deletar uma variável', false),
(13, 'Testar uma condição', true),
(13, 'Mostrar uma mensagem na tela', false),

-- Pergunta 14 (Programação, V/F, Fácil)
(14, 'Verdadeiro', false),
(14, 'Falso', true),

-- Pergunta 15 (Programação, Multipla, Intermediário)
(15, 'Múltiplas formas de um objeto se comportar', true),
(15, 'Uma linguagem de banco de dados', false),
(15, 'Um tipo de vírus de computador', false),
(15, 'Uma forma de esconder o código do usuário', false),

-- Pergunta 16 (Programação, V/F, Intermediário)
(16, 'Verdadeiro', false),
(16, 'Falso', true),

-- Pergunta 17 (Programação, Multipla, Avançado)
(17, 'camelCase', false),
(17, 'snake_case', false),
(17, 'PascalCase', true),
(17, 'kebab-case', false),

-- Pergunta 18 (Programação, V/F, Avançado)
(18, 'Verdadeiro', true),
(18, 'Falso', false),

-- Pergunta 19 (Programação, Multipla, Fácil)
(19, 'Dividir números', false),
(19, 'Juntar dois ou mais textos', true),
(19, 'Apagar o banco de dados', false),
(19, 'Transformar número em texto', false),

-- Pergunta 20 (Programação, V/F, Intermediário)
(20, 'Verdadeiro', true),
(20, 'Falso', false),

-- Pergunta 21 (Redes, Multipla, Iniciante)
(21, 'Um identificador único de um dispositivo na rede', true),
(21, 'O modelo do roteador', false),
(21, 'A velocidade da internet', false),
(21, 'Um cabo de rede', false),

-- Pergunta 22 (Redes, V/F, Iniciante)
(22, 'Verdadeiro', false),
(22, 'Falso', true),

-- Pergunta 23 (Redes, Multipla, Fácil)
(23, 'Aumentar a memória do computador', false),
(23, 'Proteger o PC de vírus', false),
(23, 'Encaminhar pacotes de dados entre redes', true),
(23, 'Tirar fotos da tela', false),

-- Pergunta 24 (Redes, V/F, Fácil)
(24, 'Verdadeiro', true),
(24, 'Falso', false),

-- Pergunta 25 (Redes, Multipla, Intermediário)
(25, 'HTTP', false),
(25, 'FTP', false),
(25, 'HTTPS', true),
(25, 'SMTP', false),

-- Pergunta 26 (Redes, V/F, Intermediário)
(26, 'Verdadeiro', true),
(26, 'Falso', false),

-- Pergunta 27 (Redes, Multipla, Avançado)
(27, 'Porta 80', false),
(27, 'Porta 443', true),
(27, 'Porta 21', false),
(27, 'Porta 22', false),

-- Pergunta 28 (Redes, V/F, Avançado)
(28, 'Verdadeiro', false),
(28, 'Falso', true),

-- Pergunta 29 (Redes, Multipla, Fácil)
(29, 'Armazenamento de dados em servidores online', true),
(29, 'Um jogo de computador', false),
(29, 'Um navegador de internet', false),
(29, 'Um tipo de cabo de fibra ótica', false),

-- Pergunta 30 (Redes, V/F, Intermediário)
(30, 'Verdadeiro', true),
(30, 'Falso', false),

-- Pergunta 31 (Segurança Digital, Multipla, Iniciante)
(31, 'Um programa para criar imagens', false),
(31, 'Um software que detecta e remove malwares', true),
(31, 'Uma peça de hardware', false),
(31, 'Um tipo de teclado', false),

-- Pergunta 32 (Segurança Digital, V/F, Iniciante)
(32, 'Verdadeiro', false),
(32, 'Falso', true),

-- Pergunta 33 (Segurança Digital, Multipla, Fácil)
(33, 'Um programa de baixar músicas', false),
(33, 'Um site de compras online', false),
(33, 'Golpe para roubar dados se passando por entidades confiáveis', true),
(33, 'Uma linguagem de programação', false),

-- Pergunta 34 (Segurança Digital, V/F, Fácil)
(34, 'Verdadeiro', true),
(34, 'Falso', false),

-- Pergunta 35 (Segurança Digital, Multipla, Intermediário)
(35, 'Bloquear acessos não autorizados a uma rede', true),
(35, 'Deixar o PC mais rápido', false),
(35, 'Apagar arquivos temporários', false),
(35, 'Traduzir sites', false),

-- Pergunta 36 (Segurança Digital, V/F, Intermediário)
(36, 'Verdadeiro', false),
(36, 'Falso', true),

-- Pergunta 37 (Segurança Digital, Multipla, Avançado)
(37, 'Compactar arquivos grandes', false),
(37, 'Gerar e verificar hashes seguros de senhas', true),
(37, 'Criar interfaces de usuário', false),
(37, 'Fazer conexão com o banco de dados', false),

-- Pergunta 38 (Segurança Digital, V/F, Avançado)
(38, 'Verdadeiro', true),
(38, 'Falso', false),

-- Pergunta 39 (Segurança Digital, Multipla, Fácil)
(39, 'Voltar uma página no navegador', false),
(39, 'Fazer uma cópia de segurança dos dados', true),
(39, 'Desligar o computador à força', false),
(39, 'Apagar todo o histórico de navegação', false),

-- Pergunta 40 (Segurança Digital, V/F, Intermediário)
(40, 'Verdadeiro', true),
(40, 'Falso', false),

-- Pergunta 41 (Sistemas Operacionais, Multipla, Iniciante)
(41, 'Um tipo de monitor', false),
(41, 'O programa principal que gerencia o hardware e software do PC', true),
(41, 'Apenas uma interface para a internet', false),
(41, 'Um jogo que já vem no computador', false),

-- Pergunta 42 (Sistemas Operacionais, V/F, Iniciante)
(42, 'Verdadeiro', false),
(42, 'Falso', true),

-- Pergunta 43 (Sistemas Operacionais, Multipla, Fácil)
(43, 'Android', true),
(43, 'Google Chrome', false),
(43, 'Microsoft Word', false),
(43, 'Photoshop', false),

-- Pergunta 44 (Sistemas Operacionais, V/F, Fácil)
(44, 'Verdadeiro', false),
(44, 'Falso', true),

-- Pergunta 45 (Sistemas Operacionais, Multipla, Intermediário)
(45, 'O núcleo que faz a ponte entre o software e o hardware', true),
(45, 'A tela de fundo do sistema', false),
(45, 'O botão de iniciar', false),
(45, 'O navegador padrão', false),

-- Pergunta 46 (Sistemas Operacionais, V/F, Intermediário)
(46, 'Verdadeiro', false),
(46, 'Falso', true),

-- Pergunta 47 (Sistemas Operacionais, Multipla, Avançado)
(47, 'mkdir', false),
(47, 'cd', false),
(47, 'ls', true),
(47, 'rm', false),

-- Pergunta 48 (Sistemas Operacionais, V/F, Avançado)
(48, 'Verdadeiro', true),
(48, 'Falso', false),

-- Pergunta 49 (Sistemas Operacionais, Multipla, Fácil)
(49, 'Para escrever textos', false),
(49, 'Para visualizar e finalizar processos/aplicativos em execução', true),
(49, 'Para baixar jogos', false),
(49, 'Para atualizar a placa de vídeo', false),

-- Pergunta 50 (Sistemas Operacionais, V/F, Intermediário)
(50, 'Verdadeiro', true),
(50, 'Falso', false),

-- Pergunta 51 (Ferramentas de produtividade, Multipla, Iniciante)
(51, 'Ctrl + V', false),
(51, 'Ctrl + X', false),
(51, 'Ctrl + P', false),
(51, 'Ctrl + C', true),

-- Pergunta 52 (Ferramentas de produtividade, V/F, Iniciante)
(52, 'Verdadeiro', false),
(52, 'Falso', true),

-- Pergunta 53 (Ferramentas de produtividade, Multipla, Fácil)
(53, 'Editar vídeos', false),
(53, 'Gerenciar projetos e tarefas em quadros', true),
(53, 'Criar banco de dados', false),
(53, 'Rodar códigos Python', false),

-- Pergunta 54 (Ferramentas de produtividade, V/F, Fácil)
(54, 'Verdadeiro', true),
(54, 'Falso', false),

-- Pergunta 55 (Ferramentas de produtividade, Multipla, Intermediário)
(55, 'Com aspas (" ")', false),
(55, 'Com sinal de igual (=)', true),
(55, 'Com hashtag (#)', false),
(55, 'Com dois pontos (:)', false),

-- Pergunta 56 (Ferramentas de produtividade, V/F, Intermediário)
(56, 'Verdadeiro', true),
(56, 'Falso', false),

-- Pergunta 57 (Ferramentas de produtividade, Multipla, Avançado)
(57, 'Excluir o repositório inteiro', false),
(57, 'Uma mensagem privada para outro programador', false),
(57, 'Um registro/salvamento das alterações feitas no código', true),
(57, 'Um erro de sintaxe', false),

-- Pergunta 58 (Ferramentas de produtividade, V/F, Avançado)
(58, 'Verdadeiro', true),
(58, 'Falso', false),

-- Pergunta 59 (Ferramentas de produtividade, Multipla, Fácil)
(59, 'Calculadora', false),
(59, 'Bloco de Notas', true),
(59, 'Paint', false),
(59, 'Prompt de Comando', false),

-- Pergunta 60 (Ferramentas de produtividade, V/F, Intermediário)
(60, 'Verdadeiro', true),
(60, 'Falso', false);
-- ==========================================
-- 3. INSERINDO MAIS 40 PERGUNTAS (IDs 61 a 100)
-- ==========================================
INSERT INTO pergunta (Id, Enunciado, Tipo, Nivel, Tema, Pontuacao) VALUES
-- TEMA: Hardware (61 a 67)
(61, 'O que é um periférico de entrada?', 'Multipla Escolha', 'Iniciante', 'Hardware', 10),
(62, 'O mouse é considerado um periférico de saída de dados.', 'Verdadeiro ou Falso', 'Iniciante', 'Hardware', 10),
(63, 'Qual a função principal do cooler no computador?', 'Multipla Escolha', 'Fácil', 'Hardware', 20),
(64, 'Pendrives utilizam memória flash para armazenar os dados.', 'Verdadeiro ou Falso', 'Fácil', 'Hardware', 20),
(65, 'O que representa a latência (CAS) em um pente de memória RAM?', 'Multipla Escolha', 'Intermediário', 'Hardware', 30),
(66, 'Uma placa-mãe do formato ATX é fisicamente menor que uma Micro-ATX.', 'Verdadeiro ou Falso', 'Intermediário', 'Hardware', 30),
(67, 'Qual tecnologia da Intel permite que um único núcleo físico do processador atue como dois núcleos lógicos?', 'Multipla Escolha', 'Avançado', 'Hardware', 50),

-- TEMA: Programação (68 a 74)
(68, 'O que é um algoritmo?', 'Multipla Escolha', 'Iniciante', 'Programação', 10),
(69, 'HTML é considerado uma linguagem de programação.', 'Verdadeiro ou Falso', 'Iniciante', 'Programação', 10),
(70, 'O que significa a ação de "debugar" (debugging) um código?', 'Multipla Escolha', 'Fácil', 'Programação', 20),
(71, 'Na linguagem C#, o tipo "int" é utilizado para armazenar textos longos.', 'Verdadeiro ou Falso', 'Fácil', 'Programação', 20),
(72, 'O que é a Herança na Programação Orientada a Objetos (POO)?', 'Multipla Escolha', 'Intermediário', 'Programação', 30),
(73, 'APIs RESTful utilizam os métodos HTTP, como GET, POST, PUT e DELETE.', 'Verdadeiro ou Falso', 'Intermediário', 'Programação', 30),
(74, 'Em C#, qual interface é tipicamente implementada para permitir que uma coleção seja percorrida usando um laço "foreach"?', 'Multipla Escolha', 'Avançado', 'Programação', 50),

-- TEMA: Redes (75 a 81)
(75, 'O que é o Bluetooth?', 'Multipla Escolha', 'Iniciante', 'Redes', 10),
(76, 'É possível acessar a internet sem que o seu dispositivo possua um endereço IP.', 'Verdadeiro ou Falso', 'Iniciante', 'Redes', 10),
(77, 'O que é um provedor de internet (ISP)?', 'Multipla Escolha', 'Fácil', 'Redes', 20),
(78, 'Uma rede WAN abrange uma área geográfica muito grande, como países ou continentes.', 'Verdadeiro ou Falso', 'Fácil', 'Redes', 20),
(79, 'Qual camada do modelo OSI é responsável pelo roteamento de pacotes (ex: protocolo IP)?', 'Multipla Escolha', 'Intermediário', 'Redes', 30),
(80, 'O endereço MAC é um endereço físico e único gravado na placa de rede do dispositivo.', 'Verdadeiro ou Falso', 'Intermediário', 'Redes', 30),
(81, 'Qual protocolo é utilizado para a resolução de endereços IP a partir de endereços MAC em uma rede local?', 'Multipla Escolha', 'Avançado', 'Redes', 50),

-- TEMA: Segurança Digital (82 a 88)
(82, 'O que é um "Spam"?', 'Multipla Escolha', 'Iniciante', 'Segurança Digital', 10),
(83, 'Clicar em links enviados por emails de remetentes desconhecidos é uma prática 100% segura.', 'Verdadeiro ou Falso', 'Iniciante', 'Segurança Digital', 10),
(84, 'O que caracteriza um ataque de Força Bruta (Brute Force)?', 'Multipla Escolha', 'Fácil', 'Segurança Digital', 20),
(85, 'A biometria, como o leitor de impressão digital, é um método válido de autenticação.', 'Verdadeiro ou Falso', 'Fácil', 'Segurança Digital', 20),
(86, 'O que é a Engenharia Social no contexto da segurança da informação?', 'Multipla Escolha', 'Intermediário', 'Segurança Digital', 30),
(87, 'Na criptografia simétrica, utilizam-se duas chaves diferentes: uma pública e uma privada.', 'Verdadeiro ou Falso', 'Intermediário', 'Segurança Digital', 30),
(88, 'Qual ataque cibernético tem como objetivo sobrecarregar um servidor com milhares de acessos até deixá-lo fora do ar?', 'Multipla Escolha', 'Avançado', 'Segurança Digital', 50),

-- TEMA: Sistemas Operacionais (89 a 94)
(89, 'Qual é o sistema operacional oficial dos computadores da Apple?', 'Multipla Escolha', 'Iniciante', 'Sistemas Operacionais', 10),
(90, 'Pastas (ou diretórios) são utilizadas para organizar arquivos dentro do computador.', 'Verdadeiro ou Falso', 'Iniciante', 'Sistemas Operacionais', 10),
(91, 'Qual tecla ou atalho padrão abre o Menu Iniciar no Windows?', 'Multipla Escolha', 'Fácil', 'Sistemas Operacionais', 20),
(92, 'No Linux, o usuário "root" representa o administrador com permissões totais no sistema.', 'Verdadeiro ou Falso', 'Fácil', 'Sistemas Operacionais', 20),
(93, 'Qual sistema de arquivos é o padrão e mais utilizado atualmente nas instalações modernas do Windows?', 'Multipla Escolha', 'Intermediário', 'Sistemas Operacionais', 30),
(94, 'A Memória Virtual (ou Swap) utiliza um espaço no disco rígido para auxiliar a memória RAM quando ela fica cheia.', 'Verdadeiro ou Falso', 'Intermediário', 'Sistemas Operacionais', 30),

-- TEMA: Ferramentas de produtividade (95 a 100)
(95, 'No pacote Microsoft Office, qual ferramenta é ideal para criar apresentações de slides?', 'Multipla Escolha', 'Iniciante', 'Ferramentas de produtividade', 10),
(96, 'Em grande parte dos softwares, o atalho de teclado Ctrl + S é utilizado para salvar o arquivo.', 'Verdadeiro ou Falso', 'Iniciante', 'Ferramentas de produtividade', 10),
(97, 'Para que serve a ferramenta "Conta-gotas", presente em softwares de edição visual e slides?', 'Multipla Escolha', 'Fácil', 'Ferramentas de produtividade', 20),
(98, 'Em um quadro do Trello, os cartões (cards) ficam bloqueados e não podem ser movidos entre as listas.', 'Verdadeiro ou Falso', 'Fácil', 'Ferramentas de produtividade', 20),
(99, 'No uso do Git, qual comando é usado para enviar os commits locais para o repositório remoto (como o GitHub)?', 'Multipla Escolha', 'Intermediário', 'Ferramentas de produtividade', 30),
(100, 'No Microsoft Word, a opção "Pincel de Formatação" permite copiar a aparência (fonte, cor, tamanho) de um texto e aplicá-la em outro.', 'Verdadeiro ou Falso', 'Intermediário', 'Ferramentas de produtividade', 30);


-- ==========================================
-- 4. INSERINDO AS ALTERNATIVAS (61 a 100)
-- ==========================================
INSERT INTO alternativa (PerguntaId, Texto, IsCorreta) VALUES
-- Pergunta 61 (Hardware, Multipla, Iniciante)
(61, 'Monitor', false),
(61, 'Teclado', true),
(61, 'Caixa de Som', false),
(61, 'Impressora', false),

-- Pergunta 62 (Hardware, V/F, Iniciante)
(62, 'Verdadeiro', false),
(62, 'Falso', true),

-- Pergunta 63 (Hardware, Multipla, Fácil)
(63, 'Fornecer energia ao processador', false),
(63, 'Resfriar os componentes para evitar superaquecimento', true),
(63, 'Acelerar a velocidade da internet', false),
(63, 'Aumentar o espaço do disco rígido', false),

-- Pergunta 64 (Hardware, V/F, Fácil)
(64, 'Verdadeiro', true),
(64, 'Falso', false),

-- Pergunta 65 (Hardware, Multipla, Intermediário)
(65, 'O tempo de resposta da memória para acessar um dado', true),
(65, 'A capacidade total de armazenamento em Gigabytes', false),
(65, 'A voltagem necessária para o funcionamento', false),
(65, 'O tamanho físico do pente de memória', false),

-- Pergunta 66 (Hardware, V/F, Intermediário)
(66, 'Verdadeiro', false),
(66, 'Falso', true),

-- Pergunta 67 (Hardware, Multipla, Avançado)
(67, 'Overclocking', false),
(67, 'Turbo Boost', false),
(67, 'Hyper-Threading', true),
(67, 'Undervolting', false),

-- Pergunta 68 (Programação, Multipla, Iniciante)
(68, 'Um erro crítico no sistema operacional', false),
(68, 'Uma sequência lógica e finita de passos para resolver um problema', true),
(68, 'Uma peça interna do computador', false),
(68, 'Um tipo de rede Wi-Fi', false),

-- Pergunta 69 (Programação, V/F, Iniciante)
(69, 'Verdadeiro', false),
(69, 'Falso', true),

-- Pergunta 70 (Programação, Multipla, Fácil)
(70, 'Excluir completamente o projeto', false),
(70, 'Traduzir o código para o idioma português', false),
(70, 'Encontrar e corrigir erros ou falhas no código', true),
(70, 'Publicar o aplicativo na loja', false),

-- Pergunta 71 (Programação, V/F, Fácil)
(71, 'Verdadeiro', false),
(71, 'Falso', true),

-- Pergunta 72 (Programação, Multipla, Intermediário)
(72, 'Um mecanismo onde uma classe adquire propriedades e comportamentos de outra', true),
(72, 'A técnica de esconder o código do usuário final', false),
(72, 'Um loop infinito não intencional', false),
(72, 'A criptografia de variáveis sensíveis no banco de dados', false),

-- Pergunta 73 (Programação, V/F, Intermediário)
(73, 'Verdadeiro', true),
(73, 'Falso', false),

-- Pergunta 74 (Programação, Multipla, Avançado)
(74, 'IDisposable', false),
(74, 'ICloneable', false),
(74, 'IEnumerable', true),
(74, 'IComparable', false),

-- Pergunta 75 (Redes, Multipla, Iniciante)
(75, 'Um protocolo de segurança de sites bancários', false),
(75, 'Uma tecnologia de comunicação sem fio de curto alcance', true),
(75, 'Um aplicativo para baixar músicas', false),
(75, 'Um novo tipo de cabo de fibra ótica', false),

-- Pergunta 76 (Redes, V/F, Iniciante)
(76, 'Verdadeiro', false),
(76, 'Falso', true),

-- Pergunta 77 (Redes, Multipla, Fácil)
(77, 'Uma empresa que fornece o serviço de acesso à internet aos usuários', true),
(77, 'Um vírus que rouba senhas bancárias', false),
(77, 'Um cabo azul usado em escritórios', false),
(77, 'O site de buscas do Google', false),

-- Pergunta 78 (Redes, V/F, Fácil)
(78, 'Verdadeiro', true),
(78, 'Falso', false),

-- Pergunta 79 (Redes, Multipla, Intermediário)
(79, 'Camada de Aplicação', false),
(79, 'Camada Física', false),
(79, 'Camada de Rede', true),
(79, 'Camada de Transporte', false),

-- Pergunta 80 (Redes, V/F, Intermediário)
(80, 'Verdadeiro', true),
(80, 'Falso', false),

-- Pergunta 81 (Redes, Multipla, Avançado)
(81, 'DNS', false),
(81, 'DHCP', false),
(81, 'FTP', false),
(81, 'ARP', true),

-- Pergunta 82 (Segurança Digital, Multipla, Iniciante)
(82, 'Mensagens não solicitadas, geralmente enviadas em massa (propaganda)', true),
(82, 'Um software que acelera a internet', false),
(82, 'Um tipo de rede social segura', false),
(82, 'Uma senha com letras e números', false),

-- Pergunta 83 (Segurança Digital, V/F, Iniciante)
(83, 'Verdadeiro', false),
(83, 'Falso', true),

-- Pergunta 84 (Segurança Digital, Multipla, Fácil)
(84, 'Desconectar os cabos de rede do servidor fisicamente', false),
(84, 'Tentar adivinhar senhas testando múltiplas combinações exaustivamente', true),
(84, 'Infectar um pendrive e colocar em um computador público', false),
(84, 'Esconder um arquivo de texto com senhas dentro de uma imagem', false),

-- Pergunta 85 (Segurança Digital, V/F, Fácil)
(85, 'Verdadeiro', true),
(85, 'Falso', false),

-- Pergunta 86 (Segurança Digital, Multipla, Intermediário)
(86, 'Desenvolver redes sociais para empresas', false),
(86, 'Escrever códigos complexos para proteger bancos', false),
(86, 'Manipular psicologicamente pessoas para obter informações confidenciais', true),
(86, 'Criar barreiras físicas contra invasores em data centers', false),

-- Pergunta 87 (Segurança Digital, V/F, Intermediário)
(87, 'Verdadeiro', false),
(87, 'Falso', true),

-- Pergunta 88 (Segurança Digital, Multipla, Avançado)
(88, 'SQL Injection', false),
(88, 'DDoS (Distributed Denial of Service)', true),
(88, 'Man-in-the-Middle', false),
(88, 'Cross-Site Scripting (XSS)', false),

-- Pergunta 89 (Sistemas Operacionais, Multipla, Iniciante)
(89, 'Windows', false),
(89, 'Android', false),
(89, 'macOS', true),
(89, 'Linux', false),

-- Pergunta 90 (Sistemas Operacionais, V/F, Iniciante)
(90, 'Verdadeiro', true),
(90, 'Falso', false),

-- Pergunta 91 (Sistemas Operacionais, Multipla, Fácil)
(91, 'Alt + Tab', false),
(91, 'Ctrl + Shift + Esc', false),
(91, 'F4', false),
(91, 'Tecla Windows (ou Super)', true),

-- Pergunta 92 (Sistemas Operacionais, V/F, Fácil)
(92, 'Verdadeiro', true),
(92, 'Falso', false),

-- Pergunta 93 (Sistemas Operacionais, Multipla, Intermediário)
(93, 'FAT32', false),
(93, 'NTFS', true),
(93, 'ext4', false),
(93, 'HFS+', false),

-- Pergunta 94 (Sistemas Operacionais, V/F, Intermediário)
(94, 'Verdadeiro', true),
(94, 'Falso', false),

-- Pergunta 95 (Ferramentas de produtividade, Multipla, Iniciante)
(95, 'Microsoft Word', false),
(95, 'Microsoft Excel', false),
(95, 'Microsoft Access', false),
(95, 'Microsoft PowerPoint', true),

-- Pergunta 96 (Ferramentas de produtividade, V/F, Iniciante)
(96, 'Verdadeiro', true),
(96, 'Falso', false),

-- Pergunta 97 (Ferramentas de produtividade, Multipla, Fácil)
(97, 'Copiar a cor exata de um pixel da tela para usá-la', true),
(97, 'Aumentar ou diminuir o zoom do slide', false),
(97, 'Apagar automaticamente o fundo de uma foto', false),
(97, 'Pingar "tinta" para desenhar linhas perfeitas', false),

-- Pergunta 98 (Ferramentas de produtividade, V/F, Fácil)
(98, 'Verdadeiro', false),
(98, 'Falso', true),

-- Pergunta 99 (Ferramentas de produtividade, Multipla, Intermediário)
(99, 'git status', false),
(99, 'git commit', false),
(99, 'git pull', false),
(99, 'git push', true),

-- Pergunta 100 (Ferramentas de produtividade, V/F, Intermediário)
(100, 'Verdadeiro', true),
(100, 'Falso', false);