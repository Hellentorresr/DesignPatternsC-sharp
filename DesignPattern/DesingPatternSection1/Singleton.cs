namespace DesingPatternSection1
{
    public class Singleton
    {
        static Singleton? instance; //Self referencing property
        public string Setting { get; set; } = "color blue";

        //the constructor is protected
        protected Singleton() { }

        //creating a static method that is
        public static Singleton Instance()
        {
            instance ??= new Singleton();// is using the null-coalescing assignment operator (??=) to assign a new instance of the Singleton class to the variable instance if it is currently null.
            return instance;
        }
    }
}


/*Typically, in the singleton pattern, you would have a private constructor
 * in the Singleton class, preventing the direct creation of instances from outside the class.
 * Instead, you would typically use a static method or property
 * to access the single instance, like Singleton.Instance or Singleton.GetInstance().
 * Provide a static property or method in the Singleton class that returns the single instance of the class.
 */
