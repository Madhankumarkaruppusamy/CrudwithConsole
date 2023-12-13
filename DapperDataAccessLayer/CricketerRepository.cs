using System;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace DapperDataAccessLayer
{
        public class CricketerRepository : ICricketerRepository
        {

        string connectionString = "Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";
        public void InsertSP(Cricketer details)
            {
                try
                {
                    var con = new SqlConnection(connectionString);
                    con.Open();
                    var insertQuery = $"exec InsertSP @CricketerName='{details.CricketerName}', @TotalODI={details.TotalODI}, @TotalScore={details.TotalScore}, @Fifties={details.Fifties},@Hundreds={details.Hundreds} ";
                    con.Execute(insertQuery);
                    con.Close();


                }
                catch (SqlException sql)
                {
                    throw;

                }
                catch (Exception ex)
                {
                    throw;
                }

            }

           
            public List<Cricketer> ReadSP()
            {
            try
            {                
                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"exec ReadSP";
                var stats = con.Query<Cricketer>(selectQuery);

                con.Close();
                return stats.ToList();


            }
            catch (SqlException sql)
                {
                    throw;

                }
                catch (Exception ex)
                {
                    throw;
                }

            }


            public void DeleteSP(long CricketerId)
            {
                try
                {
                    var con = new SqlConnection(connectionString);
                    con.Open();
                    var deleteQuery = $"exec DeleteSP {CricketerId}";
                    con.Execute(deleteQuery);
                    con.Close();

                }
                catch (SqlException sql)
                {
                    throw;

                }
                catch (Exception ex)
                {
                    throw;
                }

            }
            public void UpdateSP(long cricketerId, Cricketer prd)
            {
                try
                {
                    var con = new SqlConnection(connectionString);
                    con.Open();
                    var updateQuery = $"exec UpdateSP  {cricketerId},'{prd.CricketerName}',{prd.TotalODI},{prd.TotalScore},{prd.Fifties},{prd.Hundreds} ";
                    var product = con.Query<Cricketer>(updateQuery);
                    con.Execute(updateQuery);
                    con.Close();


                }
                catch (SqlException sql)
                {
                    throw;

                }
                catch (Exception ex)
                {
                    throw;
                }

            }

        }
    }

