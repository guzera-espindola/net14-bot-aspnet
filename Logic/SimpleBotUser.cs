﻿using SimpleBot.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBot.Logic
{
    public class SimpleBotUser
    {
        public string Reply(SimpleMessage message)
        {
            MensagemDao.Insert(message);
            return $"{message.User} disse '{message.Text}";
        }

    }
}