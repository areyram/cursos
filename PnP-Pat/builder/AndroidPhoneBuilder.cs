namespace Ventus
{
    class AndroidPhoneBuilder : IPhoneBuilder
    {
        public MobilePhone Phone { get; private set; }

        public AndroidPhoneBuilder()
        {
            Phone = new MobilePhone("Android Phone");
        }

        public void BuildScreen()
        {
            Phone.PhoneScreen = ScreenType.TouchResistive;
        }

        public void BuildBattery()
        {
            Phone.PhoneBattery = Battery.Mah1500;
        }

        public void BuildOS()
        {
            Phone.PhoneOS = OperatingSystem.Android;
        }

        public void BuildStylus()
        {
            Phone.PhoneStylus = Stylus.Yes;
        }
    }
}