local MainScene = class("MainScene") 

function MainScene:ctor()
  log("MainScene:ctor")
end

function MainScene:OnEnter()
  log("MainScene:onEnter")
end

function MainScene:OnExit()
  log("MainScene:onExit")
end

return MainScene