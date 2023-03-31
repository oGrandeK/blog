namespace Blog;

static class Configuration
{
    public static string JwtKey = "ZmVkYWY3ZDg4NjNiNDhlMTk3Yjky0DdkNDkyYjcw0GU=";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "curso_api_IlTevUM/z0ey3NwCV/unWg==";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; } = String.Empty;
        public int Port { get; set; } = 25;
        public string UserName { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}