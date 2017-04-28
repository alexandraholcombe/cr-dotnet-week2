using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonOfCod.Models;

namespace SonOfCod.ViewModels
{
    public class SubscribeViewModel
    {
        public Subscriber Subscriber { get; set; }
        public List<Subscriber> AllSubscribers { get; set; }
    }
}
