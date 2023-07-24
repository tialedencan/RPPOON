using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITheme lightTheme = new LightTheme();
            ITheme darkTheme = new DarkTheme();
            ReminderNote note = new ReminderNote("Remind me", lightTheme);
            ReminderNote noteDark = new ReminderNote("Darker", darkTheme);

            note.Show();
            noteDark.Show();

            note.ChangeTheme(darkTheme);
            note.Show();

            //z6
            GroupNote groupNote = new GroupNote("Grupica prijatelja", lightTheme);
            groupNote.AddToGroup("Mark");
            groupNote.AddToGroup("Lucisa");
            groupNote.Show();
            groupNote.RemoveFromGroup("Lucisa");
            groupNote.Show();

            //z7
            Notebook notebook = new Notebook(lightTheme);
            notebook.AddNote(note);
            notebook.AddNote(noteDark);
            notebook.AddNote(groupNote);
            notebook.Display();
            notebook.ChangeTheme(darkTheme);
            notebook.AddNote(new ReminderNote("Pozdrav", lightTheme));
            notebook.Display();

        }
    }
}
