namespace KontaktLista
{
    class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Email} - {Phone}";
        }
    }

    class ContactList
    {
        private List<Contact> contacts = new List<Contact>();

        public ContactList()
        {
            // Läs in kontaktlistan från en textfil om den finns, annars skapa en ny lista.
        }

        public void AddContact(Contact contact)
        {
            // Lägg till en kontakt i listan.
            contacts.Add(contact);
        }

        public Contact FindContact(string name)
        {
            return contacts.FirstOrDefault(contact => contact.Name == name);
        }

        public void RemoveContact(string name)
        {
            // Ta bort en kontakt baserat på namn.
            contacts.RemoveAll(contact => contact.Name == name);
        }

        public void ShowAllContacts()
        {
            // Visa hela kontaktlistan.
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Name}, {contact.Email}, {contact.Phone}");
            }
        }

        public void SaveToFile()
        {
            // Spara kontaktlistan i en textfil.
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ContactList contactList = new ContactList();
           // contactList.LoadFromFile("contacts.txt"); // ladda befintliga kontakter om filen finns
            bool running = true;

            while (running)
            {
                // Visa meny och låt användaren välja åtgärd.
                Console.WriteLine("Välj en åtgärd: ");
                Console.WriteLine("1. Lägga till en ny kontakt");
                Console.WriteLine("2. Ta bort en kontakt");
                Console.WriteLine("3. Söka efter en kontakt");
                Console.WriteLine("4. Visa hela kontaktlistan");
                Console.WriteLine("5. Avsluta programmet och spara kontaktlistan");
                
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            // Lägga till en ny kontakt.
                            Console.Write("Ange namn: ");
                            string name = Console.ReadLine();
                            Console.Write("Ange e-postadress: ");
                            string email = Console.ReadLine();
                            Console.Write("Ange telefonnummer: ");
                            string phone = Console.ReadLine();

                            Contact newContact = new Contact
                            {
                                Name = name,
                                Email = email,
                                Phone = phone
                            };

                            contactList.AddContact(newContact);
                            Console.WriteLine("Kontakten har lagts till.");
                            break;
                        case 2:
                            // Ta bort en kontakt.
                            Console.WriteLine("Ange namn på kontakten du vill ta bort: ");
                            string nameToRemove = Console.ReadLine();
                            contactList.RemoveContact(nameToRemove);
                            Console.WriteLine("Kontakten har tagits bort!");
                            break;
                        case 3:
                            // Söka efter en kontakt.
                            Console.WriteLine("Ange namn på kontakten du vill söka efter: ");
                            string nameToFind = Console.ReadLine();
                            Contact foundContact = contactList.FindContact(nameToFind);
                            if (foundContact!=null)
                            {
                                Console.WriteLine($"Kontakt hittad: {foundContact.Name} - " +
                                    $"{foundContact.Email} - {foundContact.Phone} ");
                            }
                            else
                                Console.WriteLine("Kontakt ej hittad.");
                            break;
                        case 4:
                            // Visa hela kontaktlistan.
                            Console.WriteLine("Kontaktlista: ");
                            contactList.ShowAllContacts();
                            break;
                        case 5:
                            // Avsluta programmet och spara kontaktlistan.
                           // contactList.SaveToFile("contact.txt");
                            running = false;
                            Console.WriteLine("Programmet avslutas...");
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val. Försök igen.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig val. Försök igen.");
                }
                
            }
        }
    }

}

