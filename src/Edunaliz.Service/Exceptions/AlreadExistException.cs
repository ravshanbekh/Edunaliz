﻿namespace Edunaliz.Service.Exceptions;

public class AlreadExistException : Exception
{
    public AlreadExistException(string message) : base(message)
    { }

    public AlreadExistException(string message, Exception innerException) : base(message, innerException)
    { }

    public int StatusCode { get; set; } = 403;
}