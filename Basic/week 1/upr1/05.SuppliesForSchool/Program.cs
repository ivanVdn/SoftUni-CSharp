
//input

int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int cleaningTable = int.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

//calculations

double pensPrice = pens * 5.80;
double markersPrice = markers * 7.20;
double cleaninerPrice = cleaningTable * 1.20;
double sum = pensPrice + markersPrice + cleaninerPrice;
double discountPrice = sum - ((discount /100) * sum );


//output

Console.WriteLine(discountPrice);