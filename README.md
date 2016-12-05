# .Net-WiFi-File-Manager-for-ESP8266

This project is .Net implementation of solution designed by Breagan: https://github.com/breagan/ESP8266_WiFi_File_Manager
Instead of php web server (used by Breagan for commutication with ESP8266) I used .Net application

Wifi File Manager allows to manage files stored on ESP8266 using wireless tcp connection.

###Features
* Add files to ESP8266 from PC
- View list of files stored on ESP8266
- Delete files from ESP8266
- Compile files stored on ESP8266
- View files stored on ESP8266
- Run files stored on ESP8266 ("DoFile" command)
- Restart ESP

### Setup
1. Flash the NodeMCU firmware on your ESP8266
2. Copy files stored in the "Lua_Scripts" folder to local folder of your PC
3. Edit the 2-nd line of the init.lua according to your LAN settings: 
           wifi.sta.config("YourSSID>","yourPassword",1)
4. Upload files from the folder of step2 to ESP8266 (using ESPlorer or another app) and restart ESP8266          
5. Unpack archive srored in "Release" folder on your PC and launch FileManageer.exe
6. Press the "Settings" button and specify IP address of your ESP8266
7. Specify "Project folder" - the folder used in the step 2 and press "Save" button
8. Press "Refresh" button - files from project folder should appear in the left pane, files stored in ESP should appear in the right pane

