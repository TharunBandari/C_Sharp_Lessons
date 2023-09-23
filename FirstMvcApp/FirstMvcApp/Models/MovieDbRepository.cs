﻿using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMvcApp.Models
{
    public class MovieDbRepository
    {
        public static List<Movie> GetMovieList()
        {
            List<Movie> movielist = new List<Movie>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllmovie = "Select * from Movie_Tharun";
                selectmoviecmd.CommandText = selectAllmovie;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    Movie movie = new Movie
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),

                        Cost = moviedr.GetInt32(7),
                        Collections = moviedr.GetInt32(8),
                        Review = (int)(float)moviedr.GetDouble(9),





                    };
                    movielist.Add(movie);
                }
                return movielist;
            }
        }



        public static Movie GetMovieById(int id)
        {
            Movie movieFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectAllMovie = "Select * from Movie_Tharun Where Id=@id";
                selectmoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmoviecmd.CommandText = selectAllMovie;
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    Movie movie = new Movie
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetInt16(7),
                        Collections = moviedr.GetInt16(8),
                        Review = (int)moviedr.GetDecimal(9),





                    };
                }
            }
            return movieFound;
        }
    }
}
