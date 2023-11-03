namespace BookBrowser.Shared
{
    public class Notification
    {
        public static void ShowMessage(MessageType messageType, object x, object y)
        {
            Notification n = new();
            string messageText = n.GetMessage(messageType, x, y);
            Console.WriteLine(messageText);
        }
        private string GetMessage(MessageType messageType, object x, object y) =>
            messageType switch
            {
                MessageType.Welcome => $"Willkommen in deiner Buchverwaltung: {x}.",
                MessageType.Quit => "Möchtest du das Programm beenden?\n1: Ja\n2: Nein",
                MessageType.SetBookTitle => "Wie heißt das Buch?",
                MessageType.SetBookDescription => "Was ist die Beschreibung des Buches?",
                MessageType.SetBookAuthor => "Wie heißt der Autor?",
                MessageType.SetBookGenre => "Was ist das Genre?",
                MessageType.SetBookYear => "Im welchem Jahr wurde das Buch geschrieben?",
                MessageType.SelectFilterGenre => "Wähle aus nach welchem Genre du sortieren möchtest.",
                MessageType.UnknownInput => "Unbekannte Eingabe. Bitte versuche es nochmal.",
                _ => "Unbekannte Eingabe.",
            };
    }
}
