namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies2 : DbMigration
    {
        public override void Up()
        {
           //// Sql("SET IDENTITY_INSERT Movies ON");

           // Sql("INSERT INTO Movies (Name, DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES ('Hangover',  '1/1/2017', '31/12/2015', 10, 4)");
           // Sql("INSERT INTO Movies ( Name,  DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES ( 'Die Hard',  '1/1/2017', '31/12/2016', 5), 1");
           // Sql("INSERT INTO Movies ( Name,  DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES ( 'The Terminator',  '1/1/2017', '31/12/2004', 3, 1)");
           // Sql("INSERT INTO Movies ( Name,  DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES ( 'Toy Story', '1/1/2017', '31/12/2014', 8, 3)");
           // Sql("INSERT INTO Movies ( Name,  DateAdded, ReleaseDate, NumberInStock, GenreId) VALUES ( 'Titanic', '1/1/2017', '31/12/2001', 6, 2)");
        }

        public override void Down()
        {
        }
    }
}
