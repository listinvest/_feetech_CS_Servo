#include <Servo.h>
Servo motor;

int deger2;
void setup() {
motor.attach(3);
Serial.begin(9600);
}

void loop() {
int deger;
  if(Serial.available())
{ 
  deger=Serial.read();
  if(deger>0)
  deger2=deger;
}
motor.write(deger2);
  
}
