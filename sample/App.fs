module AmazingApp

open Browser.Dom
let PIXI = Fable.Pixi.PIXI.pixi

let app = PIXI.Application.Create()
document.body.appendChild app.view |> ignore

let img = PIXI.Sprite.from "./fable_logo_small.png"
app.stage.addChild img |> ignore
