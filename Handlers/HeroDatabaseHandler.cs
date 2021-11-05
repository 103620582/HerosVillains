using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace GameAPI {
    public class HeroDatabaseHandler : DatabaseHandler {
        public List<Hero> GetAllHeroesFromDB() {
            List<Hero> returnHero = new List<Hero>();

            using(SqlConnection conn = new SqlConnection(GetConnectionString())) {
                try {
                    conn.Open();
                    using(SqlCommand command = new SqlCommand ("SELECT * FROM HERO", conn)) {
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                returnHero.Add (new Hero() {
                                    HeroId = reader.GetInt32(0),
                                    HeroName = reader.GetString(1),
                                    DiceMin = reader.GetInt32(2),
                                    DiceMax = reader.GetInt32(3),
                                    UsesLeft = reader.GetInt32(4)
                                });
                            }
                        }
                    }
                }
                catch (Exception e) {
                    throw new Exception("Error in GetAllDemoFromDB()" + e.Message);
                }
                finally {
                    conn.Close();
                }
            }
            return returnHero;
        }
    }
}