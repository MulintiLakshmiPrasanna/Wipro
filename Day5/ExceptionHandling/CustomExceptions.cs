using System;

class ValidationException : Exception
{
    public ValidationException(string message) : base(message) { }
}

class BusinessRuleException : Exception
{
    public BusinessRuleException(string message) : base(message) { }
}

class ExternalServiceException : Exception
{
    public ExternalServiceException(string message) : base(message) { }
}
