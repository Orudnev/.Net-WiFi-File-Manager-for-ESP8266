print("servernode started")
pl = nil;
-- create a server
sv=net.createServer(net.TCP, 10)
-- server listen on 80
sv:listen(80,function(conn)
  conn:on("receive", function(conn, pl)
    payload = pl;
    --print(pl.."\n")
    --conn:send("received") 
    --print("send response")
 
    ------------------------------------------------------------------------
    if string.sub(pl, 0, 11) == "**command**"  then
      sck = conn 
      dofile("wifi_tools.lua")
    end
    -------------------------------------------------------------------------
    conn:close()
    collectgarbage()
  end)
end)
print("Server running...")
