using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SimpleBot.DAO
{
    public static class DataAcess
    {

        public static MongoClient Connection()
        {
            var connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            return new MongoClient(connectionString);
       

        }

     

    }
}