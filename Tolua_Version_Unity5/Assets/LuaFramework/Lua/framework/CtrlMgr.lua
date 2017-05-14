class("CtrlMgr")
---@class CtrlMgr
---@field public ctrlList table


---@return CtrlMgr
function CtrlMgr.Instance()
    if CtrlMgr.instance == nil then
        CtrlMgr.instance = CtrlMgr.new()
    end
    return CtrlMgr.instance
end

function CtrlMgr:Init(ctrlList)
    self.ctrlList = {}
	logWarn("CtrlManager.Init----->>>");
    for k,v in pairs(ctrlList) do
        local moduleName = "Controller."..v
        require(moduleName)
        self.ctrlList[k] = _G[v]
        print(moduleName, _G[v], self.ctrlList[k])
        --.new() no need
    end
end

--添加控制器--
--function CtrlManager.AddCtrl(ctrlName, ctrlObj)
--	ctrlList[ctrlName] = ctrlObj;
--end

--获取控制器--
function CtrlMgr:GetCtrl(ctrlName)
	return self.ctrlList[ctrlName];
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
--return M