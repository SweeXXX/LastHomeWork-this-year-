#define DEBUG_ACCOUNT
using System;
using System.Reflection;

namespace T14
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(TypeAccount.accountCurrent, 2040000);
            account.Withdraw(4234);
            account.DumpToScreen();

            MemberInfo typeInfo = typeof(Building);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            foreach (object attrObj in attrs)
            {
                if (attrObj is DeveloperInfo2Attribute attr)
                {
                    Console.WriteLine($"Разработчик \"Building\": {attr.NameDeveloper}");
                    Console.WriteLine($"Организация:{attr.NameOrganization}");
                }
            }
        }
    }
}