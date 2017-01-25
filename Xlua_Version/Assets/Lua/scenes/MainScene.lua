local MainScene = class("MainScene", framework_baseScene) 

function MainScene:ctor()
  log("MainScene:ctor")
  local uipackList = {"Common","Main"}
  MainScene.super.ctor(self, uipackList)
end

function MainScene:OnEnter()
  log("MainScene:OnEnter")
  
  --  init view
  UIMgr.Init(MainPanelList)
  --  init crlt
  CtrlManager.Init(MainCtrlList)
  CtrlManager.GetCtrl(MainCtrlList.MainCtrl):Start()
end

return MainScene