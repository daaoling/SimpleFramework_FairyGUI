require "Common/define"
require "Common/functions"
require "framework/init"

local M = {}

MyApp = M

M.curScene = nil

function M.run()
  M.enterScene("LoginScene")
end

function M.enterScene(SceneName)
  if M.curScene then
      M.curScene:OnExit()
  end
  M.curScene = require("scenes/"..SceneName).new()
  loadMgr:ReplaceScene(M.curScene.ablist, M.OnLoadFinish)
end

function M.OnLoadFinish()
  M.curScene:OnEnter()
end

return M