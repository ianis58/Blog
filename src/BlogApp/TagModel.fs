namespace BlogApp.Models

module Tag =

    open System

    [<CLIMutable>]
    type Tag =
        {
            Label : String
        }