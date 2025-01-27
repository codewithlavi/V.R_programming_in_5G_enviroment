# # Float Sphere a.k.a La bolita voladora 
This floating sphere is an A.R application that allows users to interact with a virtual sphere in a real-world environment. This app offers an immersive experience using AR technology.

## Features :
Real-time Interaction:** The ball responds to phone and user movements on the given printed image. 

 Creation steps of the AR app :

1st step-->Preparation:
    The verion of Unity has to be 6 or higher and with the installed with support for Android and AR Foundation.

    Create a new project in Unity- Universal 3D Core-in organization has to be filled with Vuforia account .
2nd step--> Project Configuration:

    Import AR Foundation and ARCore XR Plugin from the Unity Package Manager.

    Set up your project for Android in File > Build Settings.

3rd step--> Creating the Unity Scene:

    Create a new scene and add an AR Session and AR Session Origin.

4th step--> Import the printed image that you want to use (Assets > Import New Asset).

    Create an empty GameObject and name it "ImageAnchor"

    Drag the image onto the ImageAnchor.

5th step--> Create a C# script called FloatSphere 

6th step--> Scene Implementation in Unity:

    Create a sphere in Unity (GameObject > 3D Object > Sphere) and turn it into a prefab.

    Assign AR Tracked Image Manager to the AR Session Origin object.

    Assign your image as a Reference Image in the AR Tracked Image Manager.

    Add the FloatSphere script to the AR Session Origin and drag your sphere prefab to the script.

7th step--> Building the .APK:

    Set up build options for Android (File > Build Settings).

    Build and install the app on your Android device.
    
## Installation
1. Clone this repository.
    ```
    git clone https://github.com/codewithlavi/flying-ball.git
    ```
2. Navigate to the project directory.
    ```
    cd flying-ball
    ```
3. Run the application.
    ```
    open build.apk
    ```
## Usage
1. Open the app on your mobile device and it has to be Android 7 or higher
2. Allow access to the camera.
3. Scan the environment to see the flying ball in action.

## License
This project is licensed under the MIT License. See the `LICENSE` file for details.
author :Lavinia (@codewithlavi)
___________________________________________________________________________________________________________________________________________________________________________
Spanish version#Español

 ## Bolita Voladora

"La Bolita Voladora" es una aplicación de realidad aumentada para Android que permite a los usuarios interactuar con una esfera virtual en un entorno real. 
 Esta aplicación ofrece una experiencia inmersiva utilizando tecnología de R.A.

## Características
- **Interacción en tiempo real:** La bolita responde a los movimientos del movíl y del usuario.

## Instalación
1. Clona este repositorio.
    ```
    git clone https://github.com/codewithlavi/bolita-voladora.git
    ```
2. Navega al directorio del proyecto.
    ```
    cd bolita-voladora
    ```
3. Ejecuta la aplicación.
    ```
    open build.apk
    ```
## Uso :
1. Abre la aplicación en tu dispositivo móvil Android 7 o superior.
2. Permite el acceso a la cámara.
3. Escanea el entorno para ver la bolita voladora en acción.
## Licencia
Este proyecto está bajo la licencia MIT. Ver el archivo `LICENSE` para más detalles
autor :Lavinia (@codewithlavi)






