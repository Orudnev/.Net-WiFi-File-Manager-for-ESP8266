wifi.setmode(wifi.STATION)
wifi.sta.config("TP-LINK_Lukich","mortalcombat1",1)
wifi.sta.connect()
 
tmr.register(0, 5000, tmr.ALARM_SINGLE, 
function() 
    print("System Info:  ")
    print("IP: ")
    print(wifi.sta.getip())
    majorVer, minorVer, devVer, chipid, flashid, flashsize, flashmode, flashspeed = node.info();
    print("NodeMCU "..majorVer.."."..minorVer.."."..devVer.."\nFlashsize: "..flashsize.."\nChipID: "..chipid)
    print("FlashID: "..flashid.."\n".."Flashmode: "..flashmode.."\nHeap: "..node.heap())
    -- get file system info
    remaining, used, total=file.fsinfo()
    print("\nFile system info:\nTotal : "..total.." Bytes\nUsed : "..used.." Bytes\nRemain: "..remaining.." Bytes")
    print("\nReady") 
    tmr.stop(0)
    dofile("servernode.lua") 
end)
if not tmr.start(0) then print("Timer error") end  
print("timer started") 

