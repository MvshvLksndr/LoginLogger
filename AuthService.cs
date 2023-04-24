using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

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
            log.password = Pass;

            context.logs.Add(log);
            context.SaveChanges();
        }

        private Log GetBaseLog(string log)
        {
            Log l = new Log();
            l.Date = System.DateTime.Now;
            l.Host = GetHost();
            l.password = String.Empty;
            l.Ip = GetIp();
            
            return l;
        }

        private string GetIp()
        {
            return "Ip";
        }

        private string GetHost()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
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