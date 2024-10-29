#include <DHT.h>
#define DHTPIN 8
#define DHTTYPE DHT11
DHT dht (DHTPIN, DHTTYPE);
char c;
String SerialData;

#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,20,4);

int LED_B = 12;
int LED_R = 13;

void setup() {
  Serial.begin(115200);
  dht.begin();
  pinMode (7, OUTPUT);
  pinMode(LED_B, OUTPUT);
  pinMode(LED_R, OUTPUT);
  
  digitalWrite (7, LOW);

  lcd.init();
  lcd.init();
  lcd.backlight(); // Set LCD backlight
  lcd.setCursor(0,0);  
  lcd.setCursor(1,0); 
}

void loop() {
  float t = dht.readTemperature();
  float h = dht.readHumidity();

  //LED Display
    
  if (t <= 30)
     {
       digitalWrite(LED_R, LOW);
       digitalWrite(LED_B, HIGH);
     }
  if (t >= 30)
     {
       digitalWrite(LED_R, HIGH); 
       digitalWrite(LED_B, LOW); 
     }

  if (isnan(h) || isnan(t))
  {return;}

  //Send data to C#
  Serial.print("@");
  Serial.print(t); Serial.print("A");
  Serial.print(h); Serial.print("B");
  Serial.print("\n");
  delay(500);

  //LED Control
  while(Serial.available()>0)
  {
    c = Serial.read();
    SerialData += c;  
  }

  if(c=='#')
  {
    if(SerialData == "ON#")
    {
      digitalWrite(7, HIGH);  
    }
    
    else if(SerialData == "OFF#")
    {
      digitalWrite(7, LOW);    
    }
    c = 0;
    SerialData = "";
  }

  //LCD Display
      lcd.setCursor(0,0); // Show in line 1
      lcd.print("Temp : ");
      lcd.print(t); // Output Temperature Value
      lcd.print("C");

      lcd.setCursor(0,1); // Show in line 2
      lcd.print("Humi : "); 
      lcd.print(h); // Output Humidity Value
      lcd.print("%"); 
}
