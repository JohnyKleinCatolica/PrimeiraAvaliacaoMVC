namespace PrimeiraAvaliacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertBD : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Mensal', 1, 140)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Trimestral', 3, 400)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Semestral', 6, 600)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, Periodo, Mensalidade) VALUES ('Anual', 12, 1400)");

        }
        
        public override void Down()
        {
        }
    }
}
