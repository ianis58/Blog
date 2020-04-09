namespace GiraffeApp

module Models =

    open System

    [<CLIMutable>]
    type Message =
        {
            Text : String
        }

    [<CLIMutable>]
    type Author =
        {
            FirstName : String
            LastName : String
            UserName : String
            Registered : DateTime
        }

    [<CLIMutable>]
    type Article =
        {
            Title : String
            Date : DateTime
            Author : Author
            Tags : String list
            Paragraphs : String list
        }
