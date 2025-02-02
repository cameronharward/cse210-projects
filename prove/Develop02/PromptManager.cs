using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Net.Mail;

public class PromptManager{
    List<string> prompts = new List<string>{
        "What are you most thankful for today?",
        "Talk about the funniest thing that happened to you today?",
        "What emotion did you feel the most today?",
        "How can you improve on something you did today tomorrow?",
        "Write whatever you want today."};

    public string GetPrompt(){
        Random random = new Random();
        int index = random.Next(0, prompts.Count - 1);
        return prompts[index];
    }
    

}