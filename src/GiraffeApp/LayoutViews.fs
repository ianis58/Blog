namespace GiraffeApp.Views

module Layout =

    open Giraffe.GiraffeViewEngine

    let layout (content: XmlNode list) =
        html [] [
            head [] [
                title []  [ str "GiraffeApp" ]
                link [ _rel "stylesheet"; _href "/tailwind.css" ]
            ]
            body [ _class "bg-gray-100" ] content
        ]
