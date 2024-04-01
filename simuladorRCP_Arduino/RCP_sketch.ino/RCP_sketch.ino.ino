#include <SoftwareSerial.h>

SoftwareSerial ble(10, 11);

boolean buttonState = false;
boolean lastButtonState = false;
boolean almost = false;
int BPM = 0;
float bpmCount;
float rcpCount = 0;
double distanceCM;
int timeSec, timeRCP, BPM_1;
float totalTime;
unsigned long timeBegin, timeEnd;
unsigned long tiempo;
unsigned long lastFreqTime = 0;

const int pressureInput = A0;
const int redLed = 3;
const int yellowLed = 4;
const int greenLed = 5; 

void setup() {
  Serial.begin(9600);
  ble.begin(9600);
  pinMode(pressureInput,INPUT);
  pinMode(redLed,OUTPUT);
  pinMode(greenLed,OUTPUT);
  pinMode(yellowLed,OUTPUT);
}

void useless();
void correct();
void excessive();
void insufficient();
double distance(int n);
double movingAverage(double value);

void loop();

void useless() {
  digitalWrite(redLed,LOW);
  digitalWrite(greenLed,LOW);
  digitalWrite(yellowLed,LOW);
}

void correct() {
  digitalWrite(redLed,LOW);
  digitalWrite(greenLed,HIGH);
  digitalWrite(yellowLed,LOW);
}

void excessive() {
  digitalWrite(redLed,HIGH);
  digitalWrite(greenLed,LOW);
  digitalWrite(yellowLed,LOW);
}

void insufficient() {
  digitalWrite(redLed,LOW);
  digitalWrite(greenLed,LOW);
  digitalWrite(yellowLed,HIGH);
}

double distance(int n) {
  long sum = 0;
  for(int i = 0; i < n; i++) {
    sum = sum + analogRead(pressureInput);
  }
  double adc = sum/n;
  double distanceCM = 21863.12*pow(adc,-1.55);
  if(distanceCM > 11.5) {
    return(11.5);
  }
  else if(distanceCM < 2) {
    return(2.0);
  }
  return(distanceCM);
}

double movingAverage(double value) {
  const long bufferSize = 5;
  static double buffer[bufferSize] = {0};
  static long inputIndex = 1;
  static long outIndex = inputIndex+1;
  static double sum = 0;
  buffer[inputIndex] = value;
  sum = sum+buffer[inputIndex]-buffer[outIndex];
  inputIndex == (bufferSize-1) ? inputIndex = 0 : inputIndex++;
  outIndex == (bufferSize-1) ? outIndex = 0 : outIndex++;
  return sum/(bufferSize-1);
}

void loop() {
  // Esta es la parte de medicion de la presion
  //tiempo = millis();
  distanceCM = distance(20);
  distanceCM = movingAverage(distanceCM);
  if(distanceCM > 7)  {
    almost = true;
  }
  if(distanceCM <= 7 && almost) {
    buttonState = !buttonState;
  }
  if(buttonState != lastButtonState) {
    if(buttonState == LOW) {
      rcpCount++;
      if(rcpCount == 1){
        timeBegin = millis();
      }
    }
  }
  if(rcpCount == 7) {
    rcpCount = 0;
    timeEnd = millis();
    totalTime = (timeEnd-timeBegin)/1000;
    bpmCount = (30.0/totalTime);
    BPM = int(bpmCount*20.0)/5; //uso factores de correccion
    Serial.flush();
    Serial.print("B");
    Serial.println(BPM);
    String infoB = "B" + String(BPM);
    ble.flush();
    ble.print(infoB);
    delay(50);
  }
  lastButtonState = buttonState;
  if(distanceCM >= 6.38 && distanceCM <= 8) {
    insufficient();
  }
  else if(distanceCM >= 5.42 && distanceCM < 6.38) {
    correct();
  }
  else if(distanceCM < 5.42) {
    excessive();
  }
  else {
    useless();
  }
  int distance = int(10*distanceCM);
  if (distance > 82) {
    distance = 81;
  }
  Serial.print("P");
  Serial.println(distance);
  String infoP = "P" + String(distance);
  ble.flush();
  ble.print(infoP);
  delay(100);
}
