using System;
using System.Collections.Generic;
using System.Text;

namespace LV3.Zad5
{
    internal class NotificationDirector
    {
        public void ConstructInformationNotification(string author)
        { 
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author).SetText("Hello world").SetTitle("Hello").
                SetColor(ConsoleColor.Green).SetTime(new DateTime(2022, 4, 6)).SetLevel(Zad4.Category.INFO);
        }
        public void ConstructErrorNotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author).SetText("Error found!").SetTitle("ERROR").
                SetColor(ConsoleColor.Red).SetTime(new DateTime(2022, 4, 6)).SetLevel(Zad4.Category.ERROR);
        }
        public void ConstructAlertNotification(string author)
        {
            NotificationBuilder builder = new NotificationBuilder();
            builder.SetAuthor(author).SetText("Alert!").SetTitle("ALERT").
                SetColor(ConsoleColor.Yellow).SetTime(new DateTime(2022, 4, 6)).SetLevel(Zad4.Category.ALERT);
        }

    }
}
