// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter hours (1 - 12):");
int hour = Convert.ToInt32(Console.ReadLine());
if(hour <= 0 || hour > 12){
    Console.WriteLine("Hour input out of range");
    return;
}

Console.WriteLine("Enter minutes (0 - 59):");
int minutes = Convert.ToInt32(Console.ReadLine());
if(minutes < 0 || minutes >= 60){
    Console.WriteLine("Minutes input out of range");
    return;
}

const int anglePerHour = 360 / 12;
const int anglePerMin = 360 / 60;

double minuteAngle = anglePerMin * minutes;
double hourAngle = hour * anglePerHour + minutes / 60.0 * anglePerHour;

double smallestAngle = Math.Abs(hourAngle - minuteAngle);

if(smallestAngle > 180){
    smallestAngle = 360 - smallestAngle;
}

Console.WriteLine(smallestAngle);