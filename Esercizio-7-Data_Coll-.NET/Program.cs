
HashSet<string> strings = new HashSet<string>();
strings.Add("Hello");
strings.Add("Hello");
strings.Add("Word");
strings.Add("Ciao");
strings.Add("Mondo");
strings.Add("mondo");
strings.Add("ciao");
strings.Add("Ciao");

foreach (string s in strings)  
    Console.WriteLine(s);   

//Come si può notare l'hashset considera uniche le stringhe che sono uguali lettera per lettera
//e facendo distizione fra le parole con l'iniziale maiuscola, considerandole quindi come stringhe diverse.
