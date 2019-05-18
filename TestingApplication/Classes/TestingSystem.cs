using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace TestingApplication.Classes
{
    internal sealed class TestingSystem
    {
        private static readonly TestingSystem Instance;
        private readonly string _usersPath = "../../../ClassLibrary/XML/users.xml";
        
        internal MainForm MainParent { get; set; }

        static TestingSystem()
        {
            Instance = new TestingSystem();

            var thread = new Thread(User.CacheTests);

            thread.Start();
        }

        internal static TestingSystem GetInstance()
        {
            return Instance;
        }

        private TestingSystem()
        {
        }

        internal void Run()
        {
            var xDoc = XDocument.Load(_usersPath);

            // If file "users.xml" hasn't any user.
            if (xDoc.Root != null && !xDoc.Root.HasElements)
            {
                MainParent.RegisterAdmin();

                if (MainParent.DialogResult != DialogResult.Cancel)
                    Run();
            }
            else
            {
                MainParent.Login(out var login, out var password);

                // User closed a "Login" form.
                if (login == null && password == null)
                    return;

                try
                {
                    // Checking if user with this login is non-registered.
                    var nonRegisteredUser = xDoc.Root?.Elements("User").First(i =>
                    {
                        return StringCipher.Decrypt(i.Element("Login")?.Value) == login &&
                               i.Element("Password")?.Value == "" &&
                               i.Attribute("type")?.Value == "user";
                    });

                    var registeredUser = MainParent.RegisterUser(nonRegisteredUser);

                    if(registeredUser != null)
                        nonRegisteredUser?.ReplaceWith(registeredUser);

                    xDoc.Save(_usersPath);

                    Run();

                    return;
                }
                // Exception will throw if these login and password are already in XML-file.
                catch (Exception)
                {
                    // ignored
                }

                try
                {
                    var user = xDoc.Root?.Elements("User").First(i =>
                    {
                        return StringCipher.Decrypt(i.Element("Login")?.Value) == login &&
                               StringCipher.Decrypt(i.Element("Password")?.Value) == password;
                    });

                    if (user?.Attribute("type")?.Value == "admin")
                        MainParent.PrintAdminMenu();
                    else
                        MainParent.PrintUserMenu(user);
                }
                catch (Exception err)
                {
                    // If exception came from XDocument.
                    MainForm.ThrowException(err.Source == "mscorlib"
                        ? err.Message
                        : "You entered incorrect login or password. Try again");

                    Run();
                }
            }
        }
    }
}
