# game-systems-archtecture

# Preface
While working in a Game project, me and a co-worker started struggling with the situation where one couldn't easily implement another's new feature, since every Game System in our game included different components, rules and behaviours that needed to be premade in a scene before properly running it.</br>
Given this scenario, we abstracted our Game Systems to a Dicionary-like structure where the Game Controller holds every System passed through a Game Factory and, in case it is not yet instantiated in the scene, a prefab should be loaded in runtime into the scene

# How to use it
1 - Create a new C# Script that extends the abstract class GameSystem </br>
2 - Create a GameObject and rename it to the exactly name of your new Game System</br>
3 - Move the GameObject to "Resources/Prefabs/Game Systems" folder and delete it from the hierarchy</br>
4 - Open the GameFactory script and call a new gameController.InstantiateSystems with the desired GameSystem as the Generic Type</br>
5 - Run the scene. The new Game System will be instantiated automatically</br>

# Considerations
This archtecture was strongly inspired by TheLiquidFire's AspectContainer Archtecture. Check out his amazing work: http://theliquidfire.com/2017/08/28/make-a-ccg-aspect-container-test-runner/
