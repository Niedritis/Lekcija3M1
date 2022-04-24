namespace M1
{
    internal class Phone
    {
        public double Size { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Call()
        {
            Console.WriteLine("Calling to Artis");
        }

        public void Sms()
        {
            Console.WriteLine("SMS sent to Artis");
        }

    }
}
