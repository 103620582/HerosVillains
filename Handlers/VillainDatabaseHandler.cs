using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace GameAPI {
    public class VillainDatabaseHandler : DatabaseHandler {
        public List<Villain> GetAllVillainsFromDB() {
            List<Villain> returnVillain = new List<Villain>();

            using(SqlConnection conn = new SqlConnection(GetConnectionString())) {
                try {
                    conn.Open();
                    using(SqlCommand command = new SqlCommand ("SELECT * FROM VILLAIN", conn)) {
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                returnVillain.Add (new Villain() {
                                    VillainId = reader.GetInt32(0),
                                    VillainName = reader.GetString(1),
                                    HitPoints = reader.GetInt32(2),
                        
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
            return returnVillain;
        }
    }
}