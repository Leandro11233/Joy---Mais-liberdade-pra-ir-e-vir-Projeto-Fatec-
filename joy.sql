CREATE DATABASE IF NOT EXISTS Joy;
USE Joy;

CREATE TABLE usuario (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    data_nascimento DATE
);

CREATE TABLE condicao (
    id_condicao INT AUTO_INCREMENT PRIMARY KEY,
    nome_condicao VARCHAR(100) NOT NULL,
    descricao VARCHAR(255)
);

CREATE TABLE detalhe_condicao (
    id_detalhe INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_condicao INT NOT NULL,
    detalhamento TEXT,
    FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) ON DELETE CASCADE,
    FOREIGN KEY (id_condicao) REFERENCES condicao(id_condicao) ON DELETE CASCADE
);

CREATE TABLE preferencia_acessibilidade (
    id_preferencia INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT NOT NULL,
    descricao VARCHAR(255),
    FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) ON DELETE CASCADE
);

CREATE TABLE contato_confianca (
    id_contato INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT NOT NULL,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(20),
    FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) ON DELETE CASCADE
);

CREATE TABLE onibus (
    id_onibus INT AUTO_INCREMENT PRIMARY KEY,
    linha VARCHAR(100),
    sentido VARCHAR(100),
    ponto_embarque VARCHAR(150),
    ponto_desembarque VARCHAR(150),
    horario_saida TIME,
    horario_chegada TIME,
    dias_funcionamento VARCHAR(100)
);

CREATE TABLE motorista (
    id_motorista INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(20),
    foto VARCHAR(255),
    modelo_veiculo VARCHAR(100),
    placa VARCHAR(10),
    disponivel BOOLEAN DEFAULT TRUE
);

CREATE TABLE trajeto (
    id_trajeto INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT NOT NULL,
    id_onibus INT DEFAULT NULL,
    id_motorista INT DEFAULT NULL,
    origem VARCHAR(255) NOT NULL,
    destino VARCHAR(255) NOT NULL,
    modalidade ENUM('A pé', 'Ônibus', 'Carro') NOT NULL,
    status ENUM('Aguardando', 'Confirmado', 'Em andamento', 'Encerrado', 'Cancelado') DEFAULT 'Aguardando',
    data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    data_inicio DATETIME NULL,
    data_fim DATETIME NULL,
    FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) ON DELETE CASCADE,
    FOREIGN KEY (id_onibus) REFERENCES onibus(id_onibus) ON DELETE SET NULL,
    FOREIGN KEY (id_motorista) REFERENCES motorista(id_motorista) ON DELETE SET NULL
);

CREATE TABLE rota (
    id_rota INT AUTO_INCREMENT PRIMARY KEY,
    id_trajeto INT NOT NULL,
    percurso LONGTEXT,
    distancia DECIMAL(10,2),
    tempo_estimado INT,
    servico_mapa VARCHAR(100),
    data_calculo DATETIME,
    FOREIGN KEY (id_trajeto) REFERENCES trajeto(id_trajeto) ON DELETE CASCADE
);

CREATE TABLE localizacao (
    id_localizacao INT AUTO_INCREMENT PRIMARY KEY,
    id_trajeto INT NOT NULL,
    latitude DECIMAL(10,7),
    longitude DECIMAL(10,7),
    data_hora DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_trajeto) REFERENCES trajeto(id_trajeto) ON DELETE CASCADE
);

CREATE TABLE compartilhamento (
    id_compartilhamento INT AUTO_INCREMENT PRIMARY KEY,
    id_trajeto INT NOT NULL,
    id_contato INT NOT NULL,
    autorizado BOOLEAN DEFAULT FALSE,
    data_autorizacao DATETIME NULL,
    data_encerramento DATETIME NULL,
    FOREIGN KEY (id_trajeto) REFERENCES trajeto(id_trajeto) ON DELETE CASCADE,
    FOREIGN KEY (id_contato) REFERENCES contato_confianca(id_contato) ON DELETE CASCADE
);

CREATE TABLE notificacao (
    id_notificacao INT AUTO_INCREMENT PRIMARY KEY,
    id_trajeto INT NOT NULL,
    id_contato INT NOT NULL,
    mensagem VARCHAR(255) NOT NULL,
    data_envio DATETIME DEFAULT CURRENT_TIMESTAMP,
    status ENUM('Pendente', 'Enviada', 'Falhou') DEFAULT 'Pendente',
    FOREIGN KEY (id_trajeto) REFERENCES trajeto(id_trajeto) ON DELETE CASCADE,
    FOREIGN KEY (id_contato) REFERENCES contato_confianca(id_contato) ON DELETE CASCADE
);