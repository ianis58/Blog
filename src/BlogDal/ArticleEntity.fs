namespace BlogDal.Entities

module Article =

    open System
    open Author
    open Tag

    [<CLIMutable>]
    type Article =
        {
            ArticleId : Int32
            Title : String
            Date : DateTime
            Author : Author
            Tags : Tag list
            Paragraphs : String list
            CreatedDate : DateTime
            UpdatedDate : DateTime
        }