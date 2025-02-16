using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string reference = "2 Nephi 2:27-28";

        List<Verse> verses = new List<Verse>();

        string firstVerse = "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.";
        string secondVerse = "And now, my sons, I would that ye should look to the great Mediator, and hearken unto his great commandments; and be faithful unto his words, and choose eternal life, according to the will of his Holy Spirit;";

        verses.Add(new Verse(firstVerse));
        verses.Add(new Verse(secondVerse));

        Scripture scripture = new Scripture(reference, verses);
        List<int> hasUnhidden = new List<int>();
        for(int i = 0; i < scripture.GetVerseTotal(); i++){
            hasUnhidden.Add(i);
        }
        System.Console.WriteLine(scripture.GetFormattedString());
        string ending = "Program has finished or has quit.";

        bool finished = false;
        int hideIncrement = 3;
        while(!finished){
            if(finished){
                break;
            }

            System.Console.Write("Press 'Enter' to continue or 'quit' to quit: ");
            string input = Console.ReadLine();
            if(input == "quit"){
                break;
            }
            for(int i = 0; i < hideIncrement; i++){

                bool usableVerse = true;
                int verse = 1;
                while(usableVerse){
                    if(hasUnhidden.Count == 0){
                        finished = true;
                        break;
                    }
                    verse = hasUnhidden[random.Next(0, hasUnhidden.Count)];
                    if(scripture.GetVerseHidden(verse)){
                        hasUnhidden.Remove(verse);
                        continue;
                    }
                    usableVerse = false;
                }

                HideWord(verse, scripture);
            }


            Console.Clear();
            System.Console.WriteLine(scripture.GetFormattedString());


        }

        System.Console.WriteLine(ending);
    }
        static bool HideWord(int verseIndex, Scripture scripture){
            Random random = new Random();
            return scripture.HideWord(verseIndex);

}
}

