local pin = 4 
local value = gpio.HIGH   
gpio.mode(pin, gpio.OUTPUT)
gpio.write(pin, value)