using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WidgetFactory factory;
            Button button;
            EditText editText;

            factory = new MaterialWidgetFactory();
            button = factory.createButton();
            editText = factory.createEditText();

            button.showButton();
            editText.showEditText();

            factory = new FlatWidgetFactory();
            button = factory.createButton();
            editText = factory.createEditText();

            button.showButton();
            editText.showEditText();
        }
    }
}
