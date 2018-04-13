namespace AbstractFactory
{
    public interface WidgetFactory 
    {
        Button createButton();
        EditText createEditText();
    }
}