

using ListaIndirizzi;

List<PersonalData> ListaDati = new List<PersonalData>();



StreamReader file = File.OpenText("C:\\Users\\aless\\Desktop\\Github\\ListaIndirizzi\\ListaIndirizzi\\Indirizzi.csv");

file.ReadLine();

while (!file.EndOfStream)
    {
    string riga = file.ReadLine();
    string[] infoAddress = riga.Split(",");


    string nome = infoAddress[0];
    while (nome.Length == 0)
        {
        Console.WriteLine("Il campo 'nome' è vuoto, inserisci qualcosa!");
        nome = Console.ReadLine();
        }
    string cognome = infoAddress[1];
    string indirizzo = infoAddress[2];
    while (indirizzo.Length == 0)
        {
        Console.WriteLine("Il campo 'indirizzo' è vuoto, inserisci qualcosa!");
        indirizzo = Console.ReadLine();
        }
    string città = infoAddress[3];
    string provincia = infoAddress[4];
    while (provincia.Length == 0)
        {
        Console.WriteLine("Il campo 'provincia' è vuoto, inserisci qualcosa!");
        provincia = Console.ReadLine();
        }
    string zipCode = infoAddress[5];

    PersonalData Dati = new PersonalData(nome, cognome, indirizzo, città, provincia, zipCode);
    ListaDati.Add(Dati);
    }


foreach (PersonalData Dati in ListaDati)
    {
    Console.WriteLine(Dati);
    }