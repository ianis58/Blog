namespace BlogApp.Models

module Article =

    open System
    open Author
    open Tag

    [<CLIMutable>]
    type Article =
        {
            Title : String
            Date : DateTime
            Author : Author
            Tags : Tag list
            Paragraphs : String list
        }