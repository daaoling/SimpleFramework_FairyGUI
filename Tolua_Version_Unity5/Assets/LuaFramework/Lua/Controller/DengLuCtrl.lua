class("DengLuCtrl")
---@class DengLuCtrl

--local dengLuPanel

function DengLuCtrl.Start()
    log("DengLuCtrl:Start")
    DengLuCtrl.dengLuPanel = UIMgr.Instance():ShowPage(DengLuPanelList.DengLuPanel)
    DengLuCtrl.dengLuPanel.LoginBtn.onClick:Add(FairyGUI.EventCallback0(DengLuCtrl.Login))
    DengLuCtrl.dengLuPanel.RegisterBtn.onClick:Add(FairyGUI.EventCallback0(DengLuCtrl.Register))
end

--function DenLuCtrl.Handle(context)
--  log('you OnClick_Arg'..context.sender.name)
--  local senderName = context.sender.name
--end

function DengLuCtrl.Login()
  print("DenLuCtrl.Login")
  print(DengLuCtrl.dengLuPanel.LoginInput.text.."Login")
  print(DengLuCtrl.dengLuPanel.RegisterInput.text.."Register")
end


function DengLuCtrl.Register()
  print("DenLuCtrl.Register")
  print(DengLuCtrl.dengLuPanel.LoginInput.text.."Login")
  print(DengLuCtrl.dengLuPanel.RegisterInput.text.."Register")
end

--return DenLuCtrl