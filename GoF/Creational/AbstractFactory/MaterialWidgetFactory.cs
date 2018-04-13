namespace AbstractFactory
{
    public class MaterialWidgetFactory : WidgetFactory
    {
        public Button createButton()
        {
            return new MaterialButton();
        }

        public EditText createEditText()
        {
            return new MaterialEditText();
        }
    } 
}