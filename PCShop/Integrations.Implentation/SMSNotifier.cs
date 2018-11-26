﻿using Integrations.Contracts;
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrations.Implentation
{
    public class SMSNotifier : INotifier
    {
        public void Notify(Client client, string message)
        {
            Console.WriteLine($"Sends a message to {client.PhoneNumber} with message: {message}");
        }
    }
}