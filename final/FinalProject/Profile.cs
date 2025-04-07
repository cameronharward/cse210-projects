public class Profile{
    private List<Post> _posts = [];

    public Profile(){

    }

    public void LoadProfile(string profileName){
        _posts.Clear();
        string[] posts = File.ReadAllLines(profileName);
        foreach(string line in posts){
            string[] parts = line.Split("|");
            switch(parts[0]){
                case "Post": //BasicPost Load
                    Post post = new Post(parts[1], parts[2]);
                    if(parts.Count() <= 3)
                        break;
                    for(int i = 3; i < parts.Count() -1; i += 2){
                        post.AddComment(new Comment(parts[i], parts[i+1]));
                    }
                    _posts.Add(post);
                    break;
                case "MediaPost": //MediaPost load
                    MediaPost mPost = new MediaPost(parts[1], parts[2],parts[3]);
                    if(parts.Count() <= 4)
                        break;
                    for(int i = 4; i < parts.Count() -1; i += 2){
                        mPost.AddComment(new Comment(parts[i], parts[i+1]));
                    }
                    _posts.Add(mPost);
                    break;
                case "QuotePost": //QuotePost load
                    QuotePost qPost = new QuotePost(parts[1], parts[2], parts[3]);
                    if(parts.Count() <= 4)
                        break;
                    for(int i = 4; i < parts.Count()-1; i += 2){
                        qPost.AddComment(new Comment(parts[i], parts[i+1]));
                    }
                    _posts.Add(qPost);
                    break;
                case "SpoilerPost": //SpoilerPost
                    SpoilerPost sPost = new SpoilerPost(parts[1],parts[2], parts[3]);
                    if(parts.Count() <= 4)
                        break;
                    for(int i = 4; i < parts.Count()-1; i += 2){
                        sPost.AddComment(new Comment(parts[i], parts[i+1]));
                    }
                    _posts.Add(sPost);
                    break;
                default:
                    break;
            }
        }
    }
    public void saveProfile(string profileName){
        using (StreamWriter outputFile = new StreamWriter(profileName)){
            foreach(Post post in _posts){
                outputFile.WriteLine(post.GetFormat());
            }
    }
}
    public void HalfDisplayPosts(){
        if(_posts.Count() == 0){
            System.Console.WriteLine("This profile has no posts yet!");
        }
        else{
        foreach(Post post in _posts){
            System.Console.WriteLine(post.HalfDisplay());
        }
        }
    }
    public int numPosts(){
        return _posts.Count();
    }
    public void AddPost(Post post){
        _posts.Add(post);
    }
    public void LoadPost(int postIndex){
        System.Console.WriteLine(_posts[postIndex].FullDisplay());
    }
    public void Comment(int postIndex, Comment comment){
        _posts[postIndex].AddComment(comment);
    }
    public string StealDesc(int postIndex){
        string desc = _posts[postIndex].GetDesc();
        return desc;
    }
    public void ResetProfile(){
        _posts.Clear();
    }
}