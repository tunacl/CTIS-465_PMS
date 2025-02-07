﻿using Core.APP.Domain;


namespace CORE.APP.Features
{
    public class QueryResponse : Entity
    {
    }

    public class CommandResponse : Entity
    {
        public bool IsSuccessful { get; }
        public string Message { get; }

        public CommandResponse(bool isSuccessful, string message = "", int id = 0) : base(id)
        {
            IsSuccessful = isSuccessful;
            Message = message;
        }
    }
}
