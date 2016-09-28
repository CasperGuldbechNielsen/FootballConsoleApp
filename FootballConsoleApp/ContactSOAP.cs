using FootballConsoleApp.ServiceReference1;

namespace FootballConsoleApp
{
    public class ContactSOAP
    {
        private ServiceReference1.SportsdataSoapClient client;

        public ContactSOAP()
        {
            client = new SportsdataSoapClient();
        }

        public void GetLeageStanding()
        {
            //TODO: Stuff
        }
    }
}