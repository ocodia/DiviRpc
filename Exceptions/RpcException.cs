﻿using System;

namespace DiviSharp.Exceptions
{
    [Serializable]
    public class RpcException : Exception
    {
        public RpcException()
        {
        }

        public RpcException(string customMessage) : base(customMessage)
        {
        }

        public RpcException(string customMessage, Exception exception) : base(customMessage, exception)
        {
        }
    }
}
