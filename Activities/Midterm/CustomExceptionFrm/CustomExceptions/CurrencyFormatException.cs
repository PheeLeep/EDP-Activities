namespace CustomExceptionFrm.CustomExceptions {

#pragma warning disable S3925
    public class CurrencyFormatException : Exception {
        public CurrencyFormatException(string varName) : base(varName) { }
    }
}
