using System;
using System.Collections.Generic;
using System.Text;

namespace CSTheSixthLab
{
    class Phone
    {

        public void Call(Contact contact)
        {

        }

        public void SendMessage(String text, Contact contact)
        {
            Console.WriteLine("Message has been sent to " + contact.name);
        }

        public void TakePhoto()
        {

        }

        public void MakeNote(String text)
        {
            Console.WriteLine("Note has been created (" + text + ")");
        }

        public String PlayMusic(String songname)
        {
            return "Plaing " + songname;
        }

        public void Off() { }

        public void On() { }
    }
}
