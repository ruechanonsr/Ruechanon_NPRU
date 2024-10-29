#include <Wire.h>
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27,16,2);

#include <DHT.h>
#define DHTPIN 8
#define DHTTYPE DHT11 
DHT dht(DHTPIN, DHTTYPE); 

// LED White = 7 Blue = 12 Red = 13
int LED_W = 7;
int LED_B = 12;
int LED_R = 13;

void setup() 
{
     Serial.begin(115200);

     pinMode(LED_W, OUTPUT);
     pinMode(LED_B, OUTPUT);
     pinMode(LED_R, OUTPUT);
     
     lcd.init();
     lcd.init();
     lcd.backlight(); // Set LCD backlight
     lcd.setCursor(0,0);  
     lcd.setCursor(1,0);    
     dht.begin();// Set DHT11 Sensors
 }

void loop() 
{
     digitalWrite(LED_W, HIGH);
     //digitalWrite(LED_B, HIGH);   
     
     // Show Temperature and Humidity in LCD
     float temp = dht.readTemperature(); // Read Temperature value from DHT11
     float humi = dht.readHumidity(); // Read Humidity value from DHT11
          lcd.setCursor(0,0); // Show in line 1
          lcd.print("Temp ");
          lcd.print(temp); // Output Temperature Value
          lcd.print("C");

          lcd.setCursor(1,0); // Show in line 2
          lcd.print("Humi"); 
          lcd.print(humi); // Output Humidity Value
          lcd.print("%");

     if (temp >= 30)
     {
         digitalWrite(LED_R, HIGH); 
         digitalWrite(LED_B, LOW);
     }
     if (temp <= 30)
     {
         digitalWrite(LED_B, HIGH); 
         digitalWrite(LED_R, LOW); 
     }
     

     // Show Temperature and Humidity in Serial Monitor;
     Serial.print("Temperature = ");
     Serial.print(temp); // Show Temperature
     Serial.println(" C");

     Serial.print("Humidity = ");
     Serial.print(humi); // Show Humidity
     Serial.println("%");
     delay(2000);
}
