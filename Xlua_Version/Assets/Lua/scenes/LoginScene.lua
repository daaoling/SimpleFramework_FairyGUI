local LoginScene = class("LoginScene", framework_baseScene) 

function LoginScene:ctor()
  log("LoginScene:ctor")
--  加载包资源
  local uipackList = {"Common","DengLu"}
  LoginScene.super.ctor(self, uipackList)
end

function LoginScene:OnEnter()
  log("LoginScene:OnEnter")
  
  --  init view
  UIMgr.Init(DengLuPanelList)
  --  init crlt
  CtrlManager.Init(DengLuCtrlList)
  CtrlManager.GetCtrl(DengLuCtrlList.DenLuCtrl):Start()
end


return LoginScene