using DraftManager.Models;

namespace DraftManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DraftManager.Models.DraftContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DraftManager.Models.DraftContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Teams.AddOrUpdate(
                t => t.Abbreviation,
                new Team { Abbreviation = "PIT", Location = "Pittsburg", Name = "Steelers", Bye= 8 },
                new Team { Abbreviation = "NYG", Location = "New York", Name = "Giants", Bye = 8 },
                new Team { Abbreviation = "MIN", Location = "Minnesota", Name = "Vikings", Bye = 6 },
                new Team { Abbreviation = "ATL", Location = "Atlanta", Name = "Falcons", Bye = 11 },
                new Team { Abbreviation = "LA",  Location = "Los Angeles", Name = "Rams", Bye = 8 },
                new Team { Abbreviation = "DAL", Location = "Dallas", Name = "Cowboys", Bye = 7 },
                new Team { Abbreviation = "HOU", Location = "Houston", Name = "Texans", Bye = 9 },
                new Team { Abbreviation = "ARI", Location = "Arizona", Name = "Cardinals", Bye = 9 },
                new Team { Abbreviation = "NE",  Location = "New England", Name = "Patriots", Bye = 9 },
                new Team { Abbreviation = "CIN", Location = "Cincinnati", Name = "Bengals", Bye = 9 },
                new Team { Abbreviation = "JAX", Location = "Jacksonville", Name = "Jaguars", Bye = 5 },
                new Team { Abbreviation = "TB",  Location = "Tampa Bay", Name = "Buccaneers", Bye = 6 },
                new Team { Abbreviation = "GB",  Location = "Green Bay", Name = "Packers", Bye = 4 },
                new Team { Abbreviation = "NO",  Location = "New Orleans", Name = "Saints", Bye = 5 },
                new Team { Abbreviation = "NYJ", Location = "New York", Name = "Jets", Bye = 11 },
                new Team { Abbreviation = "SEA", Location = "Seattle", Name = "Seahawks", Bye = 5 },
                new Team { Abbreviation = "BUF", Location = "Buffalo", Name = "Bills", Bye = 10 },
                new Team { Abbreviation = "CHI", Location = "Chicago", Name = "Bears", Bye = 9 },
                new Team { Abbreviation = "KC",  Location = "Kansas City", Name = "Chiefs", Bye = 5 },
                new Team { Abbreviation = "WSH", Location = "Washington", Name = "Redskins", Bye = 9 },
                new Team { Abbreviation = "OAK", Location = "Oakland", Name = "Raiders", Bye = 10 },
                new Team { Abbreviation = "DEN", Location = "Denver", Name = "Broncos", Bye = 11 },
                new Team { Abbreviation = "SD",  Location = "San Diego", Name = "Chargers", Bye = 11 },
                new Team { Abbreviation = "CAR", Location = "Carolina", Name = "Panthers", Bye = 7 },
                new Team { Abbreviation = "SF",  Location = "San Fransisco", Name = "49ers", Bye = 8 },
                new Team { Abbreviation = "IND", Location = "Indianapolis", Name = "Colts", Bye = 10 },
                new Team { Abbreviation = "MIA", Location = "Miami", Name = "Dolphins", Bye = 8 },
                new Team { Abbreviation = "DET", Location = "Detroit", Name = "Lions", Bye = 10 },
                new Team { Abbreviation = "PHI", Location = "Philadelphia", Name = "Eagles", Bye = 4 },
                new Team { Abbreviation = "TEN", Location = "Tennessee", Name = "Titans", Bye = 13 },
                new Team { Abbreviation = "CLE", Location = "Clevland", Name = "Browns", Bye = 13 },
                new Team { Abbreviation = "BAL", Location = "Baltimore", Name = "Ravens", Bye = 8 },
                new Team { Abbreviation = "FA",  Location = "", Name = "Free Agent", Bye = 0 });
            context.SaveChanges();

        }
    }
}
