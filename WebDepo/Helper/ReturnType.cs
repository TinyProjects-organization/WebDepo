namespace WebDepo.Helper
{
    public class ReturnType
    {
        public StatusCode Status { get; set; }
        public string Message { get; set; }
        public string ExceptionMessage { get; set; }
        public string ClassName { get; set; }
        public object Data { get; set; }
    }
    public enum StatusCode
    {
        Success = 0,
        Warning = 1,
        Error = 2,
    }
}
