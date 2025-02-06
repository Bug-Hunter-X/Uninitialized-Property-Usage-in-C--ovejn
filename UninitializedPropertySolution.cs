public class ExampleClass{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass() {
        MyProperty = 0; // Or any other initial value
    }

    public void MyMethod() {
        int value = MyProperty; // value will be 0, explicitly initialized

        MyProperty = 10;
        int newValue = MyProperty; // newValue will be 10
    }
}
// Alternative solution : initializing the property directly in the property declaration
public class ExampleClass{
    public int MyProperty { get; set; } = 0; // Initialize to 0
    
    public void MyMethod(){
        int value = MyProperty; // value will be 0
    }
} 