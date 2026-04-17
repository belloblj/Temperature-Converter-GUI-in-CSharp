# Temperature Converter App

A Windows Forms application built with .NET Framework 4.8 that converts temperatures between Fahrenheit and Celsius with live updates.

## Features

### Live Temperature Conversion
- **Real-time updates**: As you type a temperature value, the conversion happens instantly
- **Bidirectional conversion**: Convert from Fahrenheit to Celsius or vice versa
- **Visual feedback**: Temperature values are displayed with their unit symbols (°F or °C)

### Conversion Modes
The app supports two conversion modes that can be toggled:

1. **Fahrenheit to Celsius (Default)**
   - Enter a temperature in Fahrenheit in the first field
   - The Celsius equivalent appears automatically in the second field
   - Button label: "Switch to C → F"

2. **Celsius to Fahrenheit**
   - Enter a temperature in Celsius in the second field
   - The Fahrenheit equivalent appears automatically in the first field
   - Button label: "Switch to F → C"

## How to Use

### Converting Temperature
1. **Default Mode (F → C):**
   - Type a temperature value in the "Enter Temperature in F:" field
   - The converted Celsius value appears instantly in the "Temperature in °C:" field

2. **Switch Modes:**
   - Click the purple **"Switch to C → F"** button to reverse the conversion direction
   - Labels and button text update to reflect the new mode
   - Both input fields are cleared when switching modes

3. **Reset Fields:**
   - Click the red **"Reset"** button to clear all temperature values
   - The focus returns to the input field, ready for new data

### Input Guidelines
- Enter valid numeric values (integers or decimals)
- The app automatically strips unit symbols (°F, °C) when processing input
- Invalid characters are ignored during conversion
- Empty fields result in a cleared output field

## Conversion Formulas

- **Fahrenheit to Celsius**: °C = (°F - 32) × 5/9
- **Celsius to Fahrenheit**: °F = (°C × 9/5) + 32

Results are displayed with two decimal places for precision.

## Technical Details

- **Framework**: .NET Framework 4.8
- **UI Framework**: Windows Forms
- **Language**: C#
- **Architecture**: Event-driven GUI with real-time data binding

### Key Components

| Component | Purpose |
|-----------|---------|
| `textBoxFahrenheit` | Primary input field for temperature values |
| `textBoxCelsius` | Secondary input field or display field depending on mode |
| `buttonToggle` | Switches conversion direction between F↔C |
| `buttonReset` | Clears all input and output fields |
| `isFahrenheitToCelsius` | Flag that tracks current conversion mode |
| `isUpdating` | Flag that prevents recursive updates during conversion |

<img width="511" height="358" alt="image" src="https://github.com/user-attachments/assets/bf972446-6b60-44ef-a0eb-ca47c6636219" />

## How It Works

1. When you type in either temperature field, the `TextChanged` event fires
2. The app checks the current conversion mode using the `isFahrenheitToCelsius` flag
3. If valid input is detected, the conversion formula is applied
4. The result is formatted with two decimal places and the appropriate unit symbol
5. The output is displayed in the corresponding field

The `isUpdating` flag prevents infinite loops by temporarily disabling event handlers while the app is processing conversions.

## Notes

- The app preserves accuracy by storing calculations as doubles before converting to strings
- Unit symbols are automatically appended to converted values
- The app gracefully handles invalid input by ignoring conversion errors
- Focus is automatically returned to the input field after reset
