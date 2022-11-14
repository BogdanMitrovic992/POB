using PageObjectModelTest.Helper;
using PageObjectModelTest.Page;

namespace PageObjectModelTest
{
    public class Tests:Base  
    {
        Practiceform form;

        [Test]
        public void Test1()
        {
            form = new Practiceform();
            form.EnterName("Bogdan");
            form.EnterLastName("Mitrovic");
            form.EnterEmail("mitrovicbogdan992@gmail.com");
            form.EnterPhone("1234567890");
            form.EnterSubject("Math");
            form.SelectGender();
            form.SelectHobbis();
            form.Button.Submit();

            

        }
    }
}