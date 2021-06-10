
using Ex1;

namespace Baithi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MobilePhone mobilePhone = new MobilePhone()
            mobilePhone.PhoneName = "Iphonelamson";
            mobilePhone.PhoneType = "mobile";
            mobilePhone.PhonePrice = 2001;
            mobilePhone.display();

            Phone phone = new Phone();
            phone.PhoneName = "Iphone11";
            phone.PhoneType = "phone";
            phone.PhonePirce = 2001;
            phone.display();
        }
    }
}