require "Common/define"
require "Common/functions"
require "framework/init"

MyApp = {}

local this = MyApp

this.CurSeneName = nil

this.Scenes = {}
this.Scenes["LoginScene"] = require("scenes/LoginScene").new()
this.Scenes["MainScene"] = require("scenes/MainScene").new()

function MyApp.run()
  this.enterScene("LoginScene")
end

function MyApp.enterScene(SceneName)
  if this.CurSeneName ~= SceneName then
    
    if this.CurSeneName then
      this.Scenes[this.CurSeneName]:OnExit()
    end
    
    this.CurSeneName = SceneName
    
    loadMgr:ReplaceScene("", this.OnLoadFinish)
  end
end

function MyApp.OnLoadFinish()
  this.Scenes[this.CurSeneName]:OnEnter()
end