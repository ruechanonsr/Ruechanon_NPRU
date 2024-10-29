#include <TridentTD_LineNotify.h>
#include <ESP8266WiFi.h>
#include <WiFiUdp.h>
#define WIFI_SSID " " //ชื่อ WIFI ที่ต้องการใช้
#define WIFI_PASSWORD " " //รหัส WIFI
#define LINE_TOKEN "Your Token" //Token ที่ได้จากการออก
#define SENSOR_PIN A0

void setup() {
  Serial.begin(115200);
  Serial.println();
  Serial.println(LINE.getVersion());
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  Serial.print("WiFi connecting to %s\n");
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(400);
  }
  
  Serial.print("\nWiFi connected\nIP : ");
  Serial.println(WiFi.localIP());
  LINE.setToken(LINE_TOKEN);
}

void loop() {
  int sensorValue = analogRead(SENSOR_PIN);
  Serial.print("Value: ");
  Serial.println(sensorValue);
  delay(2000);
  if (sensorValue >= 300) {
    Serial.println("Line");
    LINE.notify("ระดับควันเกินกำหนดแล้ว");
    // Wait until the gas level drops below the threshold
    while (analogRead(SENSOR_PIN) >= 300) {
      delay(500);
    }
  }
}
