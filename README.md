# Smart Home System

A simulation of a smart home system showcasing object-oriented programming principles like abstraction, inheritance, polymorphism, and interface implementation in C#. The project features smart devices with unique behaviors and shared functionalities.

## Features

- **Abstract Class**: `SmartDevice` provides a base for all devices with common methods like `TurnOn` and `TurnOff`.
- **Interface**: `IAdjustable` defines adjustable settings for devices like volume or brightness.
- **Device Types**:
  - `Light`: Basic smart light functionality.
  - `AirConditioner`: Adjustable cooling level.
  - `SmartSpeaker`: Adjustable volume control.
- **Polymorphism**: Manage all devices in a unified list and interact with shared methods.
- **Dynamic Behavior**: Safely check and adjust settings for devices implementing `IAdjustable`.

## How It Works

1. Devices are created and added to a list.
2. The program loops through the list, calling shared and specific behaviors for each device.
3. Adjustable devices (like `AirConditioner` and `SmartSpeaker`) demonstrate dynamic adjustments.

## Getting Started

### Prerequisites
- Visual Studio or another C# IDE
- .NET framework installed

### Running the Program
1. Clone the repository:
   ```bash
   git clone https://github.com/PythonJuniorDev/SmartHomeSystem.git
