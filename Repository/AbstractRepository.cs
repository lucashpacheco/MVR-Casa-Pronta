using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using PetaPoco;
//using PetaPoco.Providers;
using MVR_Casa_Pronta.Models;
//using Microsoft.Extensions.Configuration;

namespace MVR_Casa_Pronta.Repository
{
  

        //public abstract class AbstractRepository<T>
        //{
        //    private string _connectionString;
        //    private IDatabase _db;
        //    protected IDatabase Db => _db;
        //    public AbstractRepository(IConfiguration configuration)
        //    {
        //        _connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");

        //        _db = DatabaseConfiguration.Build()
        //                .UsingConnectionString(_connectionString)
        //                .UsingProvider<MySqlDatabaseProvider>()
        //                .Create();

        //        _db.Execute(LoadTextResource("sql_init.sql"));
        //    }
        //    public abstract void Add(T item);
        //    public abstract void Remove(int id);
        //    public abstract void Update(T item);
        //    public abstract T FindByID(int id);
        //    public abstract IEnumerable<T> FindAll();

        //    private string LoadTextResource(string name)
        //    {
        //        var path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Scripts", name);
        //        System.Console.WriteLine(path);
        //        System.IO.StreamReader r = new System.IO.StreamReader(path);
        //        string str = r.ReadToEnd();
        //        r.Close();

        //        return str;
        //    }

        //}
       
    
}