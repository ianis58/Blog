namespace BlogDal.Entities

module Author =

    open System

    [<CLIMutable>]
    type Author =
        {
            AuthorId : Int32
            FirstName : String
            LastName : String
            UserName : String
            CreatedDate : DateTime
            UpdatedDate : DateTime
        }