public class Entry{
    public string _entryName;
    public string _response;
    public string _dateOfEntry;
    public string _prompt;

    public Entry(string entryName, string prompt, string response){
        this._entryName = entryName;
        this._response = response;
        this._prompt = prompt;
        _dateOfEntry = DateTime.Now.ToShortDateString();
    }
    public Entry(string entryName, string dateOfEntry, string prompt, string response){
        this._entryName = entryName;
        this._response = response;
        this._prompt = prompt;
        this._dateOfEntry = dateOfEntry;

    }

    public string GetDisplay(){
        string stringDate = _dateOfEntry;

        return $"{_entryName} - {stringDate}\n{_prompt} - {FormatString(_response)}";
    }

    private string FormatString(string str){
        string subStr = "";
        if(str.Length <= 50){
            return str;
        }
        for(int i = 0; i < str.Length; i += 50){
            int length = Math.Min(50, str.Length - i);
            subStr += str.Substring(i, length) + "\n";
        }
        subStr = subStr.Substring(0, subStr.Length - 2);
        return subStr;
    }

    public string FormatForCSV(){
        return $"{_entryName}||{_dateOfEntry}||{_prompt}||{_response}";
    }
}