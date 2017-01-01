local BaseScene = class("BaseScene")

function BaseScene:ctor(uipackList)
  self.ablist = ""
  for i, PanelName in ipairs(uipackList) do
      self.ablist = self.ablist .. ":".. PanelName
  end
end

function BaseScene:OnEnter()

end

function BaseScene:OnExit()
  UIMgr.ClearScene()
end

return BaseScene 