using System.Collections;

public class Menu{
    private string _intro = "Enter a profile name(first name only) that you would like to use. Otherwise, press enter to quit.";
    private string _viewMenu = "\nOptions:\n1. Select a post\n2. Create Post\n3. Choose a different profile\n4. Exit the program";
    private string _interact = "\nOptions:\n1. Leave a comment\n2. Go back to the other posts\n3. Exit the program";
    private string _createPost = "Which post type would you like to create:\n1. Regular Post\n2. Media Post\n3. Spoiler Post\n4. Quote Post(Needs an available post to quote)\n5. I changed my mind.";

    public Menu(){

    }
    public void DisplayMenu(int menuIndex){
        switch(menuIndex){
            case 1:
                System.Console.WriteLine(_intro);
                break;
            case 2:
                System.Console.WriteLine(_viewMenu);
                break;
            case 3:
                System.Console.WriteLine(_interact);
                break;
            case 4:
                System.Console.WriteLine(_createPost);
                break;
            default:
                break;
        }
    }
}