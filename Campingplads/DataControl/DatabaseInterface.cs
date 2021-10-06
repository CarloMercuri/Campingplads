﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Campingplads.DataControl
{
    public class DatabaseInterface
    {
        private string connectionString = "Server=localhost;Database=Camping;User Id=sa;Password=Passw0rd;Trusted_Connection=true";

        private void DeveloperCtrlC()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("GetAvailableCampingSpotsTypesFull", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@paramName", SqlDbType.VarChar).Value = "paramValue";
                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (!rdr.HasRows)
                    {
                    }

                    while (rdr.Read())
                    {
                        string value1 = rdr["value_name"].ToString();
                    }
                } // end of reader

            } // end of cmd
        }

        public CampingSpotTypeInformation GetCampingSpotTypeInformation(int spotType)
        {
            CampingSpotTypeInformation spot = new CampingSpotTypeInformation();

            using (SqlConnection con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("GetCampingSpotTypeInfoWithPrices", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@spotType", SqlDbType.VarChar).Value = spotType;
                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (!rdr.HasRows)
                    {
                        return null;
                    }

                    rdr.Read();
                    spot.SpotName = rdr["spot_name"].ToString();
                    spot.SpotDescription = rdr["spot_description"].ToString();
                    spot.SquareMeters = (int)rdr["square_meters"];
                    spot.SpotType = (int)rdr["spot_type"];
                    spot.MaxPeople = (int)rdr["max_people"];
                    spot.LowSeasonDailyPrice = (int)rdr["base_price"];

                    rdr.Read();
                    spot.HighSeasonDailyPrice = (int)rdr["base_price"];

                  
                } // end of reader

            } // end of cmd

            return spot;
        }

        public List<CampingSpotTypeInformation> GetAvaibleSpotTypesInDates(DateTime startDate, DateTime endDate)
        {
            List<SQLCommandParameter> cmdParams = new List<SQLCommandParameter>();


            List<CampingSpotTypeInformation> returnList = new List<CampingSpotTypeInformation>();

            using (SqlConnection con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("GetAvailableCampingSpotsTypesFull", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@startDate", SqlDbType.VarChar).Value = startDate.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@endDate", SqlDbType.VarChar).Value = endDate.ToString("yyyy-MM-dd");

                con.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (!rdr.HasRows)
                    {
                    }

                    while (rdr.Read())
                    {

                        string spot_name = rdr["spot_name"].ToString();
                        string spot_description = rdr["spot_description"].ToString();
                        int spot_type = (int)rdr["spot_type"];
                        int spot_squareMeters = (int)rdr["square_meters"];
                        int spot_maxPeople = (int)rdr["max_people"];


                        CampingSpotTypeInformation model = new CampingSpotTypeInformation(spot_name, spot_description, spot_type, spot_squareMeters, spot_maxPeople);
                        returnList.Add(model);

                    }
                } // end of reader

            } // end of cmd
       

            return returnList;
        }

        private SqlDataReader SendStoredProcedure(string procedureName, List<SQLCommandParameter> parameters)
        {
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            var cmd = new SqlCommand(procedureName, con);

            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SQLCommandParameter param in parameters)
            {
                cmd.Parameters.Add(param.ParameterName, SqlDbType.VarChar).Value = param.ParameterValue;
            }

            SqlDataReader rdr = cmd.ExecuteReader();

            con.Close();

            return rdr;

          
        }
    }

}