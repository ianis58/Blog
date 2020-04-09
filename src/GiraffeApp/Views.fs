namespace GiraffeApp

module Views =

    open System
    open System.Globalization
    open Giraffe.GiraffeViewEngine
    open GiraffeApp.Models

    let layout (content: XmlNode list) =
        html [] [
            head [] [
                title []  [ str "GiraffeApp" ]
                link [ _rel "stylesheet"; _href "/tailwind.css" ]
                link [ _rel "stylesheet"; _href "/base.css" ]
                link [ _rel "stylesheet"; _href "/components.css" ]
                link [ _rel "stylesheet"; _href "/utilities.css" ]
            ]
            body [ _class "bg-gray-100" ] content
        ]

    let partialArticleContent (paragraphs : String list) =
        div [ _class "text-lg font-serif text-gray-800 leading-normal mx-12 text-justify" ] [
            yield!
                paragraphs
                |> List.map (fun paragraph -> p [ _class "my-5" ] [ str paragraph ] )
        ]

    let partialArticleTags (tags : String list) =
        div [ _class "mx-12 text-right text-gray-100 italic" ] [
            yield!
                tags
                |> List.map (fun tag -> span [ _class "bg-gray-800 mx-2 p-1" ] [ sprintf "#%s" tag |> str ] )
        ]
    
    let authorFullName (author : Author) = sprintf "%s %s" author.FirstName author.LastName

    let cultureInfo = CultureInfo("en-US")

    let monthddYYYY (date : DateTime) = date.ToString("MMMM dd, yyyy", cultureInfo)

    let articleView (article : Article) =
        [
            div [ _class "mb-10 mx-48"] [
                    h1 [ _class "font-extrabold text-4xl font-sans" ] [ str article.Title ]
                    i [ _class "text-base" ]
                        [ sprintf "Posted by %s on %s" (authorFullName article.Author) (monthddYYYY article.Date)
                          |> str ]
                    partialArticleContent article.Paragraphs
                    partialArticleTags article.Tags
                ]

        ] |> layout
