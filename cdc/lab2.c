// C program to recognize strings under a*, a*b+, abb
#include <stdio.h>
#include <string.h>
int main()
{
    char str[100];
    int i = 0, c, state = 0;
    printf("Enter a string: ");
    gets(str);
    while (str[i] != '\0')
    {
        c = str[i++];
        switch (state)
        {

        case 0:
            if (c == 'a')
                state = 0;
            else if (c == 'b')
                state = 1;
            break;

        case 1:
            if (c == 'a')
                state = 3;
            else if (c == 'b')
                state = 2;
            break;

        case 2:
            if (c == 'a')
                state = 3;
            else if (c == 'b')
                state = 2;
            break;
        }
    }
    if (state == 0 || state == 1 || state == 2)
    {
        printf("String is accepted\n");
    }
    else
    {
        printf("String is not accepted\n");
    }
}