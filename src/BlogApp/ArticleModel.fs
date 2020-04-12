namespace BlogApp.Models

module Article =

    open System
    open Author

    [<CLIMutable>]
    type Article =
        {
            Title : String
            Date : DateTime
            Author : Author
            Tags : String list
            Paragraphs : String list
        }