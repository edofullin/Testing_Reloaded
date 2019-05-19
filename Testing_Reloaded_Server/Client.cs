﻿using System.Net;
using System.Net.Sockets;
using SharedLibrary;

namespace Testing_Reloaded_Server {
    public class Client : User {
        public int Id { get; set; }
        public TcpClient TcpClient { get; set; }
        public UserTestState TestState { get; set; }
        public Client(int id, User user, TcpClient client) : base(user.Name, user.Surname, user.PCHostname) {
            this.TcpClient = client;
        }
    }
}