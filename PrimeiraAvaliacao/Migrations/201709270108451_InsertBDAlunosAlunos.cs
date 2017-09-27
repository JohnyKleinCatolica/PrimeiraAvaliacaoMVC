namespace PrimeiraAvaliacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertBDAlunosAlunos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunoes(Nome, Cpf, Faixa_Id, TipoDeAssociacao_Id) VALUES ('Martim Castro Ribeiro', '158.778.735-04', 1, 13)");
            Sql("INSERT INTO Alunoes(Nome, Cpf, Faixa_Id, TipoDeAssociacao_Id) VALUES ('Lucas Alves Melo', '916.749.332-74', 4, 14)");
            Sql("INSERT INTO Alunoes(Nome, Cpf, Faixa_Id, TipoDeAssociacao_Id) VALUES ('Breno Castro Carvalho', '454.019.800-94', 2, 15)");
            Sql("INSERT INTO Alunoes(Nome, Cpf, Faixa_Id, TipoDeAssociacao_Id) VALUES ('Laura Cardoso Rocha', '361.089.665-56', 6, 16)");
        }
        
        public override void Down()
        {
        }
    }
}
