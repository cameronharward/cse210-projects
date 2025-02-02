using System.IO;
public class Journal{
    public List<Entry> _entries = new List<Entry>();


    public string GetDisplay(){
        string display = "";
        foreach(Entry entry in _entries){
            display += "\n=========================\n" + entry.GetDisplay();
        }
        return display;
    }

    public void CreateEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void LoadJournal(string fileName){
        _entries.Clear();
        string[] entries = File.ReadAllLines(fileName);
        foreach(string line in entries){
            string[] parts = line.Split("||");
            string name = parts[0];
            string date = parts[1];
            string prompt = parts[2];
            string response = parts[3];

            Entry entry = new Entry(name, date, prompt, response);
            CreateEntry(entry);
        }

    }

    public void SaveJournal(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(Entry entry in _entries){
                outputFile.WriteLine(entry.FormatForCSV());
            }
   
        }

    }

}