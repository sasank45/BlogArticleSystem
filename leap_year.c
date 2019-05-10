#include <stdio.h>
void main() {
	int a = 6;
	switch (a) {
		default: a+=2;
		case 4:	a = 4;
		case 5:	a++;
				break;
	}
	printf("%d", a);
}
