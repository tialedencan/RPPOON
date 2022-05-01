using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITheme darkTheme = new DarkTheme();
            Note note = new ReminderNote("Hello",darkTheme);
            note.Show();

            ITheme lightTheme=new LightTheme();
            Note lightNote = new ReminderNote("Funny", lightTheme);
            lightNote.Show();

            Note groupNote=new GroupNote("Group",lightTheme);
            groupNote.Show();
        }
    }
}
