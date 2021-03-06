--require "Common/define"

require "3rd/pblua/login_pb"
require "3rd/pbc/protobuf"

local sproto = require "3rd/sproto/sproto"
local core = require "sproto.core"
local print_r = require "3rd/sproto/print_r"

PromptCtrl = {};
local this = PromptCtrl;

local panel;
local prompt;
local transform;
local gameObject;

--构建函数--
function PromptCtrl.New()
	logWarn("PromptCtrl.New--->>");
	return this;
end

function PromptCtrl.Awake()
	logWarn("PromptCtrl.Awake--->>");
  
  FairyGUI.GRoot.inst:SetContentScaleFactor(1152,648);
  FairyGUI.UIPackage.AddPackage("UI/DengLu");
  mainView = FairyGUI.UIPackage.CreateObject("DengLu","Main");
  mainView:SetSize(FairyGUI.GRoot.inst.width, FairyGUI.GRoot.inst.height);
  mainView:AddRelation(FairyGUI.GRoot.inst, FairyGUI.RelationType.Size);
  FairyGUI.GRoot.inst:AddChild(mainView);
  
end

--启动事件--
function PromptCtrl.OnCreate(obj)
--	gameObject = obj;
--	transform = obj.transform;

--	panel = transform:GetComponent('UIPanel');
--	prompt = transform:GetComponent('LuaBehaviour');
--	logWarn("Start lua--->>"..gameObject.name);

--	this.InitPanel();	--初始化面板--
----  prompt:AddClick(PromptPanel.btnOpen, this.OnClick);
--  listener = UIEventListener.Get(PromptPanel.btnOpen)
--  AddClick(PromptPanel.btnRegister, this.Register)
--  AddClick(PromptPanel.btnLogin, this.Login)
--  local timer = Timer.New(this.delay,5,false,true)
--  timer:Start()
end

--function PromptCtrl.delay()
--  print "clear"
--  RemoveClick(listener, this.OnClick)
--end


--初始化面板--
function PromptCtrl.InitPanel()
	panel.depth = 1;	--设置纵深--
	local parent = PromptPanel.gridParent;
	local itemPrefab = prompt:LoadAsset('PromptItem');
	for i = 1, 100 do
		local go = newObject(itemPrefab);
		go.name = tostring(i);
		go.transform.parent = parent;
		go.transform.localScale = Vector3.one;
		go.transform.localPosition = Vector3.zero;
		prompt:AddClick(go, this.OnItemClick);

		local goo = go.transform:FindChild('Label');
		goo:GetComponent('UILabel').text = i;
	end
	local grid = parent:GetComponent('UIGrid');
	grid:Reposition();
	grid.repositionNow = true;
	parent:GetComponent('WrapGrid'):InitGrid();
end


function PromptCtrl.Register(go)
--	if TestProtoType == ProtocalType.BINARY then
--		this.TestSendBinary();
--	end
--	if TestProtoType == ProtocalType.PB_LUA then
--		this.TestSendPblua();
--	end
--	if TestProtoType == ProtocalType.PBC then
--		this.TestSendPbc();
--	end
--	if TestProtoType == ProtocalType.SPROTO then
--		this.TestSendSproto();
--	end
	log("OnClick---->>>"..go.name);
	log("OnClick---->>>"..PromptPanel.roleName.value);
  log("OnClick---->>>"..PromptPanel.password.value);
  this.TestItSelf();
--    this.TestSendPblua();
end

--滚动项单击事件--
function PromptCtrl.Login(go)
	log(go.name);
end



function PromptCtrl.TestItSelf()
  local login = Login_pb.LoginRequest()
  login.id = 2000;
  login.name = 'game';
  login.email = 'jarjin@163.com';
  local msg = login:SerializeToString();
  
  local buffer = ByteBuffer.New();
  buffer:WriteInt(Opcodes.login);
  buffer:WriteBuffer(msg);
  networkMgr:SendMessage(buffer); 
end

--测试发送SPROTO--
function PromptCtrl.TestSendSproto()
    local sp = sproto.parse [[
    .Person {
        name 0 : string
        id 1 : integer
        email 2 : string

        .PhoneNumber {
            number 0 : string
            type 1 : integer
        }

        phone 3 : *PhoneNumber
    }

    .AddressBook {
        person 0 : *Person(id)
        others 1 : *Person
    }
    ]]

    local ab = {
        person = {
            [10000] = {
                name = "Alice",
                id = 10000,
                phone = {
                    { number = "123456789" , type = 1 },
                    { number = "87654321" , type = 2 },
                }
            },
            [20000] = {
                name = "Bob",
                id = 20000,
                phone = {
                    { number = "01234567890" , type = 3 },
                }
            }
        },
        others = {
            {
                name = "Carol",
                id = 30000,
                phone = {
                    { number = "9876543210" },
                }
            },
        }
    }
    local code = sp:encode("AddressBook", ab)
    ----------------------------------------------------------------
    local buffer = ByteBuffer.New();
    buffer:WriteShort(Protocal.Message);
    buffer:WriteByte(ProtocalType.SPROTO);
    buffer:WriteBuffer(code);
    networkMgr:SendMessage(buffer);
end

--测试发送PBC--
function PromptCtrl.TestSendPbc()
    local path = Util.DataPath.."lua/3rd/pbc/addressbook.pb";

    local addr = io.open(path, "rb")
    local buffer = addr:read "*a"
    addr:close()
    protobuf.register(buffer)

    local addressbook = {
        name = "Alice",
        id = 12345,
        phone = {
            { number = "1301234567" },
            { number = "87654321", type = "WORK" },
        }
    }
    local code = protobuf.encode("tutorial.Person", addressbook)
    ----------------------------------------------------------------
    local buffer = ByteBuffer.New();
    buffer:WriteShort(Protocal.Message);
    buffer:WriteByte(ProtocalType.PBC);
    buffer:WriteBuffer(code);
    networkMgr:SendMessage(buffer);
end

--测试发送PBLUA--
function PromptCtrl.TestSendPblua()
    local login = login_pb.LoginRequest();
    login.id = 2000;
    login.name = 'game';
    login.email = 'jarjin@163.com';
    local msg = login:SerializeToString();
    ----------------------------------------------------------------
    local buffer = ByteBuffer.New();
    buffer:WriteShort(Protocal.Message);
    buffer:WriteByte(ProtocalType.PB_LUA);
    buffer:WriteBuffer(msg);
    networkMgr:SendMessage(buffer);
end

--测试发送二进制--
function PromptCtrl.TestSendBinary()
    local buffer = ByteBuffer.New();
    buffer:WriteShort(Protocal.Message);
    buffer:WriteByte(ProtocalType.BINARY);
    buffer:WriteString("ffff我的ffffQ靈uuu");
    buffer:WriteInt(200);
    networkMgr:SendMessage(buffer);
end

--关闭事件--
function PromptCtrl.Close()
	panelMgr:ClosePanel(CtrlNames.Prompt);
end