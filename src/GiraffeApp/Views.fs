namespace GiraffeApp

module LayoutViews =

    open System
    open System.Globalization
    open Giraffe.GiraffeViewEngine

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
