/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.Day3
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();
        void SendEmail(string v);

        //In interface all are public 
        //Interface are not Class
        //Interface must be implemented 
        //Multiple Inhert for 2 base class parents can have 2 or more childer but a child have only one parent multi inhertance were supported.
        //
    }

    internal interface IEmailService
    {
        void SendEmail(string message);
        void ReceiveEmail();
        void DeleteEmail();

    }

    internal class WhatsApp : IMessageService,IEmailService
    {
        public void DeleteMessage(string message)
        {
            Console.WriteLine("DeleteMessage");
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Receive Message");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Send Audio Message");
        }
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Send Video Message");
        }
        public void SendEmail(string message)
        {
            Console.WriteLine("Send Email");
        }
        public void RecevieEmail(string message)
        {
            Console.WriteLine("Recevie Email");
        }
        public void DeleteEamil(string message)
        {
            Console.WriteLine("Delete Email");
        }
        

    }
}*/
