namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies1 : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO Movies (Id, Name, DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'Hangover',  1/1/2017, 31/12/2015, 10)");
            //Sql("INSERT INTO Movies (Id, Name,  DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'Die Hard',  1/1/2017, 31/12/2016, 5)");
            //Sql("INSERT INTO Movies (Id, Name,  DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'The Terminator',  1/1/2017, 31/12/2004, 3)");
            //Sql("INSERT INTO Movies (Id, Name,  DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'Toy Story',, 1/1/2017, 31/12/2014, 8)");
            //Sql("INSERT INTO Movies (Id, Name,  DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'Titanic', 1/1/2017, 31/12/2001, 6)");
        }

        public override void Down()
        {
        }
    }
}
