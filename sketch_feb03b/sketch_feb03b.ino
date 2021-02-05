void setup() {
  // put your setup code here, to run once:

}

void loop() {
  // put your main code here, to run repeatedly:

}
iint speaker=9;

int lng=13;

char notes[]="ggaaggeggeed";

int beats[]={1,1,1,1,1,1,2,1,1,1,1,1,2, };

int tempo=300;

void playTone(int tone, int duration)//tone 값과 길이를 계산해서 반환하는 함수

{

for(long i=0; i<duration*1000L; i+=tone*2)

{

digitalWrite(speaker, HIGH);

delayMicroseconds(tone);

digitalWrite(speaker, LOW);

delayMicroseconds(tone);

}

}

void playNote(char note, int duration)

{

char names[]={'c','d','e','f','g','a','b','c'};

int tones[]={1915,1700,1519,1432,1275,1136,1014,956};//부저음 timehigh

for(int i=0; i<8; i++)

{

if(names[i]==note)

{

playTone(tones[i], duration);//tone 값과 길이 값을 계산

}

}

}

void setup() {

pinMode(speaker,OUTPUT);

}

​

void loop() { //실행

for(int i=0; i<lng;i++)

{

if(notes[i]==' ')

{

delay(beats[i]*tempo);

}

else

{

playNote(notes[i], beats[i]*tempo);

}

​

delay(tempo/2);

}

}
[출처] 아두이노 프로젝트 8. 부저로 노래 만들기|작성자 김예본
