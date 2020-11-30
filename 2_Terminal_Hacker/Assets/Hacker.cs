using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    string[] level1Password = {"criminal", "prison", "selfish", "knife", "manuel"};
    string[] level2Password = {"telescope", "perspective", "algebra", "astronaut", "spaceship"};
    string[] level3Password = {"Polonezköydeyim"};
    const string backToMenu = "You may type menu at anytime.";
    int level;
    string password;


    enum Screen{MainMenu, Password, Win};
    Screen currentScreen;
    void Start()
    {
        ShowMainMenu("Hello Stranger\r\n");
    }
    void ShowMainMenu(string greetings)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(greetings);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the police station");
        Terminal.WriteLine("Press 2 for NASA");
        Terminal.WriteLine("Press 3 to find Yunus");

    }
    void OnUserInput(string input){
        if(input == "menu"){
            ShowMainMenu("Hello Stranger");
        }else if(currentScreen == Screen.MainMenu){
            RunMainMenu(input);
        }else if (currentScreen == Screen.Password){
            TypePassword(input);
        }
    }
    void TypePassword(string input){
        if(input == password){
            showWinScreen();
        }else {
            Terminal.WriteLine("Try Again or type \"menu\" to go back");
        }
    }
    void showWinScreen(){
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        showLevelReward();
    }

    void showLevelReward(){
        switch(level){
            case 1:
            Terminal.WriteLine(@"
          _  __________=__
           \\@([____]_____()
          _/\|-[____]
         /     /(( )
        /____|'----'
        \____/");
            Terminal.WriteLine("\r\nYou've hacked into police station!");
            break;

            case 2:
            Terminal.WriteLine(@"
         _ __   __ _ ___  __ _ 
        | '_ \ / _` / __|/ _` |
        | | | | (_| \__ \ (_| |
        |_| |_|\__,_|___/\__,_|
                       
            ");
            Terminal.WriteLine("You've hacked into Nasa!");
            break;

            case 3:
            Terminal.WriteLine(@"

                          . : .
          __________    '.  :  .'
         /         /\__.__'.:.'  .
         \_________\/  .  .':'.  .
                        .'  :  '.
                          ' : '
                          
            ");
            Terminal.WriteLine("You've saved Yunus from Polonezköy!");
            break;
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidNumber = (input == "1" || input == "2" || input == "3");
        if (isValidNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if(input == "menu")
        {
            ShowMainMenu("Hello Again!");
        }else
        {
            Terminal.WriteLine("Please choose a valid level!");
        }
    }

    void StartGame(){
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch (level){
            case 1:
            password = level1Password[Random.Range(0, level1Password.Length)];
            break;

            case 2:
            password= level2Password[Random.Range(0, level2Password.Length)];
            break;

            case 3:
            password = level3Password[Random.Range(0, level3Password.Length)];
            break;

            default:
            Debug.LogError("Invalid level number");
            break;

        }
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password. Your Hint: " + password.Anagram());
        Terminal.WriteLine(backToMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
