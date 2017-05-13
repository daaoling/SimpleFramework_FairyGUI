local DenLuCtrl = class("DenLuCtrl")


local dengLuPanel

function DenLuCtrl.Start()
  log("MainCtrl:Start")
  dengLuPanel = UIMgr.ShowPage(DengLuPanelList.DengLuPanel)
  dengLuPanel.LoginBtn.onClick:Add(DenLuCtrl.Login)
  dengLuPanel.RegisterBtn.onClick:Add(DenLuCtrl.Register)  
end

--function DenLuCtrl.Handle(context)
--  log('you OnClick_Arg'..context.sender.name)
--  local senderName = context.sender.name
--end

function DenLuCtrl.Login()
  print("DenLuCtrl.Login")
  print(dengLuPanel.LoginInput.text.."Login")
  print(dengLuPanel.RegisterInput.text.."Register")
end


function DenLuCtrl.Register()
  print("DenLuCtrl.Register")
  print(dengLuPanel.LoginInput.text.."Login")
  print(dengLuPanel.RegisterInput.text.."Register")
end

return DenLuCtrl