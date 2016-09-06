﻿namespace HSharedKernel.Events
{
    using Contracts;
    using System;

    public class DomainNotification : IDomainEvent
    {
        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
            this.DateOccurred = DateTime.Now;
        }

        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DateOccurred { get; private set; }
    }
}