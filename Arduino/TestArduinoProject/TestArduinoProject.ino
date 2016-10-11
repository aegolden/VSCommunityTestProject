const int gasPin = A0;


void setup()
{

	Serial.begin(9600);
	pinMode(7, OUTPUT);
	pinMode(5, OUTPUT);

}

void loop()
{
	//digitalWrite(7, HIGH);
	Serial.println(String(analogRead(gasPin)));
	delay(250);
	//delay(1000); // Print value every 1 sec.

	if (Serial.available() > 0) {
		const unsigned char command = Serial.read();

		if (command == 0xFF)
			digitalWrite(7, HIGH);
		else if (command == 0xF0)
			digitalWrite(7, LOW);

		if (command == 0xEF)
			digitalWrite(5, HIGH);
		else if (command == 0xE0)
			digitalWrite(5, LOW);
	}

}
