namespace BlogDal.Entities

module Tag =

    open System

    [<CLIMutable>]
    type Tag =
        {
            TagId : Int32
            Label : String
            CreatedDate : DateTime
            UpdatedDate : DateTime
        }