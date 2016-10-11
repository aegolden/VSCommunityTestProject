const int gasPin = A0;

void setup()
{

	Serial.begin(9600);

}

void loop()
{

	Serial.println(String(analogRead(gasPin)));
	delay(1000); // Print value every 1 sec.

}
