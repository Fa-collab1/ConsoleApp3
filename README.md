# Min Gästbok - Konsolapplikation / ConsoleApp3 

## Beskrivning

Det här projektet är en konsolapplikation skriven i C#, som jag har utvecklat som en del av kursen "Programmering i C#.NET". Applikationen fungerar som en gästbok där användare kan:

- Lägga till nya inlägg med namn och kommentar.
- Ta bort inlägg genom att ange index.
- Visa alla tidigare inlagda gästboksinlägg.

Gästboksinläggen sparas i en **JSON-fil**, vilket gör att inlägg bevaras mellan olika körningar av programmet.

## Funktioner

- **Lägg till ett inlägg**: Användaren matar in ett namn och en kommentar. Fälten kan inte lämnas tomma, och vid tom inmatning visas ett felmeddelande.
- **Ta bort ett inlägg**: Användaren kan ta bort ett inlägg genom att ange indexnumret för inlägget i listan.
- **Spara och läsa från fil**: Alla inlägg sparas automatiskt till en JSON-fil och laddas in vid uppstart.

## Användning

### Menyval
När programmet körs visas följande meny:
1. Lägg till ett inlägg
2. Ta bort ett inlägg
X. Avsluta

### Kommandon
- Tryck på **1** för att lägga till ett nytt inlägg. Du uppmanas att ange ditt namn och din kommentar. Om något fält lämnas tomt, måste du försöka igen.
- Tryck på **2** för att ta bort ett inlägg. Ange indexnumret för det inlägg du vill ta bort.
- Tryck på **X** för att avsluta programmet.

### Inläggshantering
Varje inlägg består av två fält:
  - **Namn**: Ägaren till inlägget.
  - **Kommentar**: Själva inlägget.

Inläggen visas i formatet:

[0] Jonas - Jävla Potatishummer!  
[1] Postatishummern - Jävla Jonas!


## Filhantering
Alla gästboksinlägg lagras i en fil kallad `guestbook.json` i JSON-format. Detta gör att inläggen bevaras mellan körningar av programmet.

## Krav
- **C#-kompatibel utvecklingsmiljö** (t.ex. Visual Studio eller .NET Core SDK).
- **JSON-filhantering** med hjälp av `System.Text.Json`.

## Installation och körning

1. **Klona eller ladda ner** projektet från GitHub eller annan källa.
2. **Öppna projektet** i din C#-utvecklingsmiljö (t.ex. Visual Studio).
3. **Bygg och kör** projektet.

## Felhantering

- Felhantering implementeras för att säkerställa att inmatningsfält inte lämnas tomma.
- Vid felaktig inmatning (t.ex. försök att ta bort ett icke-existerande inlägg) visas ett felmeddelande och man får försöka igen tills man fått ordning på det.

## Projektstruktur

- **Guestbook.cs**: Hanterar gästboken, inklusive lagring, hämtning, tillägg och borttagning av inlägg.
- **GuestbookEntry.cs**: Representerar ett enskilt inlägg med egenskaperna `Name` och `Comment`.
- **Program.cs**: Huvudprogrammet som hanterar användarinteraktion och menyer.

## Lärandemål

Genom att utveckla den här applikationen har jag uppnått följande:

- Jag har skapat ett enklare objektorienterat program i C#.
- Jag har använt klasser och objekt för att bygga en konsolapplikation.
- Jag har erhållit en grundläggande förståelse för objektorienterad programmering och dess terminologi.

## Uppgiftens syfte

Denna uppgift är en del av kursen "Programmering i C#.NET", och syftar till att jag ska:

- Kunna skapa enklare objektorienterade program i C#.
- Kunna använda klasser och objekt i programmeringsspråket C#.
- Få en djupare förståelse för objektorienterad programmering och dess terminologi.

## Källor
Jag har utgått från exempel och material från föreläsningarna i kursen "Programmering i C#.NET".

## Författare
**Jonas Nilsson**
