using System;
using System.Runtime.Serialization;

namespace BlueprintsRetro
{
    [Serializable]
    internal class CommandNotRecognized : Exception
    {
        public CommandNotRecognized()
        {
        }

        public CommandNotRecognized(string message) : base(message)
        {
        }

        public CommandNotRecognized(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CommandNotRecognized(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}