#include <Servo.h>
Servo myServo;

// กำหนดขา Pin ไว้ที่ 13
const int servoPin = 13;

void setup() {
  Serial.begin(9600);
  myServo.attach(servoPin); 
  delay(5000);
}

void loop() {
  if (Serial.available() > 0) {
    String inputString = Serial.readStringUntil('\n');  // อ่านข้อมูลจนกว่าจะเจอ \n
    inputString.trim();  // ตัดช่องว่างหรือ \n ที่อยู่ด้านท้ายออก

    Serial.println("Received: " + inputString);  // แสดงข้อมูลที่รับมาใน Serial Monitor

    if (inputString == "empty") {
      myServo.write(90); //หากข้อมูลที่รับมาเป็น empty ให้กลับมาอยู่ตรงกลาง
    } 
    else if (inputString == "cans") {
      myServo.write(180); //หากข้อมูลที่รับมาเป็น cans ให้หมุนซ้าย
    }
    else if (inputString == "plastic") {
      myServo.write(0); //หากข้อมูลที่รับมาเป็น plastic ให้หมุนขวา
    }

    delay(200);
  }
}
