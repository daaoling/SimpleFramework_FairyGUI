



class("MyApp")
--- @class MyApp
--- @field public curScene BaseScene

---@return MyApp
function MyApp.Instance()
  if MyApp.instance == nil then
    MyApp.instance = MyApp.new()
  end
  return MyApp.instance
end

function MyApp:ctor()
  self.curScene = nil;
end

function MyApp:run()
  self:enterScene("LoginScene")
end

function MyApp:enterScene(SceneName)
  if self.curScene then
    self.curScene:OnExit()
  end
  require("scenes/"..SceneName)
  self.curScene = _G[SceneName].new()
  loadMgr:ReplaceScene(self.curScene.ablist, self.OnLoadFinish)
end

function MyApp:OnLoadFinish()
  --self.curScene:OnEnter()
  MyApp.Instance().curScene.OnEnter()
end


--local M = {}
--
--MyApp = M
--
--M.curScene = nil
--
--function M.run()
--  --print("M.run")
--  M.enterScene("LoginScene")
--end
--
--function M.enterScene(SceneName)
--  if M.curScene then
--      M.curScene:OnExit()
--  end
--  M.curScene = require("scenes/"..SceneName).new()
--  --M.curScene:OnEnter()
--  loadMgr:ReplaceScene(M.curScene.ablist, M.OnLoadFinish)
--end
--
--function M.OnLoadFinish()
--  M.curScene:OnEnter()
--end
--
--return M