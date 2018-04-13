namespace AbstractFactory
{
    public class FlatWidgetFactory : WidgetFactory 
    {
        public Button createButton()
        {
            return new FlatButton();
        }

        public EditText createEditText()
        {
            return new FlatEditText();
        }
    }
}