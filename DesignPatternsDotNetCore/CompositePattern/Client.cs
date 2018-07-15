namespace CompositePattern
{
    public class Client
    {
        private readonly MenuComponent _menus;

        public Client(MenuComponent menus)
        {
            _menus = menus;
        }

        public void Print()
        {
            _menus.Print();
        }
    }
}