local pin = 4 
local value = gpio.LOW
gpio.mode(pin, gpio.OUTPUT)
gpio.write(pin, value)