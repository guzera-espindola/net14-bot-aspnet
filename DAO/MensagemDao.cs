using MongoDB.Bson;
using SimpleBot.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.DAO
{
    public static class MensagemDao
    {
        public static void Insert(SimpleMessage message)
        {
            var client = DataAcess.Connection();
            var db = client.GetDatabase("Gustavo_BD");
            var col = db.GetCollection<BsonDocument>("TB_Mensagem");

            var ret = message.Id;
            var dado = message.Text;
            var txt = message.User;

            var doc = new BsonDocument() {
                                                { "campo1", ret },
                                                { "campo2", dado },
                                                { "campo3", txt }
                                               };

            col.InsertOne(doc);

        }
    }
}