require "events"


--主入口函数。从这里开始lua逻辑
function Main() 
    require("MyApp").new().run()
    --require("Controller..DenLuCtrl")
    --MyApp.run()
--  print("hello world")
end

--场景切换通知
function OnLevelWasLoaded(level)
	Time.timeSinceLevelLoad = 0
end