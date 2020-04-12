namespace GiraffeApp.Views

module Layout =

    open Giraffe.GiraffeViewEngine

    let layout (content: XmlNode list) =
        html [] [
            head [] [
                title []  [ str "GiraffeApp" ]
                link [ _rel "stylesheet"; _href "/tailwind.css" ]
                link [ _rel "stylesheet"; _href "/blog.css" ]
            ]
            body [ _class "bg-gray-100" ] [
                div [ _class "mx-56 select-none border-b border-black menu" ] [
                    a [ _class "inline-block py-4 w-1/4 text-center menu-item h-full"; _href "/" ] [ str "Home" ]
                    a [ _class "inline-block py-4 w-1/4 text-center menu-item h-full"; _href "/categories" ] [ str "Categories" ]
                    a [ _class "inline-block py-4 w-1/4 text-center menu-item h-full"; _href "/about" ] [ str "About" ]
                    a [ _class "inline-block py-4 w-1/4 text-center menu-item h-full"; _href "/contact" ] [ str "Contact" ]
                ]
                div [] content
            ]
        ]
