﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Core.Events
{
    public abstract class Event : Message, INotification 
    {
        public DateTime TimeStamp { get; private set; }

        protected Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
