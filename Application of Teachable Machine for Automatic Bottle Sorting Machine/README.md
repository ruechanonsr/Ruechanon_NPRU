# Bottle Sorting with Teachable Machine

Dataset from https://www.kaggle.com/datasets/mostafaabla/garbage-classification

## Overview
**Bottle Sorting with Teachable Machine** เป็นโปรเจคที่นำเทคโนโลยี Machine Learning เข้ามาช่วยในการแยกประเภทขวดอัตโนมัติ โดยใช้ Teachable Machine ในการฝึกฝนโมเดลเพื่อให้ระบบสามารถแยกแยะขวดได้อย่างแม่นยำและรวดเร็ว ผ่านกระบวนการ Image Processing ซึ่งระบบนี้จะช่วยลดภาระของแรงงานคน เพิ่มความแม่นยำ และเพิ่มความเร็วในการคัดแยกขวดน้ำตามประเภทต่างๆ

## Features
- **การแยกขวดอัตโนมัติ**: ใช้ Teachable Machine เพื่อตรวจจับและแยกประเภทขวด เช่น ขวดพลาสติกและขวดแก้ว
- **เพิ่มประสิทธิภาพในการแยกขวด**: ระบบที่พัฒนานี้สามารถแยกขวดได้อย่างรวดเร็วและแม่นยำเมื่อเทียบกับการใช้แรงงานคน
- **ลดความผิดพลาด**: ด้วยการใช้ Machine Learning สามารถลดข้อผิดพลาดที่เกิดจากมนุษย์และเพิ่มความเสถียรของการทำงาน

## Project Structure
- **Teachable Machine Model**: โมเดลการเรียนรู้ที่ถูกฝึกฝนเพื่อแยกประเภทขวดผ่านข้อมูลภาพ
- **Arduino Communication**: ใช้การสื่อสารผ่าน Serial Communication กับ Arduino เพื่อสั่งงานระบบอัตโนมัติในการคัดแยกขวดน้ำ
- **Image Processing**: การประมวลผลภาพเพื่อให้ระบบรู้จักและแยกประเภทขวด

## Prerequisites
- **Teachable Machine**: สำหรับฝึกโมเดล Machine Learning
- **Python**: สำหรับรันโค้ดในการประมวลผลภาพและสื่อสารกับ Arduino
- **Arduino**: ใช้ในการควบคุมกระบวนการคัดแยกขวดน้ำ
- **ServoMotor**: สำหรับใช้หมุนทิศทางของเครื่องคัดแยกขวดน้ำ