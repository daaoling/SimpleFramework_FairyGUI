--require "BaseState"
--require "FsmMachine"

--mainState = BaseState:New("Main")
--function nextState:Before()
--  print(" nextState Before " .. self.Name)
--end

--nextState = BaseState:New("Next")
--function nextState:Update()
--  print(" nextState Update " .. self.Name)
--end

--fsm = FSM:New()
--fsm:AddInitState(mainState)
--fsm:AddState(nextState)



----local index = 0
----while index < 10 do
  
----  fsm:Update()
  
----  index = index + 1
----  print("index"..index)
----  if index == 1 then
----    fsm:SwitchState("Next")
----  end
  
----end

