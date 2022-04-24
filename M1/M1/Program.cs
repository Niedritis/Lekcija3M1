using M1;



Phone phone1 = new Phone();



phone1.Size = 15;
phone1.Brand = "nokia";
phone1.Model = "galaxy";

string phonename = phone1.Brand;

string phonemodel = phone1.Model;

Console.WriteLine($"apsveicu jauns telefons {phonename} modelis {phonemodel}");

phone1.Call();

phone1.Sms();
