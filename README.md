# WPF-Safari Park
Safari Project used to learn more about **SOLID** principles

* **Single Responsibility Principle**
  * Each class should do 1 thing or have one reason to change
* **Open, Closed Principle**
  * Classes should be open for extension but closed for modification
* **Liskov Substitution Principle**
  * Subclasses should be substitutable by their based classes
* **Interface Segregation Principle**
  * Best to have smaller interfaces than larger ones
  * Decreases likelihood of developers from partially implementing an interface
* **Dependency Inversion Principle**
  * Higher modules should be **not** be dependent lower modules **but BOTH should be dependent** on abstraction 





## Key Sections included

* Created an **Abstract** Person class
  - This was further extended using **Inheritance** to create a **Hunter** and a **Ranger** class
* Each type of Person **implements** an **interface** called IShootable
  - This interface is a silent contract used to force each class to implement specific methods to allow the class to "Shoot"

* Moveable objects have been created that can increase or decrease the position of value 

##### Class Diagram

![Class Diagram]()



## Current functionalities

* A ranger can currently shoot at a **list of Hunters**
  -  A Ranger has a certain probability to **successfully** shoot at a Hunter
  - No matter the result the **output is displayed on the console**
  - Depending on the weapon used a **different output will be displayed on the console**
* A Ranger also has the ability to heal another ranger
  * This is still under progress

* A hunter can currently shoot using a range of weapons similar to the ranger
  * The result of shooting a weapon will also be displayed on the **Console**





## Future Plans

* A ranger will be able to heal an animal or another range and increase their health by a certain amount
* A hunter will have the ability to hurt a ranger or an animal
* Possibly create a GUI to add new animals, hunters, rangers and display the result in a certain manner
  * Possibly like a story line