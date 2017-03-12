// BornToDev.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<stdio.h>
#include<conio.h>
#include<float.h>

extern int c;
extern float f;

int main2()
{
	//check size
	printf("-------- check size ------\n");
	printf("Storage size for int : %d \n", sizeof(int));
	printf("Minimum float positive value : %E\n", FLT_MIN);
	printf("Maximun float positive value : %E\n", FLT_MAX);
	printf("Precision value : %d\n", FLT_DIG);
	printf("-------------------------\n");

	//extern
	printf("-------- extern --------\n");
	int a, b;
	int c;
	float f;
	//
	a = 10;
	b = 20;
	c = a + b;
	printf("value of c : %d \n", c);
	f = 70.0 / 3.0;
	printf("value of f : %f \n", f);
	printf("-----------------------\n");
	getch();
    return 0;
}

