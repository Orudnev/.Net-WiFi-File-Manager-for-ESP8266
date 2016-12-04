--print('wifi_tools')
local _, count = payload:gsub('\n', '\n')
arraylines = count
filedata = {}
local x = 0
local data1 = ""
for token in string.gmatch(payload, '[^\n]+') do
  filedata[x] = token
  x = x + 1
end
if string.sub(filedata[0],10,20) == "**Dir**" then
    print("Dir")
    fileListStr = "" 
    l=file.list()
    for k,v in pairs(l) do
        if fileListStr ~= "" then fileListStr = fileListStr.."," end
        row = k..";"..v
        fileListStr = fileListStr..row
    end
    sck:send(fileListStr) 
end
if string.sub(filedata[0],10,21) == "**Readfile**" then
  fname = filedata[1]
  offset=tonumber(filedata[2])
  length=tonumber(filedata[3])  
  if (file.open(fname, "r")) then
    --print("Readfile("..fname..")".." offset:"..offset.." length:"..length)
    file.seek("set",offset)
    strBlock = file.read(length)
    sck:send(strBlock)  
    file.close(filedata[1])
  end
end
if string.sub(filedata[0],10,20) == "**Apdfile**" then
  file.open(filedata[1], "a+")
  x=2
  while x <= arraylines do
    if filedata[x]~=nil then
        file.writeline(filedata[x])
    end    
    x=x+1
  end
  file.close(filedata[1])
end
if string.sub(filedata[0],10,20) == "**Newfile**" then
  file.open(filedata[1], "w+")
  x=2
  while x <= arraylines do
    if filedata[x]~=nil then
       file.writeline(filedata[x])
    end   
    x=x+1
  end
  file.close(filedata[1])
end
if string.sub(filedata[0],10,20) == "**restart**" then
  node.restart()
end
if string.sub(filedata[0],10,20) == "**dofile **" then
  if filedata[1] then
    filetest = file.open(filedata[1],"r")
    if filetest then
      file.close(filedata[1])
      dofile(filedata[1])
    end
  end
end
if string.sub(filedata[0],10,20) == "**delfile**" then
  if filedata[1] then
    file.remove(filedata[1])
  end
end
if string.sub(filedata[0],10,20) == "**compile**" then
  if filedata[1] then
    filetest = file.open(filedata[1],"r")
    if filetest then
      file.close(filedata[1])
      node.compile(filedata[1])
    end
  end
end
payload=nil
sck:close()
--print("connection closed")
collectgarbage()
