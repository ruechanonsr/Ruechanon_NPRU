#include <Servo.h>

const int servoPin = 13;
Servo myServo;

void setup() {
  Serial.begin(9600);  // เริ่มต้น Serial communication
  myServo.attach(servoPin);  // แนบเซอร์โวกับพินที่กำหนด 
  delay(5000);
}

void loop() {
  if (Serial.available() > 0) {
    String inputString = Serial.readStringUntil('\n');  // อ่านข้อมูลจนกว่าจะเจอ \n
    inputString.trim();  // ตัดช่องว่างหรือ \n ที่อยู่ด้านท้ายออก

    Serial.println("Received: " + inputString);  // แสดงข้อมูลที่รับมาใน Serial Monitor

    if (inputString == "empty") {
      myServo.write(90);
    } 
    else if (inputString == "cans") {
      myServo.write(180);
    }
    else if (inputString == "plastic") {
      myServo.write(0);
    }

    delay(200);
  }
}
