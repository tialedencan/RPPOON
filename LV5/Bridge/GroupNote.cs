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

        public void AddToGroup(string personName)
        {
            groupMembers.Add(personName);
        }
        public void RemoveFromGroup(string personName)
        {
            groupMembers.Remove(personName);
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("Group: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
