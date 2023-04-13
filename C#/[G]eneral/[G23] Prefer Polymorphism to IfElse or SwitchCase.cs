public void HandleInput(string inputType, string inputValue)
{
    switch (inputType)
    {
        case "button":
            HandleButtonInput(inputValue);
            break;
        case "keyboard":
            HandleKeyboardInput(inputValue);
            break;
        case "mouse":
            HandleMouseInput(inputValue);
            break;
        default:
            Console.WriteLine("Invalid input type.");
            break;
    }
}
// In this example, the HandleInput function takes an input device type and value
// and uses a switch construct to determine which processing method to use based on the input device type.
// This breaks the rule because the switch construct can be replaced by polymorphic objects,
// such as creating an InputDevice base class and derived classes for each device type,
// and using the HandleInput method within each class.

// The code to be used using polymorphism might look like this:
public abstract class InputDevice
{
    public abstract void HandleInput(string inputValue);
}

public class ButtonInputDevice : InputDevice
{
    public override void HandleInput(string inputValue)
    {
        // Button Input Handling
    }
}

public class KeyboardInputDevice : InputDevice
{
    public override void HandleInput(string inputValue)
    {
        // Keyboard Input Handling
    }
}

public class MouseInputDevice : InputDevice
{
    public override void HandleInput(string inputValue)
    {
        // Mouse Input Handling
    }
}

public void HandleInput(InputDevice inputDevice, string inputValue)
{
    inputDevice.HandleInput(inputValue);
}
// This avoids the switch statement and uses polymorphism instead.