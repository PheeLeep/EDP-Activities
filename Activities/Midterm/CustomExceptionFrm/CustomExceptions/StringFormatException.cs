namespace CustomExceptionFrm.CustomExceptions {

#pragma warning disable S3925
    public class StringFormatException : Exception {
        public StringFormatException(string varName) : base(varName) { }
    }
}
