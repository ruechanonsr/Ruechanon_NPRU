# Application of Teachable Machine for Automatic Bottle Sorting Machine

## LINK
Dataset from https://www.kaggle.com/datasets/mostafaabla/garbage-classification

Project Models https://teachablemachine.withgoogle.com/models/TPvJ2kN2W/

Train Models from https://teachablemachine.withgoogle.com/

## Overview
**Bottle Sorting with Teachable Machine** เป็นโปรเจคที่นำเทคโนโลยี Machine Learning เข้ามาช่วยในการแยกประเภทขวดอัตโนมัติ โดยใช้ Teachable Machine ในการฝึกฝนโมเดลเพื่อให้ระบบสามารถแยกแยะขวดได้อย่างแม่นยำและรวดเร็ว ผ่านกระบวนการ Image Processing ซึ่งระบบนี้จะช่วยลดภาระของแรงงานคน เพิ่มความแม่นยำ และเพิ่มความเร็วในการคัดแยกขวดน้ำตามประเภทต่างๆ

## Features
- **การแยกขวดอัตโนมัติ**: ใช้ Teachable Machine เพื่อตรวจจับและแยกประเภทขวด เช่น ขวดพลาสติกและขวดแก้ว
- **เพิ่มประสิทธิภาพในการแยกขวดน้ำ**: ระบบที่พัฒนานี้สามารถแยกขวดได้อย่างรวดเร็วและแม่นยำเมื่อเทียบกับการใช้แรงงานคน
- **ลดความผิดพลาด**: ด้วยการใช้ Machine Learning สามารถลดข้อผิดพลาดที่เกิดจากมนุษย์และเพิ่มความเสถียรของการทำงาน

## Project Structure
- **Teachable Machine Model**: โมเดลการเรียนรู้ที่ถูกฝึกฝนเพื่อแยกประเภทขวดผ่านข้อมูลภาพ
- **Arduino Communication**: ใช้การสื่อสารผ่าน Serial Communication กับ Arduino เพื่อสั่งงานระบบอัตโนมัติในการคัดแยกขวดน้ำ
- **Image Processing**: การประมวลผลภาพเพื่อให้ระบบรู้จักและแยกประเภทขวด

## Prerequisites
- **Teachable Machine**: สำหรับฝึกโมเดล Machine Learning
- **Arduino**: ใช้ในการควบคุมกระบวนการคัดแยกขวดน้ำ
- **ServoMotor**: สำหรับใช้หมุนทิศทางของเครื่องคัดแยกขวดน้ำ

## การต่อยอด
- **หากต้องการเพิ่ม class** ให้สามารถคัดแยกประเภทขวดน้ำได้มากขึ้น ให้เทรนด์โมเดลใหม่ แล้วเปลี่ยนโค้ดใน index.html

```
    const URL = "Your Model URL"; // ใส่ URL โมเดลที่ได้จาก Teachable Machine
```