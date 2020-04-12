namespace BlogApp.Views

module Article =

    open System
    open Giraffe.GiraffeViewEngine
    open BlogApp.Models
    open BlogApp.Views.Layout
    open BlogApp.Views.Utilities

    let partialContent (paragraphs : String list) =
        div [ _class "text-lg font-serif text-black leading-normal text-justify" ] [
            yield!
                paragraphs
                |> List.map (fun paragraph -> p [ _class "my-5" ] [ str paragraph ] )
        ]

    let partialTags (tags : String list) =
        div [ _class "text-right text-white italic" ] [
            yield!
                tags
                |> List.map (fun tag -> span [ _class "bg-black mx-2 p-1 tag select-none border-transparent border" ] [ sprintf "#%s" tag |> str ] )
        ]
    
    let partialAuthorFullName (author : Author) = sprintf "%s %s" author.FirstName author.LastName

    let articleView (article : Article) =
        [
            div [ _class "mb-10 mx-56"] [
                    h1 [ _class "font-extrabold text-4xl font-sans text-justify" ] [ str article.Title ]
                    i [ _class "text-base text-black" ]
                        [ sprintf "Posté le %s par %s" (dateFormatDayMonthYear article.Date) (partialAuthorFullName article.Author)
                          |> str ]
                    partialContent article.Paragraphs
                    partialTags article.Tags
                ]

        ] |> layout
