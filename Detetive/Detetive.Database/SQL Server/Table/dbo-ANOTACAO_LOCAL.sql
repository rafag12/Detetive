CREATE TABLE dbo.ANOTACAO_LOCAL(
  ID_ANOTACAO_LOCAL INT IDENTITY(1,1) PRIMARY KEY,
  ID_JOGADOR_SALA   INT FOREIGN KEY REFERENCES JOGADOR(ID_JOGADOR) NOT NULL,
  ID_LOCAL          INT FOREIGN KEY REFERENCES LOCAL(ID_LOCAL) NOT NULL,
  IE_ATIVO		    BIT DEFAULT 1
)