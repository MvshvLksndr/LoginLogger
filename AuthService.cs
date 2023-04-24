using System;
using System.Linq;
using System.Net;

namespace LoginLogger
{
    public static class AuthService
    {
        public static bool isValid(string Login, string Pass)
        {
            MockUser user = new MockUser();
            return user.Users.Any(X => X.Login == Login && X.Password == Pass);
            
        }
    }

    public class Logger
    {

        public void isFalse(string Login, string Pass) 
        {
            DBcontext context = new DBcontext();
            Log log = GetBaseLog(Login);
            log.login = Login;
            log.Successful = false;

            context.logs.Add(log);
            context.SaveChanges();
        }

        private Log GetBaseLog(string log)
        {
            Log l = new Log();
            l.Date = System.DateTime.Now;
            l.Host = GetHost();
            l.Ip = GetIp();
            return l;
        }

        private string GetIp()
        {
            return "Ip";
        }

        private string GetHost()
        {
            return "Host";
        }

        public void isTrue(string Login, string Pass)
        {
            DBcontext context = new DBcontext();
            Log log = GetBaseLog(Login);
            log.login = Login;
            log.Successful = true;

            context.logs.Add(log);
            context.SaveChanges();
        }
    }
}