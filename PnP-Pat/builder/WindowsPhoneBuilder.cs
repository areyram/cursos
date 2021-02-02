namespace Ventus
{
    internal class WindowsPhoneBuilder : IPhoneBuilder
    {
        public MobilePhone Phone { get; private set; }

        public WindowsPhoneBuilder()
        {
            Phone = new MobilePhone("Windows Phone");
        }

        public void BuildScreen()
        {
            Phone.PhoneScreen = ScreenType.TouchCapacitive;
        }

        public void BuildBattery()
        {
            Phone.PhoneBattery = Battery.Mah2000;
        }

        public void BuildOS()
        {
            Phone.PhoneOS = OperatingSystem.WindowsPhone;
        }

        public void BuildStylus()
        {
            Phone.PhoneStylus = Stylus.No;
        }
    }
}