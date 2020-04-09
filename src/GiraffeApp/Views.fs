namespace GiraffeApp

module Views =

    open System
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
            body [] content
        ]

    let partialArticleContent (paragraphs : String list) =
        div [] [
            yield!
                paragraphs
                |> List.map (fun paragraph -> p [] [ str paragraph ] )
        ]

    let articleView (article : Article) =
        [
            div [ _class "container"] [
                    h3 [ _title "le titre de l'article"] [ str article.Title ]
                    i [] [ str article.Author.UserName ]
                    partialArticleContent article.Paragraphs
                ]

        ] |> layout
