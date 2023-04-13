public void handleInput(String inputType, String inputValue) {
    switch (inputType) {
        case "button":
            handleButtonInput(inputValue);
            break;
        case "keyboard":
            handleKeyboardInput(inputValue);
            break;
        case "mouse":
            handleMouseInput(inputValue);
            break;
        default:
            System.out.println("Invalid input type.");
            break;
    }
}
// In this example, the HandleInput function takes an input device type and value
// and uses a switch construct to determine which processing method to use based on the input device type.
// This breaks the rule because the switch construct can be replaced by polymorphic objects,
// such as creating an InputDevice base class and derived classes for each device type,
// and using the HandleInput method within each class.

// The code to be used using polymorphism might look like this:
public abstract class InputDevice {
    public abstract void handleInput(String inputValue);
}

public class ButtonInputDevice extends InputDevice {
    @Override
    public void handleInput(String inputValue) {
        // Button Input Handling
    }
}

public class KeyboardInputDevice extends InputDevice {
@Override
    public void handleInput(String inputValue) {
        // Keyboard Input Handling
    }
}

public class MouseInputDevice extends InputDevice {
    @Override
    public void handleInput(String inputValue) {
        // Mouse Input Handling
    }
}

public void handleInput(InputDevice inputDevice, String inputValue) {
    inputDevice.handleInput(inputValue);
}
// This avoids the switch statement and uses polymorphism instead.