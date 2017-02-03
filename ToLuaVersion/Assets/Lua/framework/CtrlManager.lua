--require "Common/define"
--require "Controller/PromptCtrl"
--require "Controller/MessageCtrl"

local M = { }

CtrlManager = M;
--local this = CtrlManager;
--local ctrlList = {};	--控制器列表--
M.ctrlList = nil

function M.Init(ctrlList)
  M.ctrlList = {}
	logWarn("CtrlManager.Init----->>>");
  for k,v in pairs(ctrlList) do
     M.ctrlList[k] = require("Controller/"..v).new()
  end
--	ctrlList[CtrlNames.Prompt] = PromptCtrl.New();
--	ctrlList[CtrlNames.Message] = MessageCtrl.New();
--	return this;
end

--添加控制器--
--function CtrlManager.AddCtrl(ctrlName, ctrlObj)
--	ctrlList[ctrlName] = ctrlObj;
--end

--获取控制器--
function M.GetCtrl(ctrlName)
	return M.ctrlList[ctrlName];
end

--移除控制器--
--function CtrlManager.RemoveCtrl(ctrlName)
--	ctrlList[ctrlName] = nil;
--end

--关闭控制器--
--function CtrlManager.Close()
--	logWarn('CtrlManager.Close---->>>');
--  CtrlManager.ctrlList = nil
--end
return M