using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

using makooooDemo.Models;
using makooooDemo.Repositories;

namespace makooooDemo
{
    public class ChatHub : Hub
    {
        IUserRepository repository;
        public ChatHub(IUserRepository repository) {
            this.repository = repository;
        }
        public async Task Send(string message, string userName) {
            repository.AddUser(new User { UserName = userName, MessageDate = DateTime.Now, Message = message });
            await Clients.All.SendAsync("Send", message, userName);
        }
    }
}
