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
            groupNote.AddToGroup("Mark");
            groupNote.AddToGroup("Ana");//nije jasno treba li se pristupiti grupi i ovo kako bi proradilo
            //morala bi mijenjati note (dodati) pa bi kršilo OCP
            //groupNote.GetMembers();

            Note darkGroupNote = new GroupNote("Darkers", darkTheme);
            darkGroupNote.Show();

            //z7 za izmjene bi dodala atribut teme koja se čuva za sve note-ove
            Notebook notebook = new Notebook();
            notebook.AddNote(note);
            notebook.AddNote(lightNote);
            notebook.AddNote(groupNote);
            notebook.Display();
            notebook.ChangeTheme(darkTheme);
            notebook.Display();
            notebook.ChangeTheme(lightTheme);
            notebook.Display();
            
        }
    }
}
