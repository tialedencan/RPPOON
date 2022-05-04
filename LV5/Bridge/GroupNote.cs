using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class GroupNote : Note
    {
        private List<string> groupMembers;
        public GroupNote(string message, ITheme theme) : base(message, theme)
        {
            this.groupMembers = new List<string>();
        }

        public override void AddToGroup(string personName)
        {
            groupMembers.Add(personName);
        }
        public override void RemoveFromGroup(string personName)
        {
            groupMembers.Remove(personName);
        }

     /* public string GetMembers() //nez treba li
        {
            StringBuilder sb = new StringBuilder();
            foreach (string member in groupMembers)
            {
                sb.Append(member +", ");
            }
            return sb.ToString();
        }*/
        public override void Show() //mozda tu trebam prikazati ljude
        {
            this.ChangeColor();
            Console.WriteLine("Group: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            
            foreach(string member in groupMembers)
            {
                Console.Write(member + " ");
            }
               
            Console.ResetColor();
            
        }
    }
}
