class("LoginScene", BaseScene)

function LoginScene:ctor()
  log("LoginScene:ctor")
--  加载包资源
  local uipackList = {"Common","DengLu"}
  LoginScene.super.ctor(self, uipackList)
end

function LoginScene:OnEnter()
    log("LoginScene:OnEnter")
    --  init view
    UIMgr.Instance():Init(DengLuPanelList)
    CtrlMgr.Instance():Init(DengLuCtrlList)
  --  init crlt
  -- .Init(DengLuCtrlList)
    local loginCtrl = CtrlMgr.Instance():GetCtrl(DengLuCtrlList.DengLuCtrl)
    loginCtrl.Start()
end