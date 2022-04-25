using M1;



Phone phone1 = new Phone();

Console.WriteLine("Lūdzu, ievadi Telefona zīmolu");
string PhoneBrand = Console.ReadLine();
phone1.Brand = PhoneBrand;

Console.WriteLine("Lūdzu, ievadi Telefona modeli");
string PhoneModel = Console.ReadLine();
phone1.Model = PhoneModel;

Console.WriteLine("Lūdzu, ievadi Telefona garumu");
string PhoneLenght = Console.ReadLine();
phone1.Size = int.Parse(PhoneLenght);



Console.WriteLine($"Super aparats {phone1.Brand} {phone1.Model} ir {phone1.Size} cm garš");

phone1.Call();

phone1.Sms();
