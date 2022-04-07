using LV3.Zad4;
using System;
using System.Collections.Generic;
using System.Text;

namespace LV3.Zad5
{
    class NotificationBuilder : IBuilder
    {   //trebam defaultne vrijednosti atributa
        private string author;
        private string title;
        private string text;
        private DateTime time;
        private Category level;
        private ConsoleColor color;
        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, time, level, color);
        }

        public IBuilder SetAuthor(string author)
        {
            this.author = author; 
            return this;
        }
 
        public IBuilder SetTitle(string title)
        {
           this.title = title;
            return this;
        }
        public IBuilder SetTime(DateTime time)
        {
           this.time= time;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
           this.level = level;
            return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
        public IBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }
    }
      
}
