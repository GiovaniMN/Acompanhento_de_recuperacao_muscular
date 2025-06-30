/*#include <MySQL_Connection.h>
  #include <MySQL_Cursor.h>*/
void setup() {
  Serial.begin(9600);
}

void loop() {
  int y = analogRead(A0);
  int x;
  x = ((y * 100) / 1023);

  if (x < 0){
    x = 0;
    Serial.println(x);
  }
  else{
    Serial.println(x);
  }
  
  delay(100);
}
