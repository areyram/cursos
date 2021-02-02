namespace Ventus
{
    internal class MobilePhone
    {
        public MobilePhone(string name)
        {
            PhoneName = name;
        }

        // Public properties to access phone parts
        public string PhoneName { get; private set; }
        public ScreenType PhoneScreen { get; set; }
        public Battery PhoneBattery { get; set; }
        public OperatingSystem PhoneOS { get; set; }
        public Stylus PhoneStylus { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nScreen: {1}\nBattery {2}\nOS: {3}\nStylus: {4}",
                PhoneName, PhoneScreen, PhoneBattery, PhoneOS, PhoneStylus);
        }
    }
}