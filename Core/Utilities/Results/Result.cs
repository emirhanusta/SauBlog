﻿using System.Text.Json.Serialization;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        [JsonConstructor]
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
