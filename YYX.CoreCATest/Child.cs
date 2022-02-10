namespace YYX.CoreCATest
{
    public class Child : Parent
    {
        private string foo;

        public Child()
        {
            foo = "HELLO";

        }

        protected override void DoSomething()
        {
            Console.WriteLine(foo.ToLower()); //NullReferenceException!?!
        }
    }
}
