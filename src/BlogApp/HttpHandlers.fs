module BlogApp.HttpHandlers

    open Microsoft.AspNetCore.Http
    open FSharp.Control.Tasks.V2.ContextInsensitive
    open Giraffe
    open BlogApp.Views.Article
    open BlogApp.Data.Articles

    let handleGetIndex =
        fun (next : HttpFunc) (ctx : HttpContext) ->
            task {
                return! ctx.WriteHtmlViewAsync (articleView articleExample)
            }
