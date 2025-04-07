public class Comment{
    private string _com;
    private string _name;

    public Comment(){

    }
    public Comment(string com, string name){
        this._com = com;
        this._name = name;
    }
    public string Display(){
        return $"{_name} says: {_com}";
    }
    public void GetComment(){
        System.Console.Write("First name of whoever is posting this comment:");
        string input = Console.ReadLine();
        _name = input;
        System.Console.WriteLine("Comment:");
        input = Console.ReadLine();
        _com = input;
    }
    public string GetFormat(){
        return $"{_name}|{_com}|";
    }
}