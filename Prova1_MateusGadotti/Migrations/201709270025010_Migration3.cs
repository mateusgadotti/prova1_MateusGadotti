namespace Prova1_MateusGadotti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            
            Sql("INSERT INTO Alunoes(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (1, 21 , 'Martim Castro Ribeiro', '158.778.735-04')");
            Sql("INSERT INTO Alunoes(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (4, 22 , 'Lucas Alves Melo', '916.749.332-74')");
            Sql("INSERT INTO Alunoes(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (2, 23 , 'Breno Castro Carvalho', '454.019.800-94')");
            Sql("INSERT INTO Alunoes(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (6, 24 , 'Laura Cardoso Rocha', '361.089.665-56')");
        }

        public override void Down()
        {
        }
    }
}
