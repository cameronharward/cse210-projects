using System;
using System.Collections.Concurrent;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Profile profile = new Profile();
        bool keepRunning = true;
        //Outer while loop for the intro section of the program
        while(keepRunning){
            Console.Clear();
            menu.DisplayMenu(1);
            string input = Console.ReadLine();
            if(String.IsNullOrWhiteSpace(input)){
                keepRunning = false;
                break;
            }
            string fileName = input + ".csv";
            if(File.Exists(fileName)){
                profile.LoadProfile(fileName);
            }
            bool innerLoop = keepRunning;
            while(innerLoop){ //inner while loop for the first level of interactions
                innerLoop = true;
                Console.Clear();
                profile.HalfDisplayPosts();
                menu.DisplayMenu(2);
                input = Console.ReadLine();
                switch(input){
                    case "1": //Post Selection
                        Console.Clear();
                        profile.HalfDisplayPosts();
                        System.Console.WriteLine("Enter the number of the post you would like to select(Starts from 1 onwards, top to bottom)");
                        input = Console.ReadLine();
                        if(Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > profile.numPosts()){
                            System.Console.WriteLine("Sorry that doesn't exist.");
                            Console.ReadLine();
                            break;
                        }
                        int postIndex = Convert.ToInt32(input) - 1;
                        bool selectLoop = innerLoop;
                        while(selectLoop){ //loop for selected post
                            selectLoop = true;
                            Console.Clear();
                            profile.LoadPost(postIndex);
                            menu.DisplayMenu(3);
                            input = Console.ReadLine();
                            switch(input){
                                case "1": //Leaving a comment on the post you selected
                                    Comment comment = new Comment();
                                    comment.GetComment();
                                    profile.Comment(postIndex, comment);
                                    break;
                                case "2": //Going back to the full list of posts
                                    selectLoop = false;
                                    break;
                                case "3"://Exiting the program
                                    selectLoop = false;
                                    innerLoop = false;
                                    keepRunning = false;
                                    profile.saveProfile(fileName);
                                    break;
                                default:
                                    System.Console.WriteLine("Not a valid option");
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        break;
                    case "2": //Creating a new post
                        Console.Clear();
                        menu.DisplayMenu(4);
                        input = Console.ReadLine();
                        switch(input){
                            case "1": //create a basic post
                                string title = "";
                                string desc = "";

                                System.Console.WriteLine("Title your post.");
                                title = Console.ReadLine();

                                System.Console.WriteLine("Write your post.");
                                desc = Console.ReadLine();

                                Post post = new Post(title, desc);
                                profile.AddPost(post);
                                System.Console.WriteLine("Congrats on adding your new post!");
                                Console.ReadLine();
                                break;
                            case "2": //Create a media post
                                string mTitle = "";
                                string mDesc = "";
                                string url = "";

                                System.Console.WriteLine("Title your post.");
                                mTitle = Console.ReadLine();

                                System.Console.WriteLine("Write your post.");
                                mDesc = Console.ReadLine();

                                System.Console.WriteLine("Write or paste in the url to the media you are trying to share.");
                                url = Console.ReadLine();

                                MediaPost mPost = new MediaPost(mTitle, mDesc, url);
                                profile.AddPost(mPost);
                                System.Console.WriteLine("Congrats on adding your new media post");
                                break;
                            case "3": //Create a Spoiler Post
                                string sTitle = "";
                                string sDesc = "";
                                string topic = "";

                                System.Console.WriteLine("Title your post.");
                                sTitle = Console.ReadLine();

                                System.Console.WriteLine("Write your post.");
                                sDesc = Console.ReadLine();

                                System.Console.WriteLine("What is this post spoiling?");
                                topic = Console.ReadLine();

                                SpoilerPost sPost = new SpoilerPost(sTitle, sDesc, topic);
                                profile.AddPost(sPost);
                                System.Console.WriteLine("Congrats on adding your post!");
                                break;
                            case "4": //Create a quote post
                                if(profile.numPosts() < 1){
                                    System.Console.WriteLine("No posts to quote!");
                                    break;
                                }
                                Console.Clear();
                                profile.HalfDisplayPosts();
                                System.Console.WriteLine("Choose which post to quote! (1 at the top going down)");
                                input = Console.ReadLine();
                                string quote = profile.StealDesc(Convert.ToInt32(input) - 1);

                                string qTitle = "";
                                string qDesc = "";

                                System.Console.WriteLine("Title your post.");
                                qTitle = Console.ReadLine();

                                System.Console.WriteLine("Write your post.");
                                qDesc = Console.ReadLine();

                                QuotePost qPost = new QuotePost(qTitle, qDesc, quote);
                                profile.AddPost(qPost);
                                System.Console.WriteLine("Congrants on adding your post!");
                                break;
                            default:
                                break;

                        }
                        break;
                    case "3":
                        profile.saveProfile(fileName);
                        profile.ResetProfile();
                        innerLoop = false;
                        break;
                    case "4":
                        profile.saveProfile(fileName);
                        innerLoop = false;
                        keepRunning = false;
                        break;

                }
            }

        }





    }
}