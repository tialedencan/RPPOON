using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Notebook
    {
        private List<Note> notes;
        public Notebook() { this.notes = new List<Note>(); }
        public void AddNote(Note note) { this.notes.Add(note); }
        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
