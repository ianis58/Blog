namespace BlogApp.Models

module Author =

    open System

    [<CLIMutable>]
    type Author =
        {
            FirstName : String
            LastName : String
            UserName : String
            Registered : DateTime
        }