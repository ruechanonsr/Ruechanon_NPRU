# Smart Home Project with Arduino and Visual Studio

## FOLDER
- SmokeSensorToLine : โค้ด Arduino ส่งค่าควันไปไปที่ LINE Notify
- SerialMonitor_toVS : โค้ด C# แสดง Serial Monitor บน Visual Studio

## อุปกรณ์ที่ต้องใช้
- Arduino รุ่นที่มี WiFi
- เซนเซอร์ MQ ตรวจจับควัน

## การขอ Token LINE Notify
- เข้าเว็บ https://notify-bot.line.me/th/
- Login LINE ID
- เมื่อได้ Token แล้ว ให้นำไปใส่ไว้ตรงโค้ด และเชื่อมต่อ WiFi ให้เรียบร้อย

```
#define WIFI_SSID " " //ชื่อ WIFI
#define WIFI_PASSWORD " " //รหัส WIFI
#define LINE_TOKEN "Your Token" //ใส่ Token
```

ปล. LINE Notify กำลังจะปิดแล้วในเดือนมีนาคมปี 2025 รีบใช้ล่ะ