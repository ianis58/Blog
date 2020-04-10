module GiraffeApp.HttpHandlers

    open Microsoft.AspNetCore.Http
    open FSharp.Control.Tasks.V2.ContextInsensitive
    open Giraffe
    open GiraffeApp.Models
    open GiraffeApp.Views.Article
    open GiraffeApp.Data.Articles

    let handleGetHello =
        fun (next : HttpFunc) (ctx : HttpContext) ->
            task {
                let response = {
                    Text = "Hello world, from Giraffe!"
                }
                return! json response next ctx
            }
    
    let handleGetHelloWithName (name : string) =
        fun (next : HttpFunc) (ctx : HttpContext) ->
            task {
                let response = {
                    Text = sprintf "Hello, %s" name
                }
                return! json response next ctx
            }
    
    let handleGetIndex =
        fun (next : HttpFunc) (ctx : HttpContext) ->
            task {
                let response = {
                    Text = "Index"
                }
                return! xml response next ctx
            }
    
    let handleGetArticle =
        fun (next : HttpFunc) (ctx : HttpContext) ->
            task {
                return! ctx.WriteHtmlViewAsync (articleView articleExample)
            }