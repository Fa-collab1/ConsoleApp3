using System.Text.Json;

namespace ConsoleApp3
{
    public class Guestbook // klass f�r att skapa g�stbok
    {
        private string filename = @"guestbook.json"; // filnamn f�r att spara g�stboksinl�gg
        private List<GuestbookEntry> guestbookEntries = new List<GuestbookEntry>(); // lista f�r att spara inl�gg i g�stboken

        public Guestbook()
        { // konstruktor f�r att skapa g�stbok
            if (File.Exists(filename)==true){ // If stored json data exists then read
                string jsonString = File.ReadAllText(filename); // l�ser in json data fr�n fil
                guestbookEntries = JsonSerializer.Deserialize<List<GuestbookEntry>>(jsonString)!; // deserialiserar json data till lista
            }
        }
        public GuestbookEntry AddGuestbookEntry(string name, string comment)
        { // metod f�r att l�gga till inl�gg i g�stboken
            GuestbookEntry obj = new GuestbookEntry(); // skapar nytt objekt av klassen GuestbookEntry
            obj.Comment = comment; // s�tter kommentar
            obj.Name = name; // s�tter namn
            guestbookEntries.Add(obj);// l�gger till objekt i listan
            Marshal();// serialiserar objekt och sparar till fil
            return obj; // returnerar objekt
        }
        
        public int DelEntry(int index)
        { // metod f�r att ta bort inl�gg i g�stboken
            guestbookEntries.RemoveAt(index); // tar bort inl�gg fr�n listan
            Marshal(); // serialiserar objekt och sparar till fil
            return index; // returnerar index
        }

        public List<GuestbookEntry> GetGuestbookEntries()
        { // metod f�r att h�mta inl�gg i g�stboken
            return guestbookEntries; // returnerar lista med inl�gg
        }

        private void Marshal() // metod f�r att serialisera objekt och spara till fil
        {
            // Serialize all the objects and save to file
            var jsonString = JsonSerializer.Serialize(guestbookEntries);// serialiserar lista med objekt till json
            File.WriteAllText(filename, jsonString); // skriver json data till fil
        }
    }
}

//bygger v�ldigt mycket p� exempelfil fr�n f�rel�sning