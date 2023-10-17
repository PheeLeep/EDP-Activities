namespace CustomExceptionFrm.CustomExceptions {

#pragma warning disable S3925
    public class NumberFormatException : Exception {
        public NumberFormatException(string varName) : base(varName) { }
    }
}
