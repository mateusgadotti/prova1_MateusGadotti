namespace Prova1_MateusGadotti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Faixas(Nome, Grau) VALUES ('Branca', '6k')");
            Sql("INSERT INTO Faixas(Nome, Grau) VALUES ('Amarela', '5k')");
            Sql("INSERT INTO Faixas(Nome, Grau) VALUES ('Roxa', '4k')");
            Sql("INSERT INTO Faixas(Nome, Grau) VALUES ('Verde', '3k')");
            Sql("INSERT INTO Faixas(Nome, Grau) VALUES ('Azul', '2k')");
            Sql("INSERT INTO Faixas(Nome, Grau) VALUES ('Marrom', '1k')");
            Sql("INSERT INTO Faixas(Nome, Grau) VALUES ('Preta', '1d')");

            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Mensal', 1 , 140)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Trimestral', 3 , 400)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Semestral', 6 , 600)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Anual', 12 , 1400)");

            
        }
        
        public override void Down()
        {
        }
    }
}
