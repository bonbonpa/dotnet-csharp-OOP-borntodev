#include "stdafx.h"
#include<stdio.h>
#include<conio.h>

//constant
//#define WIDTH 5 
//#define LENGTH 10 
//#define NEWLINE '\n' 

//int main() {
//	int area; 
//	area = WIDTH * LENGTH;
//	printf("value of area : %d", area);
//	printf("%c", NEWLINE);
//	getch();
//	return 0;
//
//}

int main() {
	int area;
	const int WIDTH = 5;
	const int LENGTH = 10;
	const char NEWLINE = '\n';
	area = WIDTH * LENGTH;
	printf("value of area : %d", area);
	printf("%c", NEWLINE);
	getch();
	return 0;

}
