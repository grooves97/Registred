using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Sign_Up account = new Sign_Up();
            account.UserLogin();
            account.Password();
            account.ComparePass();
            account.EmailAndPhone();


            Random rnd = new Random();
            int randomCode = rnd.Next(1,9);

            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "AC7ee9ce3104b8f87e7caf3d1b17eb899e";
            const string authToken = "7585663101907a2ac2f550e48213d465";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: randomCode.ToString(),
                from: new Twilio.Types.PhoneNumber("+1 971 407 1753"),
                to: new Twilio.Types.PhoneNumber("+77027779674")
            );

            Console.WriteLine(message.Sid);
            Console.Clear();
            Console.WriteLine("Thanks for waiting");
            account.CodeVerify(randomCode.ToString());
            Console.ReadLine();
        }
    }
}
