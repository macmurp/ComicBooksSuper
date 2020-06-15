using Microsoft.EntityFrameworkCore;
using System.Data;
using System.IO;
using Microsoft.Data.SqlClient;
using System;

namespace MVC_ComicBooksCharacters.Models
{
    public class ComicBookContext : DbContext
    {
        public DbSet<ComicBook> ComicBooks { get; set; }

        public ComicBookContext(DbContextOptions<ComicBookContext> options) : base(options)
        { }
        
        public ComicBookContext()
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
          
            string path = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDBFilename=" 
                + path + "\\comicbooks.mdf; Trusted_Connection=true;MultipleActiveResultSets=true";


            builder.UseSqlServer(conn);
            base.OnConfiguring(builder);
        }
        
        //protected void BindData()
        //{
        //    string path = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");
        //    string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDBFilename="
        //        + path + "\\comicbooks.mdf; Trusted_Connection=true;MultipleActiveResultSets=true";

        //    SqlConnection cn = new SqlConnection(conn);
        //        cn.Open();
        //        SqlCommand cmd = new SqlCommand("Select ComicBookID,ComicBookTitle FROM ComicBooks", cn);
        //        DataSet dt = new DataSet();
                
        //        SqlDataAdapter ad = new SqlDataAdapter(cmd);

        //        ad.Fill(dt);
        //        MyGridView.DataSource = dt;
        //        MyGridView.DataBind();
        //        cn.Close();
        //}

    }

}

