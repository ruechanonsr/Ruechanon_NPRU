# Smart Home with Arduino and Visual Studio

Mini Project บ้านอัจฉริยะ แสดงค่าอุณหภูมิ ความชื่นของบ้านบน Visual Studio พร้อมกราฟ สามารถสั่งเปิด-ปิดไฟได้ด้วย และแสดงค่าอุณหภูมิบนจอ LCD และไฟจะเปลี่ยนสีหากอุณหภูมิร้อนหรือเย็น

## FOLDER
- SmartHome_Control : โค้ดแสดงค่าต่างๆบน Visual Studio 
- ArduinoDHT11DATAtoVS : โค้ด Arduino ส่งค่าของอุณหภูมิกับความชื้นไปที่ Visual Studio
- DHT11_toLCD : โค้ด Arduino ควบคุมไฟ LED จากค่าอุณหภูมิ

## อุปกรณ์ที่ต้องใช้
- Arduino
- LED 3 สี
- จอ LCD
- เซนเซอร์ DHT22 หรือ DHT11 ก็ได้