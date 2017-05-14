class("MainScene", BaseScene)

function MainScene:ctor()
  log("MainScene:ctor")
  local uipackList = {"Common","Main"}
  MainScene.super.ctor(self, uipackList)
end

function MainScene:OnEnter()
  log("MainScene:OnEnter")
  
  --  init view
  UIMgr.Instance():Init(MainPanelList)
  --  init crlt
  CtrlManager.Instance():Init(MainCtrlList)
  CtrlManager.Instance():GetCtrl(MainCtrlList.MainCtrl):Start()
end