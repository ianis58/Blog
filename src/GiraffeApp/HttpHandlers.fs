module GiraffeApp.HttpHandlers

    open System
    open Microsoft.AspNetCore.Http
    open FSharp.Control.Tasks.V2.ContextInsensitive
    open Giraffe
    open GiraffeApp.Models
    open GiraffeApp.Views

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
                let author = {
                    FirstName = "Ianis"
                    LastName = "Rieuf"
                    UserName = "ianis58"
                    Registered = DateTime.Now.AddYears(-1).AddDays(115.0)
                }

                let tags = [
                    "it"
                    "actu"
                    "soudure"
                    "tests"
                    "tryin"
                    "f#"
                    "dotnetcore"
                ]

                let paragraphs = [
                    "Face aux centaines de modèles lancés chaque année, il est compliqué de déterminer quel est le meilleur smartphone du marché. Nous nous sommes pourtant lancés ce défi ô combien difficile et avons sélectionné ceux qui, selon nous, incarnent le top 10 de 2020."
                    "On vous rassure tout de suite : « meilleur smartphone » ne veut pas dire « smartphone le plus cher du marché ». Bien évidemment, les modèles les plus premium ont leur place dans ce classement mais d’autres smartphones, bien plus abordables ont réussi à tirer leur épingle du jeu avec d’autres atouts. Certains brillent par leur excellent rapport qualité-prix, d’autres pour leur originalité."
                    "Vous trouverez donc dans ce guide un top 10 des meilleurs smartphones du marché à l’heure actuelle. Tous les modèles évoqués ont été testés par la rédaction. Outre l’aspect technique de chaque smartphone, nous avons attaché une importance aux besoins auxquels ils répondent ainsi qu’à leur positionnement sur le marché."
                    "Lancés en février 2020, les derniers haut de gamme de Samsung s’imposent comme la meilleure proposition du constructeur. Si tous les yeux étaient tournés vers le Galaxy S20 Ultra (regroupe le meilleur de Samsung), nous avons de notre côté préféré l’équilibre des S20 et S20+."
                    "Les deux modèles embarquent à quelques détails près les mêmes technologies que la version Ultra. Mais ils coûtent près de 300 euros de moins. La différence de prix vaut-elle le coup de choisir l’Ultra ? Selon nous, non. On vous conseillera donc de vous orienter plutôt vers les S20 et S20+, tout aussi puissants, plus endurants (pour le S20+) et bien plus faciles à manipuler au quotidien."
                ]

                let article = {
                    Title = "test de titre"
                    Paragraphs = paragraphs
                    Date = DateTime.Now
                    Author = author
                    Tags = tags
                }
                return! ctx.WriteHtmlViewAsync (articleView article)
            }