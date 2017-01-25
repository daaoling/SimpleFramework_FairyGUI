local MainPanel = class("MainPanel", framework_ui_basePage)

function MainPanel:ctor()
  MainPanel.super:ctor(false, "Main", "Main")
end

return MainPanel