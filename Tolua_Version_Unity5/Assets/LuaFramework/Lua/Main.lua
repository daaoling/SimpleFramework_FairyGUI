require "events"
require "framework..init"
require "Common.define"
require "Common.functions"

--主入口函数。从这里开始lua逻辑
function Main()
	print("Main:start")
	--register view
	--register controller
	--register scene

    --MyApp.Instance():run()
	local var =  MyApp.Instance()
	var:run()
end

--场景切换通知
function OnLevelWasLoaded(level)
	Time.timeSinceLevelLoad = 0
end