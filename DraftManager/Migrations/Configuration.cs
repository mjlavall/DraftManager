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
                new Team { Abbreviation = "PIT", Location = "Pittsburg", Name = "Steelers" },
                new Team { Abbreviation = "NYG", Location = "New York", Name = "Giants" },
                new Team { Abbreviation = "MIN", Location = "Minnesota", Name = "Vikings" },
                new Team { Abbreviation = "ATL", Location = "Atlanta", Name = "Falcons"},
                new Team { Abbreviation = "LA",  Location = "Los Angeles", Name = "Rams" },
                new Team { Abbreviation = "DAL", Location = "Dallas", Name = "Cowboys" },
                new Team { Abbreviation = "HOU", Location = "Houston", Name = "Texans" },
                new Team { Abbreviation = "ARI", Location = "Arizona", Name = "Cardinals" },
                new Team { Abbreviation = "NE",  Location = "New England", Name = "Patriots" },
                new Team { Abbreviation = "CIN", Location = "Cincinnati", Name = "Bengals" },
                new Team { Abbreviation = "JAX", Location = "Jacksonville", Name = "Jaguars" },
                new Team { Abbreviation = "TB",  Location = "Tampa Bay", Name = "Buccaneers" },
                new Team { Abbreviation = "GB",  Location = "Green Bay", Name = "Packers" },
                new Team { Abbreviation = "NO",  Location = "New Orleans", Name = "Saints" },
                new Team { Abbreviation = "NYJ", Location = "New York", Name = "Jets" },
                new Team { Abbreviation = "SEA", Location = "Seattle", Name = "Seahawks" },
                new Team { Abbreviation = "BUF", Location = "Buffalo", Name = "Bills" },
                new Team { Abbreviation = "CHI", Location = "Chicago", Name = "Bears" },
                new Team { Abbreviation = "KC",  Location = "Kansas City", Name = "Chiefs" },
                new Team { Abbreviation = "WSH", Location = "Washington", Name = "Redskins" },
                new Team { Abbreviation = "OAK", Location = "Oakland", Name = "Raiders" },
                new Team { Abbreviation = "DEN", Location = "Denver", Name = "Broncos" },
                new Team { Abbreviation = "SD",  Location = "San Diego", Name = "Chargers" },
                new Team { Abbreviation = "CAR", Location = "Carolina", Name = "Panthers" },
                new Team { Abbreviation = "SF",  Location = "San Fransisco", Name = "49ers" },
                new Team { Abbreviation = "IND", Location = "Indianapolis", Name = "Colts" },
                new Team { Abbreviation = "MIA", Location = "Miami", Name = "Dolphins" },
                new Team { Abbreviation = "DET", Location = "Detroit", Name = "Lions" },
                new Team { Abbreviation = "PHI", Location = "Philadelphia", Name = "Eagles" },
                new Team { Abbreviation = "TEN", Location = "Tennessee", Name = "Titans" },
                new Team { Abbreviation = "CLE", Location = "Clevland", Name = "Browns" },
                new Team { Abbreviation = "BAL", Location = "Baltimore", Name = "Ravens" },
                new Team { Abbreviation = "FA",  Location = "", Name = "Free Agent" });
            context.SaveChanges();

        }
    }
}
